using BusinessObjects.Entities;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class StudentService(IStudentRepository studentRepository) : IStudentService
{
    public IStudentRepository StudentRepository { get; set; } = studentRepository;
    
    public async Task<IEnumerable<Student?>?> GetAllStudentsAsync()
    {
        return await StudentRepository.GetAll();
    }

    public async Task<Student?> GetStudentByIdAsync(int id)
    {
        return await StudentRepository.GetById(id);
    }

    public async Task<int> CreateStudentAsync(Student student)
    {
        return await StudentRepository.Create(student);
    }

    public async Task<int> UpdateStudentAsync(int id, Student student)
    {
        return await StudentRepository.Update(id, student);
    }

    public async Task<int> DeleteStudentAsync(int id)
    {
        return await StudentRepository.Delete(id);
    }
}