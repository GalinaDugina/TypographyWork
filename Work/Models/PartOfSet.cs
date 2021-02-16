namespace Work.Models
{
    public enum NameOfPart
    {
        этикет,
        колье,
        контрэтикет
    }
    public class PartOfSet
    {
        public int Id { get; set; }
        public NameOfPart Name { get; set; } = NameOfPart.этикет;
        public int PaperId { get; set; }    
        public Paper Paper{ get; set; }
        public int ProductId { get; set; }//внешний ключ на Продукцию, частью которой является
        public Product Product{ get; set; }
        public int Colorfulness { get; set; }//сколько красок используется при печати
        public bool CutOut { get; set; }
        public bool Together{ get; set; }
        public int PiecesPerSheet { get; set; }
        public string Comment{ get; set; }
        public bool IsDelete { get; set; } = false;
    }
}