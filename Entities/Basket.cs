using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using OrderFullfillment.SeedWorks;

namespace OrderFullfillment.Entities
{
    [Table("Basket")]
    public class Basket : EntityBase<int>
    {
        public bool IsResolved { get; set; }
        public virtual ICollection<BasketProductItem> Products { get; set; }
    }
}