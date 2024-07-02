using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IEnrollmentRepository : ICreateRepository<Enrollment>, IUpdateRepository<Enrollment>, IDeleteRepository<Enrollment>, IReadRepository<Enrollment>
{
    
}