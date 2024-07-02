using BusinessObjects.Entities;

namespace Services.Interface;

public interface ITeacherService
{
    public Task<IEnumerable<Teacher?>?> GetAllTeachersAsync();
    public Task<Teacher?> GetTeacherByIdAsync(int id);
    public Task<int> CreateTeacherAsync(Teacher teacher);
    public Task<int> UpdateTeacherAsync(int id, Teacher teacher);
    public Task<int> DeleteTeacherAsync(int id);
}