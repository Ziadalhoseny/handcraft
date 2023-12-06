using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{

    public class product
    {
        [Key]

        public int product_ID { get; set; }

        [Required(ErrorMessage = "The price of product is required")]
        public int product_price { get; set; }

        [Required(ErrorMessage = "The name of product is required")]
        public string product_name { get; set; }

        [Required]
        public string product_description { get; set; }

        [DefaultValue("Fci.jpg")]
        public string img { get; set;}
       
        

        public int categoryID { get; set; }
        public int sellerID { get; set; }


        public virtual ICollection<order_context> order_contexts { get; set; }
        public virtual ICollection<comment> comments { get; set; }


        public virtual category Category { get; set; }
        public virtual seller seller { get; set; }



    }
}
