using System;

namespace net_core_bootcamp_b1.Models
{
    public class Product // belge adimiz
    {
        public Guid? Id { get; set; } // rastgele string karakterler ile id aldık -> Guid bu ise yarar. ""? sor"
        public bool IsDeleted { get; set; } // bool: true-false yapisi gibi dusun """IsDeleted sor""
        public DateTime? MyProperty { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
    }
}
