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
            Catalog catalog = new Catalog()
            {
                Date = DateTime.Now,
                Books = new Book[]
                {
                    new Book
                    {
                        Author = "DDDD",
                        Description = "dfdfdfdf",
                        Id = "fadsfdsaf",
                        ISBN = "dfdfdf85dfdf64df",
                        Publisher = "dfdfdf",
                        Genre = Genre.Computer,
                        PublishDate = DateTime.Now,
                        RegistrationDate = DateTime.Now


                    },
                    new Book
                    {
                        Author = "DDDD",
                        Description = "dfdfdfdf",
                        Id = "fadsfdsaf",
                        ISBN = "dfdfdf85dfdf64df",
                        Publisher = "dfdfdf",
                        Genre = Genre.Fantasy,
                        PublishDate = DateTime.Now,
                        RegistrationDate = DateTime.Now


                    },
                    new Book
                    {
                        Author = "DDDD",
                        Description = "dfdfdfdf",
                        Id = "fadsfdsaf",
                        ISBN = "dfdfdf85dfdf64df",
                        Publisher = "dfdfdf",
                        Genre = Genre.Romance,
                        PublishDate = DateTime.Now,
                        RegistrationDate = DateTime.Now
                    }
                }
            };



            UploadCatalog uploadCatalog = new UploadCatalog();

            uploadCatalog.Serialize(catalog);
        }
    }
}
