using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace project_SWD.Models
{
    
    public class shopping_order
    {
        [Key]

        public int order_ID { get; set; }
        public int customerID { get; set; }
        public DateTime date { get; set; }

        public virtual ICollection<order_context> order_contexts { get; set; }
        public virtual customer Customer { get; set; }

    }
}
