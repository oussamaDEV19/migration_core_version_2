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
    

    [Table("gallerie")]
    public partial class gallerie
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Required]
        [StringLength(255)]
        public string path { get; set; }

        [Required]
        [StringLength(255)]
        public string type { get; set; }

        public int id_activite { get; set; }

        public virtual Activite activite { get; set; }
    }
}
