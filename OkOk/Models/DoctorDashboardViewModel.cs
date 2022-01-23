using OkOk.Models;
using OkOk.Models.Identity;
using OkOk.Controllers;
using OkOk.Data;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OkOk.Models
{
    public class DoctorDashboardViewModel
    {
        public List<ClientApplicationUser> ClientsDashboard { get; set; }
        public List<Message> MessagesDashboard { get; set; }
        public List<Treatment> AppointmentsDashboard { get; set; }
        public List<SignUpRequest> SignUpRequestsDashboard { get; set; }
        public List<Treatment> AppointmentsTodayDashboard { get; set; }
        public List<ClientApplicationUser> RecentClientsDashboard { get; set; }
    }
}