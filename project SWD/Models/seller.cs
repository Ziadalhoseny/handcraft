using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{
  
    public class seller
    {
        [Key]

        public int seller_ID { get; set; }

        [Required]
        public string seller_name { get; set; }
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

        public virtual ICollection<product> Products { get; set; }


    }
}
