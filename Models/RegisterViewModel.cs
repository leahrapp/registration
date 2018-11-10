using System.Web.Mvc;
using  System.ComponentModel.DataAnnotations;

namespace registration.Models
{
    public class RegisterViewModel
    {
        [Required]
       [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


    }
}