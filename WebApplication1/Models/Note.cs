using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Date { get; set; } = DateTime.Now;
        public string Summary { get; set; }
    }
}
