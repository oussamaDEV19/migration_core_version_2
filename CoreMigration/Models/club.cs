using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMigration.Models
{

    [Table("club")]
    public partial class club
    {
        public int id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string titre { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_creation { get; set; }

        [Required]
        [StringLength(255)]
        public string logo { get; set; }

        public int id_respo { get; set; }

        public virtual Responsable Responsable { get; set; }
    }
}
