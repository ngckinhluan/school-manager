using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface ITeacherRepository : ICreateRepository<Teacher>, IUpdateRepository<Teacher>, IDeleteRepository<Teacher>, IReadRepository<Teacher>
{
    
}