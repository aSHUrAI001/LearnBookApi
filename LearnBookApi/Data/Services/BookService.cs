using LearnBookApi.Data.Models;
using LearnBookApi.Data.ViewModels;

namespace LearnBookApi.Data.Services
{
    public class BookService
    {
        private AppDBContext _dbContext;
        public BookService(AppDBContext context)
        {
            _dbContext = context;
        }

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Title = book.Title,
                Author = book.Author,
                CoverUrl = book.CoverUrl,
                DateRead = book.DateRead,
                Description = book.Description,
                Genre = book.Genre,
                IsRead = book.IsRead,
                Rate = book.Rate,
            };
            _dbContext.Add(_book);
            _dbContext.SaveChanges();
        }

        public List<Book> GetAllBooks() => _dbContext.Books.ToList();

        public Book GetBookById(int bookId)
        {
            return _dbContext.Books.FirstOrDefault(x => x.Id == bookId);
        }

        public Book UpdateBook(int bookId, BookVM book)
        {
            var _book = _dbContext.Books.FirstOrDefault(x => x.Id == bookId);
            if (_book != null)
            {
                _book.Title = book.Title;
                _book.Author = book.Author;
                _book.CoverUrl = book.CoverUrl;
                _book.DateRead = book.DateRead;
                _book.Description = book.Description;
                _book.Genre = book.Genre;
                _book.IsRead = book.IsRead;
                _book.Rate = book.Rate;
                _dbContext.SaveChanges();
            }
            return _book;
        }

        public void DeleteByBookId(int bookId)
        {
            var book = _dbContext.Books.FirstOrDefault(x => x.Id == bookId);
            if (book != null)
            {
                _dbContext.Books.Remove(book);
                _dbContext.SaveChanges();
            }
        }
    }
}
