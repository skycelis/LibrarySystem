using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.Books;
using LibrarySystem.Borrowers;
using LibrarySystem.Borrowers.Dto;
using LibrarySystem.Web.Models.Borrowers;
using LibrarySystem.Students;
using LibrarySystem.Web.Models.Books;
using LibrarySystem.Web.Models.Students;
using System.Collections.Generic;
using LibrarySystem.Students.Dto;

namespace LibrarySystem.Web.Controllers
{
    public class BorrowersController : LibrarySystemControllerBase
    {
        private IBorrowerAppService _borrowerappService;
        private IStudentAppService _studentappService;
        private IBookAppService _bookappService;

        public BorrowersController(IBorrowerAppService borrowerappService, IStudentAppService studentAppService, IBookAppService bookappService)
        {
            _borrowerappService = borrowerappService;
            _studentappService = studentAppService;
            _bookappService = bookappService;
        }

        public async Task<IActionResult> Index(string SearchBorrower)
        {
            var borrowers = await _borrowerappService.GetBorrowerWithBooksAndStudent(new PagedBorrowerResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BorrowersListViewModel();

            if (!string.IsNullOrEmpty(SearchBorrower))
            {
                model = new BorrowersListViewModel()
                {
                    Borrowers = borrowers.Items.Where(b => b.Book.BookTitle.Contains(SearchBorrower) || b.Student.StudentName.Contains(SearchBorrower)).ToList()
                };
            }
            else
            {
                model = new BorrowersListViewModel()
                {
                    Borrowers = borrowers.Items.ToList()
                };
            }

            return View(model);
        }

        [HttpGet]


        public async Task<IActionResult> CreateOrEditBorrower(int id)
        {
            var model = new CreateOrEditBorrowersViewModel();
            var books = await _bookappService.GetAllAuthorsUnderBooks();
            var students = await _studentappService.GetAllStudents();


            model.Books = books;
            model.Students = students;
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> EditBorrower(int id)
        {
            var model = new CreateOrEditBorrowersViewModel();
            var books = await _bookappService.GetAllBooks();
            var students = await _studentappService.GetAllStudents();

            if (id != 0)
            {
                var borrower = await _borrowerappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBorrowersViewModel()
                {
                    BorrowDate = borrower.BorrowDate,
                    ExpectedReturnDate = borrower.ExpectedReturnDate,
                    ReturnDate = borrower.ReturnDate,
                    BookId = borrower.BookId,
                    StudentId = borrower.StudentId,
                    Id = id

                };
            }
            else
            {
                books = await _bookappService.GetAllBooks();
                students = await _studentappService.GetAllStudents();
            }

            model.Books = books;
            model.Students = students;
            return View(model);
        }
    }
}
