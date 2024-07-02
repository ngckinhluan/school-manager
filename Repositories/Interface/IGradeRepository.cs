using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IGradeRepository : ICreateRepository<Grade>, IUpdateRepository<Grade>, IDeleteRepository<Grade>, IReadRepository<Grade>
{
    
}