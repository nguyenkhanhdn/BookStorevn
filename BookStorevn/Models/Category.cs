using System.Reflection.Emit;

namespace BookStorevn.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string CategoryName{ get; set; }
        public string Description { get; set; }
        public string Img { get; set; }

        public ICollection<Stationery> Stationeries { get; set; }
    }
}
