using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_CommerceAppMVC.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {

            var kategoriler = new List<Category>()
            {
                new Category(){ Name = "Orginazer", Description = "Orginazer Modelleri"},
                new Category(){ Name = "Lamba", Description = "Lamba Modelleri"},
                new Category(){ Name = "Saksı", Description = "Saksı Modelleri"},
                new Category(){ Name = "Sepet", Description = "Sepet Modelleri"},
                new Category(){ Name = "Tepsi", Description = "Tepsi Modelleri"},
                new Category(){ Name = "Mumluk", Description = "Mumluk Modelleri"},


            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){ Name = "Rattan Organizer Model.1" , Description = "El Yapımı Rattan Orginazer", Price = 300, Stock = 5, IsApproved = true, CategoryId = 1, IsHome = true, Image = "image2.jpeg" },
                new Product(){ Name = "Rattan Orginazer Model.2" , Description = "El Yapımı Rattan Orginazer", Price = 300, Stock = 5, IsApproved = true, CategoryId = 1, Image = "image2.jpeg"},
                new Product(){ Name = "Rattan Orginazer Model.3" , Description = "El Yapımı Rattan Orginazer", Price = 300, Stock = 5, IsApproved = true, CategoryId = 1, Image = "image2.jpeg"},
                new Product(){ Name = "Rattan Orginazer Model.4" , Description = "El Yapımı Rattan Orginazer", Price = 300, Stock = 5, IsApproved = true, CategoryId = 1, Image = "image2.jpeg"},
                new Product(){ Name = "Rattan Orginazer Model.5" , Description = "El Yapımı Rattan Orginazer", Price = 300, Stock = 5, IsApproved = true, CategoryId = 1, Image = "image2.jpeg"},

                new Product(){ Name = "Rattan Lamba " , Description = "El Yapımı Rattan Lamba", Price = 300, Stock = 5, IsApproved = true, CategoryId = 2, IsHome = true, Image = "image1.jpg"},
                new Product(){ Name = "Rattan Saksı " , Description = "El Yapımı Rattan Saksı", Price = 300, Stock = 5, IsApproved = true, CategoryId = 3, IsHome = true, Image = "image3.jpeg"},
                new Product(){ Name = "Rattan Sepet Model.1 " , Description = "El Yapımı Rattan Sepet", Price = 300, Stock = 5, IsApproved = true, CategoryId = 4, Image = "image4.jpg"},
                new Product(){ Name = "Rattan Sepet Model.2 " , Description = "El Yapımı Rattan Sepet", Price = 300, Stock = 5, IsApproved = true, CategoryId = 4, IsHome = true, Image = "image4.jpg"},
                new Product(){ Name = "Rattan Tepsi " , Description = "El Yapımı Rattan Tepsi", Price = 300, Stock = 5, IsApproved = true, CategoryId = 5, IsHome = true, Image = "image5.jpg"},

            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }

    }
}