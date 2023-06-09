﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Documents;

namespace WpfTestMysql.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Column("image")]
        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        [Column("description")]
        [StringLength(4000)]
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; } 
    }
}
