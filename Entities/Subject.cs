using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Subject
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,DefaultValue("none")]
        [Column(TypeName ="nvarchar(100)")]
        public string? Name { get; set; }

        public ICollection<Lecture>? Lecture { get; set; }
    }
}
