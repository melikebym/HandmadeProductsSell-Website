using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace E_CommerceAppMVC.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image {  get; set; }
        [DisplayName("Stok Durumu")]
        public bool IsApproved { get; set; }
        [DisplayName("Anasayfada Göster")]
        public bool IsHome { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}