using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class GroupStudent
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //foreign
        [Required]
        public int GroupId { get; set; }
        [Required]
        public int StudentId { get; set; }
        //navigation
        public Student? Student { get; set; }
        public Group? Group { get; set; }


    }
}
