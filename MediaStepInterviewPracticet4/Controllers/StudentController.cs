using AutoMapper;
using MediaStepInterviewPracticet4.Models;
using Microsoft.AspNetCore.Mvc;
using StudentService.ModelsDto;
using StudentService.Service;

namespace MediaStepInterviewPracticet4.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return View(_mapper.Map<List<StudentViewModel>>(_studentService.GetAll()));
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(List<StudentViewModel> students) 
        {
            await _studentService.AddRangeStudents(_mapper.Map<List<StudentDto>>(students));
            return Ok();
        }
    }
}
