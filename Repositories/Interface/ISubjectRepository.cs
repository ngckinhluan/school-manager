using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface ISubjectRepository : ICreateRepository<Subject>, IUpdateRepository<Subject>, IDeleteRepository<Subject>, IReadRepository<Subject>
{
    
}