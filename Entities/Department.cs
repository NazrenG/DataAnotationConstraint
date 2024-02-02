using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Department
    {
        [Required,Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]//not null
        [Range (minimum:1,maximum:5)]//check constraint
        public int Building { get; set; }

        [Column(TypeName ="money")]
        [Required,Range(minimum:0,maximum: float.MaxValue)]//not null,range
        [DefaultValue(0)]
        public float Financing { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        [Required,DefaultValue("none")]
        public string? Name { get; set; }

        //foreign key
        [Required]
        public int FacultyId { get; set; }
        //navigation property
        public Faculty? Faculty { get; set; }
        public ICollection<Group>? Groups { get; set; }

    }
}
