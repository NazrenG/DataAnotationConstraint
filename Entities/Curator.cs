using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Academy.Entities
{
    public class Curator
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//auto increment
        [Required,Key]//not null ,primary key
        public int Id { get; set; }

        [Column("Name")]
        [Required,DefaultValue("none")]//not null ,cant empty
        public string? FirstName { get; set; }

        [Column("Surname")]
        [Required, DefaultValue("none")]//not null ,cant empty
        public string? LastName { get; set; }

        //navigation
        public ICollection<GroupCurator>? groupCurators { get; set; }

    }
}
