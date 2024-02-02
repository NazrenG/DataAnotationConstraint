using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Entities
{
    public class Faculty
    {
        [Required, Key]//not null,primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,DefaultValue("none")]
        [Column(TypeName ="nvarchar(100)")]
        public string? Name { get; set; }

        //navigation property
        public ICollection<Department>? Departments { get; set; }
    }
}
