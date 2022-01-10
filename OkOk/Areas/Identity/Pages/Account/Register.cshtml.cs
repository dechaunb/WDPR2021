// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using OkOk.Models.Identity;
using OkOk.Models;

namespace OkOk.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ClientApplicationUser> _signInManager;
        private readonly UserManager<ClientApplicationUser> _userManager;
        private readonly IUserStore<ClientApplicationUser> _userStore;
        private readonly IUserEmailStore<ClientApplicationUser> _emailStore;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<ClientApplicationUser> userManager,
            IUserStore<ClientApplicationUser> userStore,
            SignInManager<ClientApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        
        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            [Display(Name = "E-mailadres")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Wachtwoord")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Bevestig Wachtwoord")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            [PersonalData]
            [Required]
            [Display(Name = "Voornaam")]
            [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
            ErrorMessage = "Tekens niet toegestaan.")]
            public string FirstName { get; set; }
            [PersonalData]
            [Required]
            [Display(Name = "Achternaam")]
            [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", 
            ErrorMessage = "Tekens niet toegestaan.")]
            public string LastName { get; set; }

            [Required]
            [Display(Name = "Postcode")]
            [RegularExpression(@"^(?:NL-)?(\d{4})\s*([A-Z]{2})$", 
            ErrorMessage = "Postcode moet in het format 1234AB zijn.")]
            public string ZipCode { get; set; }
            [Required]
            [Display(Name = "Land")]
            public string Country { get; set; }
            public Guid Id { get; set; }
            [Required]
            [Display(Name = "Huisnummer")]
            public int HouseNumber { get; set; }
            [Display(Name = "Toevoeging")]
            public string HouseNumberAddition { get; set; }
            [Required]
            [Display(Name = "Straat")]
            public string Street { get; set; }
            [Required]
            [Display(Name = "Stad")]
            public string City { get; set; }
        }


        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var user = new ClientApplicationUser {
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    UserName = Input.Email,
                    Email = Input.Email,
                    Address = new Address()
                    {
                        HouseNumber = Input.HouseNumber,
                        HouseNumberAddition = Input.HouseNumberAddition,
                        Street = Input.Street,
                        City = Input.City,
                        ZipCode = Input.ZipCode,
                        Country = Input.Country
                    },
                    LockoutEnabled = true
                };

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private ClientApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<ClientApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(ClientApplicationUser)}'. " +
                    $"Ensure that '{nameof(ClientApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<ClientApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<ClientApplicationUser>)_userStore;
        }
    }
}
