using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StringsWeb.Models
{
    public class UserResponse
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}