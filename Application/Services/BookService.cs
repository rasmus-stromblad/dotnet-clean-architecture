using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BookService : IBookService
    { 
        private readonly IBookRepository bookRepository;
        
        public BookService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;   
        }

        List<Domain.Entities.Book> IBookService.GetAll()
        {
            return this.bookRepository.GetAll(); 
        }
    }
}
