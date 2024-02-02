using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class GroupCurator
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //foreign key
        [Required]
        public int GroupId { get; set; }
        [Required]
        public int CuratorId { get; set; }

        //navigation
        public Group? Group { get; set; }
        public Curator? Curator { get; set; }
    }
}
