using System.Collections.Generic;
using Stock.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;


namespace Stock.Model.Entities
{
     [Table("provider")]
    public class Provider : IEntity
    {
        public string Id { get; set; }

        public string Name { get; set; }
        
        public string Phone { get; set; }

        public string Email { get; set; }

        public List<Product> OfferedProducts { get; set; }
    }
}