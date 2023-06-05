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

namespace LibrarySystem.Web.Controllers
{
    public class BorrowersController : LibrarySystemControllerBase
    {
        private IBorrowerAppService _borrowerappService;
        private IStudentAppService _studentappService;
        private IBookAppService _bookappService;

        public BorrowersController(IBorrowerAppService borrowerappService, IStudentAppService studentAppService, IBookAppService bookAppService)
        {
            _borrowerappService = borrowerappService;
            _studentappService = studentAppService;
            _bookappService = bookAppService;
        }

        public async Task<IActionResult> Index(string SearchBorrower)
        {
            var borrowers = await _borrowerappService.GetAllAsync(new PagedBorrowerResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BorrowersListViewModel();

            if (!string.IsNullOrEmpty(SearchBorrower))
            {
                model = new BorrowersListViewModel()
                {
                    //Borrowers = borrowers.Items.Where(d => d.BookTitle.Contains(SearchBorrower)).ToList()
                    //Borrowers = borrowers.Items.Where(b => b.BookTitle.Contains(SearchBorrower)).ToList()
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


        public async Task<IActionResult> CreateBorrower(int id)
        {
            var model = new CreateOrEditBorrowersViewModel();
            var books = await _bookappService.GetAllAuthorsUnderBooks();
            var students = await _studentappService.GetAllStudents();

            if (id != 0)
            {
                var borrower = await _borrowerappService.GetBorrowerWithBooksAndStudent(new EntityDto<int>(id));
                model = new CreateOrEditBorrowersViewModel()
                {
                    BorrowDate = borrower.BorrowDate,
                    ExpectedReturnDate = borrower.ExpectedReturnDate,
                    ReturnDate = borrower.ReturnDate,
                    BookId = borrower.BookId,
                    StudentId = borrower.StudentId,
                    IsBorrowed = borrower.Book.IsBorrowed,
                    Id = id                   

                };
            }

            model.Books = books;
            model.Students = students;
            return View(model);
        }

    }
}
