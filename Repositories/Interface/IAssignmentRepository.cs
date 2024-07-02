using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IAssignmentRepository : ICreateRepository<Assignment>, IUpdateRepository<Assignment>, IDeleteRepository<Assignment>, IReadRepository<Assignment>
{
    
}