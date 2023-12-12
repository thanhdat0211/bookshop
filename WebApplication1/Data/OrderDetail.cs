using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    [Table("OrderDetails")]

    public partial class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int? OrderId { get; set; }
        public int? Id { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order? Order { get; set; }
        [ForeignKey("Id")]
        public virtual Product? Product { get; set; }

    }
}
