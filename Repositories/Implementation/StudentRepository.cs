using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class StudentRepository(StudentDao studentDao) : IStudentRepository
{
    public StudentDao StudentDao { get; set; } = studentDao;
    
    public async Task<int> Create(Student entity)
    {
        return await StudentDao.AddStudentAsync(entity);
    }

    public async Task<int> Update(int id, Student student)
    {
        return await StudentDao.UpdateStudentAsync(id, student);
    }

    public async Task<int> Delete(int id)
    {
        return await StudentDao.DeleteStudentAsync(id);
    }

    public async Task<IEnumerable<Student>?> GetAll()
    {
        return await StudentDao.GetStudentsAsync();
    }

    public async Task<Student?> GetById(int id)
    {
        return await StudentDao.GetStudentByIdAsync(id);
    }
}