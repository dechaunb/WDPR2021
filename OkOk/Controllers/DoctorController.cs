using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using OkOk.Models;

namespace OkOk.Controllers;

[Authorize(Roles = "Doctor")]
public class DoctorController : Controller
{
    private readonly ILogger<DoctorController> _logger;

    public DoctorController(ILogger<DoctorController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
