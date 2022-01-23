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
using OkOk.Data;

namespace OkOk.Areas.Identity.Pages.Account
{
    [Authorize(Roles = "Doctor")]
    public class MakeGuardianModel : PageModel
    {
        private readonly SignInManager<GuardianApplicationUser> _signInManager;
        private readonly UserManager<GuardianApplicationUser> _userManager;
        private readonly UserManager<ClientApplicationUser> _clientUserManager;
        private readonly IUserStore<GuardianApplicationUser> _userStore;
        private readonly IUserEmailStore<GuardianApplicationUser> _emailStore;
        private readonly ILogger<MakeGuardianModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ApplicationDbContext _context;

        public MakeGuardianModel(
            UserManager<GuardianApplicationUser> userManager,
            IUserStore<GuardianApplicationUser> userStore,
            SignInManager<GuardianApplicationUser> signInManager,
            ILogger<MakeGuardianModel> logger,
            IEmailSender emailSender,
            ApplicationDbContext context,
            UserManager<ClientApplicationUser> clientUserManager)
        {
            _clientUserManager = clientUserManager;
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _context = context;
        }

        
        [BindProperty]
        public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }
        public string Id { get; set; }
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
        }

        public async Task OnGetAsync(string id, string returnUrl = null)
        {
            Id = id;
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
            if (ModelState.IsValid)
            {
                var Child = _context.ClientApplicationUsers.FirstOrDefault(client => client.Id.Equals(Id));

                var user = new GuardianApplicationUser {
                    FirstName = Input.FirstName,
                    LastName = Input.LastName,
                    UserName = Input.Email,
                    Email = Input.Email,
                    Children = new List<ClientApplicationUser>()
                    {
                        Child
                    }
                };

                ClientApplicationUser client = await _clientUserManager.GetUserAsync(User);

                await _userStore.SetUserNameAsync(user, Input.Email, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, Input.Email, CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    _logger.LogInformation("Doctor created a new guardian with password.");
                    
                    var roleResult = await _userManager.AddToRoleAsync(user, "Guardian");
                    if(roleResult.Succeeded)
                    {
                        _logger.LogInformation("Guardian added to role 'Guardian'.");

                        client.Guardians.Add(user);
                        _context.Update(client);
                        _context.SaveChanges();
                    }
                    foreach (var error in roleResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private GuardianApplicationUser CreateUser()
        {
            try
            {
                return Activator.CreateInstance<GuardianApplicationUser>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(GuardianApplicationUser)}'. " +
                    $"Ensure that '{nameof(GuardianApplicationUser)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<GuardianApplicationUser> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<GuardianApplicationUser>)_userStore;
        }
    }
}
