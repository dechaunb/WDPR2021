using OkOk.Models;
using OkOk.Models.Identity;
using OkOk.Controllers;
using OkOk.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OkOk.Models
{
    public class ClientDashboardViewModel
    {
        public List<Treatment> AppointmentsDashboard { get; set; }
        public List<Treatment> AppointmentsTodayDashboard { get; set; }
        public List<DoctorApplicationUser> RecentDoctorsDashboard { get; internal set; }
    }
}