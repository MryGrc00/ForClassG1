using ASI.Basecode.Data.Interfaces;
using ASI.Basecode.Data.Models;
using ASI.Basecode.Services.Interfaces;
using ASI.Basecode.Services.ServiceModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(BookViewModel bookViewModel)
        {
            Book book = new()
            {
                Author = bookViewModel.Author,
                Title = bookViewModel.Title,
                Description = bookViewModel.Description,
                CreatedBy = "Mary Grace",
                CreatedDate = System.DateTime.Now,
                UpdatedBy = "Mary Grace",
                UpdatedTime = System.DateTime.Now,
            };

            _bookRepository.AddBook(book);
        }

        public List<Book> GetBooks() 
        {
            var books = _bookRepository.GetBooks();
            return books;
        }
    }
}
