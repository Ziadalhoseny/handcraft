using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{
  
    public class payment
    {
        [Key]

        public int payment_ID { get; set; }
        public int customer_ID2 { get; set; }
        public string payment_type { get; set; }
        public DateTime date { get; set; }


        public virtual ICollection<order_context> Order_Contexts { get; set; }
        public virtual customer Customer { get; set; }



    }
}
