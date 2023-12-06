using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{
   
    public class order_context
    {
        [Key]
        [Required]
        public int delivery_ID { get; set; }

        public int order_ID1 { get; set; }
        public int customer_ID1 { get; set; }
        public int product_ID1 { get; set; }
        public DateTime date { get; set; }


        public virtual ICollection<payment> Payments { get; set; }
        public virtual product Product { get; set; }
        public virtual shopping_order Shopping_Order { get; set; }


    }
}
