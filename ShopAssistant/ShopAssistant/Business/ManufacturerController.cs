using ShopAssistant.Data;
using ShopAssistant.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssistant.Business
{
    class ManufacturerController
    {
        private ShopContext context;
        public ManufacturerController()
        {
            this.context = new ShopContext();
        }
        public List<Manufacturer> GetAll()
        {
            return context.Manufacturers.ToList();
        }
        public Manufacturer Get(int id)
        {
            var manu = this.context.Manufacturers.FirstOrDefault(x => x.Id == id);
            return manu;
        }
        public List<Manufacturer> GetManufacturer(string manufacturer)
        {
            List<Manufacturer> manu = new List<Manufacturer>();
            foreach (var item in context.Manufacturers.ToList())
            {
                if (item.Name == manufacturer)

                    manu.Add(item);
            }

            return manu;
        }
        public void Add(Manufacturer m)
        {
            this.context.Manufacturers.Add(m);
            this.context.SaveChanges();
        }
        public void Update(Manufacturer m)
        {
            var manufacturerItem = this.Get(m.Id);
            this.context.Entry(manufacturerItem).CurrentValues.SetValues(m);
            this.context.SaveChanges();
        }
        public void Delete(int id)
        {
            var manufacturerItem = this.Get(id);
            this.context.Manufacturers.Remove(manufacturerItem);
            this.context.SaveChanges();
        }

    }
}
