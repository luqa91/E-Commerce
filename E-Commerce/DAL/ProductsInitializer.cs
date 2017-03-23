using E_Commerce.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce.DAL
{
    public class ProductsInitializer: DropCreateDatabaseAlways<ProductsContext>
    {
        protected override void Seed(ProductsContext context)
        {
            SeedProductsData(context);
            base.Seed(context);
        }

        private void SeedProductsData(ProductsContext context)
        {
            var category = new List<Category>
            {
                new Category() { CategoryId=1, NameCategory="Electronics", NameFileIcon="Electronics.png", DescriptionCategory="Opis electronics" },
                new Category() { CategoryId=2, NameCategory="Technologies", NameFileIcon="Technologies.png", DescriptionCategory="Opis technologies" },
                new Category() { CategoryId=3, NameCategory="Home", NameFileIcon="Home.png", DescriptionCategory="Opis home" }
            };
            category.ForEach(k=> context.Categories.Add(k));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product() { Company="Apple",Title="IPhone", CategoryId=1,PriceProduct=2999,Bestseller=true,NameFileImage="IPhone.png",DateAdded=DateTime.Now,Description="description iphone product" },


            };
            products.ForEach(k => context.Products.Add(k));
            context.SaveChanges();



        }
    }
}