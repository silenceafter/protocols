using LibraryService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Services.Interfaces
{
    internal interface ILibraryRepository
    {
        IList<Book> GetByAuthor(string authorName);
        IList<Book> GetByCategory(string category);
        IList<Book> GetByTitle(string title);                
    }
}
