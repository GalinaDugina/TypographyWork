namespace Work.Models
{
    public class Paper
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public int Density { get; set; }
        public decimal PriceKZT { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}