using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreMigration.Models
{
    [Table("admin")]
    public partial class admin
    {
        [Key]
        public int id_admin { get; set; }

        [Required]
        [StringLength(255)]
        public string username { get; set; }

        [Required]
        [StringLength(255)]
        public string mdp { get; set; }
    }
}
