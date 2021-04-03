using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_app.Data.Models;
using test_app.Data.ViewModels;

namespace test_app.Data.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;

        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM book) //book? ili author?
        {
            var _author = new Author()
            {
                FullName = book.FullName //author.FullName??
            };
            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
