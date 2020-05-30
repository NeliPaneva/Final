using ShopAsistent.Business;
using ShopAsistent.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopAsistent.Presentation
{
    public class Display
    {
        public Display()
        {
            controller = new ProductController();
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string('-', 13) + "Shop Asistent" + new string('-', 13));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. Извеждане на наличните продукти");
            Console.WriteLine("2. Добавяне на продукт");
            Console.WriteLine("3. Актуализиране");
            Console.WriteLine("4. Изтриване");
            Console.WriteLine("5. Извеждане по Id");
            //Console.WriteLine("6. Извеждане по производител");
            Console.WriteLine("0. Изход");
        }
        private ProductController controller;
        private void Input()
        {
            var command = -1;
            do
            {
                ShowMenu();
                command = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case 1:
                        List();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        Fetch();
                        break;
                    //case 6:
                    //    ManufacturerProducts();
                    //    break;
                    default:
                        break;
                }
            } while (command != 0);
        }

        private void Delete()
        {
            try
            {
                Console.Write("Въведи Id за изтриване: ");
                int id = int.Parse(Console.ReadLine());
                controller.Delete(id);
                Console.WriteLine("Done.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        //private void ManufacturerProducts()
        //{
        //    Console.Write("Производител за търсене: ");
        //    string manufacturer = Console.ReadLine();
        //    var product = this.controller.Get(manufacturer);
        //    if (product != null)
        //    {
        //        Console.WriteLine(new string('-', 40));
        //        Console.WriteLine(new string('-', 16) + "Products" + new string('-', 16));
        //        Console.WriteLine("Product Id " + product.Id);
        //        Console.WriteLine("Product Name " + product.Name);
        //        Console.WriteLine("Product Price " + product.Price);
        //        Console.WriteLine("Product Manufacturer " + product.Manufacturer);
        //        Console.WriteLine("Product Quantity " + product.Quantity);
        //        Console.WriteLine(new string('-', 40));
        //    }
        //}

        private void List()
        {
            throw new NotImplementedException();
        }

        private void Fetch()
        {
            Console.Write("Id за търсене: ");
            int id = int.Parse(Console.ReadLine());
            var product = this.controller.Get(id);
            if (product != null)
            {
                Console.WriteLine(new string('-', 40));
                //Console.WriteLine(new string('-', 16) + "Products" + new string('-', 16));
                Console.WriteLine("Id: " + product.Id);
                Console.WriteLine("Име на продукт:" + product.Name);
                Console.WriteLine("Цена: " + product.Price);
                Console.WriteLine("Производител: " + product.Manufacturer);
                Console.WriteLine("Количество: " + product.Quantity);
                Console.WriteLine(new string('-', 40));
            }
        }

        private void Update()
        {
            Console.Write("Въведи Id за актуализиране: ");
            int id = int.Parse(Console.ReadLine());
            var product = this.controller.Get(id);
            if (product != null)
            {
                Console.WriteLine("Име:");
            }
        }

        private void Add()
        {
            Product product = new Product();
            Console.Write("Име на продукт: ");
            product.Name = Console.ReadLine();
            Console.Write("Цена: ");
            product.Price = decimal.Parse(Console.ReadLine());
            Console.Write("Количество: ");
            product.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Производител: ");
            product.Manufacturer = Console.ReadLine();
            this.controller.Add(product);
        }
    }
}
