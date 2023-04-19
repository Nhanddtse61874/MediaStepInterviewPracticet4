using StudentService.ModelsDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService.Service
{
    public interface IStudentService
    {
        List<StudentDto> GetAll();

        List<StudentDto> HandleLogic(List<StudentDto> students);

        Task AddRangeStudents(List<StudentDto> students);
    }
}
