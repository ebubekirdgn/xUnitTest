using LibraryManagement.Core.Models;
using LibraryManagement.Core.Repositories;

namespace LibraryManagement.Tests
{
    public class BookRepositoryTests
    {
        private readonly IBookRepository _bookRepository;

        public BookRepositoryTests()
        {
            _bookRepository = new BookRepository();
        }

        [Fact]
        public async Task AddBook_ShouldAddBook()
        {
            var book = new Book { Id = 1, Title = "Test Book", Author = "Author" };

            await _bookRepository.AddAsync(book);

            var books = await _bookRepository.GetAllAsync();
            Assert.Single(books);
            Assert.Equal("Test Book", books.First().Title);
        }

        [Fact]
        public async Task RemoveBook_ShouldRemoveBook()
        {
            var book = new Book { Id = 1, Title = "Test Book", Author = "Author" };
            await _bookRepository.AddAsync(book);

            await _bookRepository.RemoveAsync(1);

            var books = await _bookRepository.GetAllAsync();
            Assert.Empty(books);
        }
    }
}