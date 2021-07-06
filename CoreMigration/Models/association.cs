using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMigration.Models
{
    [Table("association")]
    public partial class association
    {
        public int id { get; set; }
    }
}
