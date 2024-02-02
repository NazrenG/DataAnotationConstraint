using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Student
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,DefaultValue("none")]
        public string? Name { get; set; }

        [Required,Range(minimum:0,maximum:5)]
        public int Rating { get; set; }

        [Required, DefaultValue("none")]
        public string? Surname { get; set; }

        //navigation 
        public ICollection<GroupStudent>? GroupStudents { get; set; }

    }
}
