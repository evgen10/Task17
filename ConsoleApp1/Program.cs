using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSerialization.Models;
using BasicSerialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {  
            CatalogSerializer uploadCatalog = new CatalogSerializer();

            Console.WriteLine(@"Deserialize from 'books.xml'...");
            Console.WriteLine();
            Catalog catalog = uploadCatalog.Deserialize();

            ShowCatalog(catalog);

            Console.WriteLine();
            Console.WriteLine(@"Serialize to 'books.xml'...");
            uploadCatalog.Serialize(catalog);

            Console.Read();
        }

        private static void ShowCatalog(Catalog catalog)
        {
            Console.WriteLine($"Date: {catalog.Date}");

            foreach (var book in catalog.Books)
            {
                Console.WriteLine($"BookId:           {book.Id}");
                Console.WriteLine($"ISBN:             {book.ISBN}");
                Console.WriteLine($"Author:           {book.Author}");
                Console.WriteLine($"Title:            {book.Title}");
                Console.WriteLine($"Genre:            {book.Genre}");
                Console.WriteLine($"Publisher:        {book.Publisher}");
                Console.WriteLine($"PublishDate:      {book.PublishDate}");
                Console.WriteLine($"Description:      {book.Description}");
                Console.WriteLine($"RegistrationDate: {book.RegistrationDate}");
            }
        }
    }
}
