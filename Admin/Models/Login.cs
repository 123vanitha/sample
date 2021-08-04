using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class Login
    {
        [Key]
        [Display(Name ="Id")]
        public int Id { get; set; }
       [Required(ErrorMessage ="Enter UserName")]
        public string UserName { get; set; }
        [Display(Name ="Password")]
        public string Password { get; set; }
    }
}
