namespace Work.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TermsOfPayment{ get; set; }
        public bool IsDelete { get; set; } = false;
    }
}