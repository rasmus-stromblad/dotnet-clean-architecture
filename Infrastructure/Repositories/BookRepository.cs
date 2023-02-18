using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;

namespace Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        public static List<Domain.Entities.Book> books = new List<Domain.Entities.Book>
        {
            new Domain.Entities.Book { Id = 1, Name = "The Saturnian", Author = "Bob Bobson", Rating = 4 },
            new Domain.Entities.Book { Id = 2, Name = "No Jobs : A biography", Author = "Steven Stevenson", Rating = 5 },
            new Domain.Entities.Book { Id = 3, Name = "Larry Kotter", Author = "Aron Busk", Rating = 2 }
        };

        public List<Domain.Entities.Book> GetAll()
        {
            return books;
        }
    }
}
