using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagerView.Models
{
    public class Admin
    {
        public int AdminID { get; set; } // Add this property for Admin ID
        public string Name { get; set; } // Add this property for Admin Name
        public string Email { get; set; } // Add this property for Admin Email
        public string Password { get; set; } // Add this property for Admin Password

    }
}
