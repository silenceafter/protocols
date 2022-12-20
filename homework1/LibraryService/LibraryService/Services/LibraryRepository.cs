using LibraryService.Models;
using LibraryService.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Services
{
    public class LibraryRepository : ILibraryRepository
    {       
        private readonly ILibraryDatabaseContext _context;
        
        public LibraryRepository(ILibraryDatabaseContext context)
        {
            _context = context;
        }

        public IList<Book> GetByAuthor(string authorName)
        {
            try
            {
                return _context.Books.Where(book => book.Authors.Where(author => author.Name.ToLower().Contains(authorName.ToLower())).Count() > 0).ToList();
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }
        }

        public IList<Book> GetByCategory(string category)
        {
            try
            {
                return _context.Books.Where(book => book.Category.ToLower().Contains(category.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }
        }
        
        public IList<Book> GetByTitle(string title)
        {
            try
            {
                return _context.Books.Where(book => book.Title.ToLower().Contains(title.ToLower())).ToList();
            }
            catch (Exception ex)
            {
                return new List<Book>();
            }
        }
    }
}
