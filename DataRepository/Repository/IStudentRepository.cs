using DataRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetAll();

        Task AddRangeStudent(List<Student> students);
    }
}
