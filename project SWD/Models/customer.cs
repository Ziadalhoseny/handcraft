using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{
   
    public class customer
    {
        [Key]

        public int customer_ID { get; set; }
        [Required]
        public string customer_name { get; set; }
        [Required]
        public int contact { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Not match")]
        public string ConfirmPassword { get; set; }

        public virtual ICollection<shopping_order> Shopping_Orders { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual ICollection<payment> Payments { get; set; }


    }
}
