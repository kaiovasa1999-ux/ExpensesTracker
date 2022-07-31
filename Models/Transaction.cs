using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesTrackerMangaer.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        public int CategoryId { get; set; }
        [Required]
        public Category Category { get; set; }

        public int Amount { get; set; } = 0;

        [Column(TypeName = "nvarchar(500)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

    }
}
