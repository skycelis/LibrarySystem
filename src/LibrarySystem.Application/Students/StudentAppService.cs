﻿using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Students.Dto;
using LibrarySystem.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Borrowers.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Students
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>, IStudentAppService
    {
        private IRepository<Student, int> _repository;
        //private Task<PagedResultDto<StudentDto>> query;
        //private readonly object repository;

        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<StudentDto>> GetAllAsync(PagedStudentResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<StudentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<StudentDto> UpdateAsync(StudentDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Student> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<StudentDto> CreateAsync(CreateStudentDto input)
        { 
            return base.CreateAsync(input);
        }

        public async Task<PagedResultDto<StudentDto>> GetAllStudentsWithDepartment(PagedStudentResultRequestDto input)
        {
            var students = await _repository.GetAll()
                .Include(x => x.Department)
                .OrderByDescending(x => x.Id)
                .Select(x => ObjectMapper.Map<StudentDto>(x))
                .ToListAsync();

            return new PagedResultDto<StudentDto>(students.Count(), students);
        }
        public async Task<List<StudentDto>> GetAllStudents()
        {
            var students = await _repository.GetAll()
                .Select(x => ObjectMapper.Map<StudentDto>(x))
                .ToListAsync();

            return students;
        }
    }
}

