using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Lecture
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName ="date"),Required]
        [Range(typeof(DateTime),"01-01-2000","02-02-2024")]
        public DateTime Date { get; set; }

        //foreign key
        [Required]
        public int SubjectId { get; set; }

        [Required]
        public int TeacherId { get; set; }
        //navigation
        public Subject? Subject { get; set; }
        public Teacher? Teacher { get; set; }
        public ICollection<GroupLecture>? GroupLectures { get; set; }
    }
}
