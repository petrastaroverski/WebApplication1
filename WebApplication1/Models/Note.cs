using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Summary { get; set; }
    }
}
