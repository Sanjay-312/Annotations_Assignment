using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsAssignment
{
    public class UserDetails
    {

        [Required(ErrorMessage = "First Name is required")]
        [RegularExpression(@"^[A-Z]{1}[a-zA-Z]{2,}$", ErrorMessage = "First Name must start with an uppercase letter and have a minimum length of 3 characters")]
        public string first_name { get; set; }
    }
}
