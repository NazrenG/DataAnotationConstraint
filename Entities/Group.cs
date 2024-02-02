using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Group
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,DefaultValue("none")]
        [Column(TypeName ="nvarchar(10)")]
        public string? Name { get; set; }

        [Required,Range(minimum:1,maximum:5)]
        public int Year { get; set; }


        //foreign key
        [Required]
        public int DepartmentId { get; set; }

        //navigation
        public Department? Department { get; set; }
        public ICollection<GroupCurator>? groupCurators { get; set; }
        public ICollection<GroupStudent>? GroupStudents { get; set; }
        public ICollection<GroupLecture>? GroupLectures { get; set; }   
    }
}
