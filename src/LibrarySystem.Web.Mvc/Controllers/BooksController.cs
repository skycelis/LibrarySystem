using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.BookCategories;
using LibrarySystem.Books;
using LibrarySystem.Web.Models.Books;
using System.Collections.Generic;
using LibrarySystem.Books.Dto;

namespace LibrarySystem.Web.Controllers
{
    public class BooksController : LibrarySystemControllerBase
    {
        private IBookAppService _bookappService;
        private IBookCategoryAppService _bookcategoryappService;
        private object await_bookcategoryAppService;

        public BooksController(IBookAppService bookappService, IBookCategoryAppService bookcategoryappService)
        {
            _bookappService = bookappService;
            _bookcategoryappService = bookcategoryappService;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _bookappService.GetAllBooksWithCategories(new PagedBookResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BookListViewModel()
            {
                Books = books.Items.ToList()
            };

            return View(model);
        }


        [HttpGet]


        public async Task<IActionResult> CreateBook(int id)
        {
            var model = new CreateOrEditBookViewModel();
            var bookcategories = new List<BookCategoryDto>();

            if (id != 0)
            {
                var book = await _bookappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBookViewModel()
                {
                    BookTitle = book.BookTitle,
                    BookPublisher = book.BookPublisher,
                    BookAuthor = book.BookAuthor,
                    IsBorrowed = book.IsBorrowed,               
                    Id = id,
                    BookCategoryId = book.BookCategoryId

                };
            }

            model.ListBookCategories = bookcategories;
            return View(model);
        }

    }
}
