using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace _12_GeneralStore.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        
        //joining tables
        
        [Required]
        public int ProductId { get; set; }
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }
        
        
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }
        
        //formatting for JSON purposes
        [DataType(DataType.DateTime)]
        public DateTime DateOfTransaction { get; set; }

        public int Quantity { get; set; }
    }
}