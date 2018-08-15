using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class UserInfo
    {
        private string password;

        [Required]
        [RegularExpression("^[A-Z][a-z]{2,30}$")]
        public string FirstName { get; set; }

        [Required]
        [RegularExpression("^[A-Z][a-z]{2,30}$")]
        public string LastName { get; set; }

        [RegularExpression("^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }

        [RegularExpression("^[\\d]{3}-[\\d]{3}-[\\d]{4}$")]
        public string Phone { get; set; }

        [RegularExpression("^.{3,20}$")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserInfo()
        {
            FirstName = "Zzzz";
            LastName = "Zzzz";
            Email = "zzz@zzz.zzz";
            Phone = "111-111-1111";
            Password = "zzzzz";
        }

        public UserInfo(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
    }
}