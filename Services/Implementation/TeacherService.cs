using BusinessObjects.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class TeacherService(ITeacherRepository teacherRepository) : ITeacherService
{
    public ITeacherRepository TeacherRepository { get; set; } = teacherRepository;
    public async Task<IEnumerable<Teacher?>?> GetAllTeachersAsync()
    {
        return await TeacherRepository.GetAll();
    }

    public async Task<Teacher?> GetTeacherByIdAsync(int id)
    {
        return await TeacherRepository.GetById(id);
    }

    public async Task<int> CreateTeacherAsync(Teacher teacher)
    {
        return await TeacherRepository.Create(teacher);
    }

    public async Task<int> UpdateTeacherAsync(int id, Teacher teacher)
    {
        return await TeacherRepository.Update(id, teacher);
    }

    public async Task<int> DeleteTeacherAsync(int id)
    {
        return await TeacherRepository.Delete(id);
    }
}