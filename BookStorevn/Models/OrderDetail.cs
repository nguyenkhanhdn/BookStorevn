namespace BookStorevn.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int StationeryId { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public OrderMaster OrderMaster { get; set; }
        public Stationery Stationery { get; set; }
    } 
}
