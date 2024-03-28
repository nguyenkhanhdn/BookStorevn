namespace BookStorevn.Models
{
    public class Stationery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
