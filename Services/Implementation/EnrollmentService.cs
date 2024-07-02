using BusinessObjects.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class EnrollmentService(IEnrollmentRepository enrollmentRepository) : IEnrollmentService
{
    public IEnrollmentRepository EnrollmentRepository { get; set; } = enrollmentRepository;

    public async Task<IEnumerable<Enrollment?>?> GetAllEnrollmentsAsync()
    {
        return await EnrollmentRepository.GetAll();
    }

    public async Task<Enrollment?> GetEnrollmentByIdAsync(int id)
    {
        return await EnrollmentRepository.GetById(id);
    }

    public async Task<IEnumerable<Enrollment>> GetEnrollmentsByStudentIdAsync(int studentId)
    {
        return await EnrollmentRepository.GetByStudentId(studentId);
    }

    public async Task<IEnumerable<Enrollment>> GetEnrollmentsByClassIdAsync(int classId)
    {
        return await EnrollmentRepository.GetByClassId(classId);
    }

    public async Task<int> AddEnrollmentAsync(Enrollment enrollment)
    {
        return await EnrollmentRepository.Create(enrollment);
    }

    public async Task<int> UpdateEnrollmentAsync(int id, Enrollment enrollment)
    {
        return await EnrollmentRepository.Update(id, enrollment);
    }

    public async Task<int> DeleteEnrollmentAsync(int id)
    {
        return await EnrollmentRepository.Delete(id);
    }
}