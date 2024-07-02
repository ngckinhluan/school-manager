using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IClassRepository : ICreateRepository<Class>, IUpdateRepository<Class>, IDeleteRepository<Class>, IReadRepository<Class>
{
    
}