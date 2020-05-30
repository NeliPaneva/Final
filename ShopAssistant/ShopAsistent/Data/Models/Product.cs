using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopAsistent.Data.Models
{
    public class Product
    {
        //public Product()
        //{

        //}

        //public Product(string name, string manufacturer, decimal price, int quantity)
        //{
        //    this.Name = name;
        //    this.Manufacturer = manufacturer;
        //    this.Price = price;
        //    this.Quantity = quantity;
        //}

        public int Id { get; set; }
        [Required]//zadaljitelen
        [MaxLength(20)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        
       
        public string Manufacturer {get; set; }
           
        

    }
}
