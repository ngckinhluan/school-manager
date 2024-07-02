using BusinessObjects.Entities;

namespace Services.Interface;

public interface IEnrollmentService
{
    public Task<IEnumerable<Enrollment?>?> GetAllEnrollmentsAsync();
    public Task<Enrollment?> GetEnrollmentByIdAsync(int id);
    public Task<IEnumerable<Enrollment>> GetEnrollmentsByStudentIdAsync(int studentId);
    public Task<IEnumerable<Enrollment>> GetEnrollmentsByClassIdAsync(int classId);
    public Task<int> AddEnrollmentAsync(Enrollment enrollment);
    public Task<int> UpdateEnrollmentAsync(int id, Enrollment enrollment);
    public Task<int> DeleteEnrollmentAsync(int id);
}