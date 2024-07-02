using BusinessObjects.Entities;

namespace Services.Interface;

public interface IStudentService
{
    public Task<IEnumerable<Student?>?> GetAllStudentsAsync();
    public Task<Student?> GetStudentByIdAsync(int id);
    public Task<int> CreateStudentAsync(Student student);
    public Task<int> UpdateStudentAsync(int id, Student student);
    public Task<int> DeleteStudentAsync(int id);
}