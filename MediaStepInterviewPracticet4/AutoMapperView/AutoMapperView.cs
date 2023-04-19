using MediaStepInterviewPracticet4.Models;
using StudentService.ModelsDto;

namespace MediaStepInterviewPracticet4.AutoMapperView
{
    public class AutoMapperView : StudentService.AutoMapper.AutoMapper
    {
        public AutoMapperView()
        {
            CreateMap<StudentDto, StudentViewModel>().ReverseMap(); 
        }
    }
}
