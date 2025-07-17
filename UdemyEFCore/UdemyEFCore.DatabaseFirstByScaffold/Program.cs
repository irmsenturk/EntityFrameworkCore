
using Microsoft.EntityFrameworkCore;
using UdemyEFCore.DatabaseFirstByScaffold.Models;



using (var context = new UdemyEfcoreDatabaseFirstDbContext())
{
   var products = await context.Products.ToListAsync();    
    products.ForEach(p =>
    {
        Console.WriteLine($"Product ID: {p.Id}, Name: {p.Name}, Price: {p.Price}, Stock: {p.Stock}");
    });
}   