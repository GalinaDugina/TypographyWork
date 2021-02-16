using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Work.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelete { get; set; } = false;
        public Client Client{ get; set; }
        public int ClientId { get; set; }
        [NotMapped]
        public List<PartOfSet> PartOfSets{ get; set; }
    }
}