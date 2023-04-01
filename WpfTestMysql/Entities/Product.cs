using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WpfTestMysql.Entities
{
    [Table("tbl_products")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Required]
        [Column("description")]
        [StringLength(4000)]
        public string Description { get; set; }

        [Column("category_id")]
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public virtual List<ProductImage> ProductImages { get; set; }
    }
}
