
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Teacher
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "bit")]
        [Required,DefaultValue(0)]
        public bool IsProfessor { get; set; }

        [Required,DefaultValue("none")]
        public string? Name { get; set; }

        [Column("Salary",TypeName ="money")]
        [Required, Range(minimum: 1, maximum: float.MaxValue)]
        public float? Price { get; set; }

        [Required, DefaultValue("none")]
        public string? Surname { get; set; }

        public ICollection<Lecture>? Lectures { get; set; }
    }
}
