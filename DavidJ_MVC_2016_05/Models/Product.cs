using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace DavidJ_MVC_2016_05.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ProductText { get; set; }

        
        public int ProductNumber { get; set; }

        public decimal Price { get; set; }

        public bool ProductInStock { get; set; }
        

    }
}