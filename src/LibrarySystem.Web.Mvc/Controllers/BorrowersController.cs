using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.Books;
using System.Collections.Generic;
using LibrarySystem.Borrowers;
using LibrarySystem.Borrowers.Dto;
using LibrarySystem.Students.Dto;
using LibrarySystem.Students;
using LibrarySystem.Web.Models.Borrowers;

namespace LibrarySystem.Web.Controllers
{
    public class BorrowersController : LibrarySystemControllerBase
    {
        private IBorrowerAppService _borrowerappService;
        private readonly object borrowers;
       
        public BorrowersController(IBorrowerAppService borrowerappService)
        {
            _borrowerappService = borrowerappService;
        }

        public async Task<IActionResult> Index()
        {
            var borrowers = await _borrowerappService.GetAllAsync(new PagedBorrowerResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BorrowersListViewModel()
            {
                Borrowers = borrowers.Items.ToList()
            };

            return View(model);
        }


        [HttpGet]


        public async Task<IActionResult> CreateBorrower(int id)
        {
            var model = new CreateOrEditBorrowersViewModel();
            var books = new List<BookDto>();
            var students = new List<StudentDto>();

            if (id != 0)
            {
                var borrower = await _borrowerappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBorrowersViewModel()
                {
                    BorrowDate = borrower.BorrowDate,
                    ExpectedReturnDate = (int)borrower.ExpectedReturnDate,
                    ReturnDate = (int)borrower.ReturnDate,
                    BookId = (int)borrower.BookId,
                    StudentId = borrower.StudentId,
                    Id = id

                };
            }

            //model.ListBooks = books;
            //model.ListStudents = students;
            return View(model);
        }

    }
}
