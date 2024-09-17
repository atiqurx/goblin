using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace goblin.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Amount { get; set; } = "";

        [Column(TypeName = "nvarchar(75)")]
        public string Note { get; set; } = "";

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
