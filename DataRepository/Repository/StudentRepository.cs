using DataRepository.Context;
using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _studentContext;
        public StudentRepository(StudentContext studentContext)
        {
            _studentContext= studentContext;
        }

        public List<Student> GetAll()
        => _studentContext.Student.ToList();

        public async Task AddRangeStudent(List<Student> students)
        {
            await _studentContext.Student.AddRangeAsync(students);
        }
    }
}
