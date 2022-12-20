using LibraryService.Models;
using LibraryService.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryService.Services
{
    public class LibraryDatabaseContext : ILibraryDatabaseContext
    {
        private IList<Book> _libraryDatabase;
        public IList<Book> Books => _libraryDatabase;

        public LibraryDatabaseContext()
        {
            Initialize();
        }

        private void Initialize()
        {
            _libraryDatabase = (List<Book>)JsonConvert.DeserializeObject(Encoding.UTF8.GetString(Properties.Resources.books), typeof(List<Book>));
        }
    }
}
