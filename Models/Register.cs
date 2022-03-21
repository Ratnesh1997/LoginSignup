using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models
{
    public class Register
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Enter First Name")]
        [Required(ErrorMessage = "First Name Can't be Null")]
        public string FirstName { get; set; }
        [DisplayName("Enter Surname ")]
        [Required(ErrorMessage = "Surname Can't be Null")]
        public string SurName { get; set; }
        [DisplayName("Enter Gender")]
        [Required(ErrorMessage = "Gender Can't be Null")]
        public string Gender { get; set; }
        [DisplayName("Enter Age")]
        [Required(ErrorMessage = "Age Can't be Null")]
        public int age { get; set; }
        [DisplayName("Enter Email")]
        [Required(ErrorMessage = "Email Can't be Null")]

        public string Email { get; set; }
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password Can't be Null")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = " Can't be Null")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password Mismached")]

        public string ConfirmPassword { get; set; }
    }
}
