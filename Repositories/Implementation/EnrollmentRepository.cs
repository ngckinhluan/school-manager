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
}