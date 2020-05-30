using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAsistent.Data.Models
{
    public class Manufacturer
    {
        
        public int Id { get; set; }
        public string Name
        {
            get;
            set;
            
        }
       

        public string City
        {
            get;   set;       
        }

       
        public double YearsSinceOpening
        {
            get; set;
           
        }

        ////public Manufacturer(string city, string name, double yearsSinceOpening)
        ////{
        ////    this.City = city;
        ////    this.Name = name;
        ////    this.YearsSinceOpening = yearsSinceOpening;
        ////}
        ////public Manufacturer()
        ////{
        ////}
    }
}
