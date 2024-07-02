using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class EnrollmentRepository(EnrollmentDao enrollmentDao) : IEnrollmentRepository
{
    public EnrollmentDao EnrollmentDao { get; set; } = enrollmentDao;
    public async Task<int> Create(Enrollment enrollment)
    {
        return await EnrollmentDao.AddEnrollmentAsync(enrollment);
    }

    public async Task<int> Update(int id, Enrollment enrollment)
    {
        return await EnrollmentDao.UpdateEnrollmentAsync(id, enrollment);
    }

    public async Task<int> Delete(int id)
    {
        return await EnrollmentDao.DeleteEnrollmentAsync(id);
    }

    public async Task<IEnumerable<Enrollment>?> GetAll()
    {
        return await EnrollmentDao.GetEnrollmentsAsync();
    }

    public async Task<Enrollment?> GetById(int id)
    {
        return await EnrollmentDao.GetEnrollmentByIdAsync(id);
    }

    public async Task<IEnumerable<Enrollment>> GetByStudentId(int studentId)
    {
        return await EnrollmentDao.GetByStudentId(studentId);
    }
    public async Task<IEnumerable<Enrollment>> GetByClassId(int classId)
    {
        return await EnrollmentDao.GetByClassId(classId);
    }
}