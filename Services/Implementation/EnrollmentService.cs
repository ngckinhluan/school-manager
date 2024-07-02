using BusinessObjects.Entities;
using Services.Interface;

namespace Services.Implementation;

public class EnrollmentService : IEnrollmentService
{
    public Task<IEnumerable<Enrollment>> GetAllEnrollmentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Enrollment?> GetEnrollmentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Enrollment>> GetEnrollmentsByStudentIdAsync(int studentId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Enrollment>> GetEnrollmentsByClassIdAsync(int classId)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddEnrollmentAsync(Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateEnrollmentAsync(int id, Enrollment enrollment)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteEnrollmentAsync(int id)
    {
        throw new NotImplementedException();
    }
}