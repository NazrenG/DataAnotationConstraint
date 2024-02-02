using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class GroupLecture
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //foreign
        [Required]
        public int GroupId { get; set; }
        [Required]
        public int LectureId { get; set; }

        //navigation
        public Lecture? Lecture { get; set; }    
        public Group? Group { get; set; }
    }
}
