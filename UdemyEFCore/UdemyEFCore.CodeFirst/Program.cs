using System.Drawing;
using System.Linq;
using System.Numerics;
using AutoMapper.QueryableExtensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using UdemyEFCore.CodeFirst;
using UdemyEFCore.CodeFirst.DAL;
using UdemyEFCore.CodeFirst.DTOs;
using UdemyEFCore.CodeFirst.Mappers;


Initializer.Build();


using (var _context = new AppDbContext())
{
    using (var transaction = _context.Database.BeginTransaction(System.Data.IsolationLevel.RepeatableRead))
    {
        var product = _context.Products.Take(2).ToList();
        //product.Price = 20000;

        //_context.SaveChanges();

        transaction.Commit();
    }







    //var category = new Category() { Name = "Kılıflar" };

    //_context.Categories.Add(category);

    //_context.SaveChanges();

    //Product product = new Product
    //{
    //    Name = "kılıf 1",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    DiscountedPrice=102,
    //    CategoryId = category.Id
    //};

    //_context.Products.Add(product);

    //_context.SaveChanges();

    Console.WriteLine("işlem bitti");



































    //var category = new Category() { Name = "kalemler" };

    //category.Products.Add(new Product
    //{
    //    Name = "kalem1",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature { Color = "green", Height = 400, Width = 200 }
    //});

    //category.Products.Add(new Product
    //{
    //    Name = "kalem2",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature { Color = "green", Height = 400, Width = 200 }
    //});

    //category.Products.Add(new Product
    //{
    //    Name = "kalem3",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature { Color = "green", Height = 400, Width = 200 }
    //});

    //category.Products.Add(new Product
    //{
    //    Name = "kalem4",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature { Color = "green", Height = 400, Width = 200 }
    //});

    //_context.Categories.Add(category);



    //var category = new Category() { Name = "defterler" };

    //category.Products.Add(new()
    //{
    //    Name = "defter1",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature() { Color = "green", Height = 400, Width = 200 }
    //});

    //category.Products.Add(new()
    //{
    //    Name = "defter2",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature() { Color = "green", Height = 400, Width = 200 }
    //});
    //category.Products.Add(new()
    //{
    //    Name = "defter3",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature() { Color = "green", Height = 400, Width = 200 }
    //});

    //category.Products.Add(new()
    //{
    //    Name = "defter4",
    //    Price = 100,
    //    Stock = 400,
    //    Barcode = 789,
    //    ProductFeature = new ProductFeature() { Color = "green", Height = 400, Width = 200 }
    //});
    //_context.Categories.Add(category);

    
}







    


