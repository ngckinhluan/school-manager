using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IEnrollmentRepository : ICreateRepository<Enrollment>, IUpdateRepository<Enrollment>, IDeleteRepository<Enrollment>, IReadRepository<Enrollment>
{
    Task<IEnumerable<Enrollment>> GetByStudentId(int studentId);
    Task<IEnumerable<Enrollment>> GetByClassId(int classId);
}