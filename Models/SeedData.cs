﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Nicholas Applegate, 1-3

namespace OnlineBookstore.Models
{
    public class SeedData
    {
        //Ensure data is provided for database
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            //Add migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //Add starting data
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        NumberOfPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris",
                        AuthorLastName = "Goodwin",
                        AuthorMiddleName = "Kearns",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        NumberOfPages = 944
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crighton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        NumberOfPages = 288
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        NumberOfPages = 400
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        NumberOfPages = 642
                    },

                     new Book
                     {
                         Title = "The Snowball",
                         AuthorFirstName = "Alice",
                         AuthorLastName = "Schroeder",
                         Publisher = "Bantam",
                         ISBN = "978-0553384611",
                         Classification = "Non-Fiction",
                         Category = "Biography",
                         Price = 21.54,
                         NumberOfPages = 832
                     },

                      new Book
                      {
                          Title = "American Ulysses",
                          AuthorFirstName = "Ronald",
                          AuthorLastName = "White",
                          AuthorMiddleName = "C.",
                          Publisher = "Random House",
                          ISBN = "978-0812981254",
                          Classification = "Non-Fiction",
                          Category = "Biography",
                          Price = 11.61,
                          NumberOfPages = 864
                      },

                       new Book
                       {
                           Title = "Unbroken",
                           AuthorFirstName = "Laura",
                           AuthorLastName = "Hillenbrand",
                           Publisher = "Random House",
                           ISBN = "978-0812974492",
                           Classification = "Non-Fiction",
                           Category = "Historical",
                           Price = 13.33,
                           NumberOfPages = 528
                       },

                        new Book
                        {
                            Title = "Deep Work",
                            AuthorFirstName = "Cal",
                            AuthorLastName = "Newport",
                            Publisher = "Grand Central Publishing",
                            ISBN = "978-1455586691",
                            Classification = "Non-Fiction",
                            Category = "Self-Help",
                            Price = 14.99,
                            NumberOfPages = 304
                        },

                         new Book
                         {
                             Title = "It's Your Ship",
                             AuthorFirstName = "Michael",
                             AuthorLastName = "Abrashoff",
                             Publisher = "Grand Central Publishing",
                             ISBN = "978-1455523023",
                             Classification = "Non-Fiction",
                             Category = "Self-Help",
                             Price = 21.66,
                             NumberOfPages = 240
                         },

                         new Book
                         {
                             Title = "Harry Potter and the Chamber of Secrets",
                             AuthorFirstName = "JK",
                             AuthorLastName = "Rowling",
                             Publisher = "Scholastic",
                             ISBN = "978-1455523028",
                             Classification = "Fiction",
                             Category = "Fantasy",
                             Price = 15.00,
                             NumberOfPages = 341
                         },

                         new Book
                         {
                             Title = "Harry Potter and the Prisoner of Azkaban",
                             AuthorFirstName = "JK",
                             AuthorLastName = "Rowling",
                             Publisher = "Scholastic",
                             ISBN = "978-1455523029",
                             Classification = "Fiction",
                             Category = "Fantasy",
                             Price = 15.00,
                             NumberOfPages = 435
                         },

                         new Book
                         {
                             Title = "Harry Potter and the Goblet of Fire",
                             AuthorFirstName = "JK",
                             AuthorLastName = "Rowling",
                             Publisher = "Scholastic",
                             ISBN = "978-1455523027",
                             Classification = "Fiction",
                             Category = "Fantasy",
                             Price = 15.00,
                             NumberOfPages = 734
                         }
                );

                context.SaveChanges();
            }
        }
    }
}
