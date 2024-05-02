using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracticeProject.Models
{
    public class Category
    {
        [Key]  // these are data anotations, key- for defining primary key
        public int Id { get; set; }

        [Required] // name should not be null
        [DisplayName("Title")]
        public string? Name { get; set; }
        [DisplayName("Priority")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}

