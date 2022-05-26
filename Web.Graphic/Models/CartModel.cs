namespace Web.Graphic.Models
{
    public class CartModel
    {
        public int Idcart { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
