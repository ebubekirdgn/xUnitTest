using LibraryManagement.Core.Models;

namespace LibraryManagement.Core.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly List<Book> _books = new List<Book>();

        public async Task AddAsync(Book book)
        {
            _books.Add(book);
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(int id)
        {
            var book = _books.FirstOrDefault(b => b.Id == id);
            if (book != null)
                _books.Remove(book);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Book>> GetAllAsync()
        {
            return await Task.FromResult(_books);
        }
    }
}