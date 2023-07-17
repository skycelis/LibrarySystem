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
using LibrarySystem.Authors;
using LibrarySystem.Authors.Dto;

namespace LibrarySystem.Web.Controllers
{
    public class BooksController : LibrarySystemControllerBase
    {
        private IBookAppService _bookappService;
        private IBookCategoryAppService _bookcategoryappService;
        private IAuthorAppService _authorappService;

        public BooksController(IBookAppService bookappService, IBookCategoryAppService bookcategoryappService, IAuthorAppService authorAppService)
        {
            _bookappService = bookappService;
            _bookcategoryappService = bookcategoryappService;
            _authorappService = authorAppService;
        }

        public async Task<IActionResult> Index(string SearchBook)
        {
            var books = await _bookappService.GetAllBooksWithCategoriesAndAuthor(new PagedBookResultRequestDto { MaxResultCount = int.MaxValue, Keyword = SearchBook });

            var model = new BookListViewModel()
            {
                Books = books.Items.ToList(),
            };

            
            //if (!string.IsNullOrEmpty(SearchBook))
            //{
            //    model = new BookListViewModel()
            //    {
            //        Books = books.Items.Where(b => b.BookTitle.Contains(SearchBook)).ToList()
            //    };
            //}
            //else
            //{
            //    model = new BookListViewModel()
            //    {
            //        Books = books.Items.ToList()
            //    };
            //}

            return View(model);
        }

        [HttpGet]


        public async Task<IActionResult> CreateBook(int id)
        {
            var model = new CreateOrEditBookViewModel();
            var bookcategories = await _bookcategoryappService.GetAllBookCategories();
            var authors = await _authorappService.GetAllAsync(new PagedAuthorResultRequestDto { MaxResultCount = int.MaxValue });

            if (id != 0)
            {
                var book = await _bookappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBookViewModel()
                {
                    BookTitle = book.BookTitle,
                    BookPublisher = book.BookPublisher,
                    IsBorrowed = book.IsBorrowed,               
                    Id = id,
                    BookCategoryId = book.BookCategoryId,
                    AuthorId = book.AuthorId

                };
            }

            model.ListBookCategories = bookcategories;
            model.ListAuthors = authors.Items.ToList();
            return View(model);
        }

    }
}
