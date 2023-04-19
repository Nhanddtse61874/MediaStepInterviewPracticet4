using AutoMapper;
using DataRepository.Models;
using DataRepository.Repository;
using StudentService.ModelsDto;

namespace StudentService.Service
{
    public class StudentsService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentsService(IStudentRepository studentRepository, IMapper mappr)
        {
            _studentRepository= studentRepository;
            _mapper= mappr;
        }

        public List<StudentDto> GetAll()
        {
            var students = _studentRepository.GetAll();
            var handledStudent = HandleLogic(_mapper.Map<List<StudentDto>>(students));
            return _mapper.Map<List<StudentDto>>(handledStudent);
        }

        public List<StudentDto> HandleLogic(List<StudentDto> students)
        {
            // xu li sort pla pla 
            return students;
        }

        public async Task AddRangeStudents(List<StudentDto> students)
        {
            await _studentRepository.AddRangeStudent(_mapper.Map<List<Student>>(students));
        }
    }
}
