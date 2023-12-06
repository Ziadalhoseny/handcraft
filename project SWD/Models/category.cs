using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{

    public class category
    {
        [Key]
        public int category_ID { get; set; }

        [Required(ErrorMessage = "The name of categeory is required")]
        public string category_name { get; set; }

        [Required(ErrorMessage = "The type of categeory is required")]
        public string category_type { get; set; }

        [Display(Name = "Image")]
        [DefaultValue("default.png")]
        public string department_Pic { get; set; }


        public virtual ICollection<product> Products { get; set; }

    }
}
