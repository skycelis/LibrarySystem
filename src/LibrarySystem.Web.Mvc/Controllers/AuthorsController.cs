<<<<<<< HEAD
=======
﻿using LibrarySystem.Authors;
using LibrarySystem.Books;
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
<<<<<<< HEAD
using LibrarySystem.Authors;
using LibrarySystem.Books;
using LibrarySystem.Authors.Dto;
using LibrarySystem.Web.Models.Authors;
=======
using LibrarySystem.Web.Models.Authors;
using LibrarySystem.Web.Models.Students;
using LibrarySystem.Authors.Dto;
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815

namespace LibrarySystem.Web.Controllers
{
    public class AuthorsController : LibrarySystemControllerBase
    {
        private IAuthorAppService _authorappService;
        private IBookAppService _bookappService;
<<<<<<< HEAD
=======

>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
        public AuthorsController(IAuthorAppService authorappService, IBookAppService bookappService)
        {
            _authorappService = authorappService;
            _bookappService = bookappService;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _authorappService.GetAllAuthorsUnderBooks(new PagedAuthorResultRequestDto { MaxResultCount = int.MaxValue });
<<<<<<< HEAD
            var model = new AuthorViewModel()
=======
            var model = new AuthorViewModel
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
            {
                Authors = authors.Items.ToList()
            };

<<<<<<< HEAD
            return View(model);
        }


        [HttpGet]


        public async Task<IActionResult> CreateAuthor(int id)
        {
            var model = new CreateOrEditAuthorViewModel();
            var books = await _bookappService.GetAllBooks();

            if (id != 0)
            {
                var authors = await _authorappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditAuthorViewModel()
                {
                    Name = authors.Name,
                    BookId = authors.BookId,
=======

            return View(model);
        }

        [HttpGet]


        public async Task<IActionResult> CreateStudent(int id)
        {
            var model = new CreateOrEditAuthorViewModel();
            var books = await _bookappService.GetAllAuthorsUnderBooks();

            if (id != 0)
            {
                var author = await _authorappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditAuthorViewModel()
                {
                    Name = author.Name,
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
                    Id = id

                };
            }

<<<<<<< HEAD
            model.ListBooks = books;
=======
            model.Books = books;
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
            return View(model);
        }

    }
}
