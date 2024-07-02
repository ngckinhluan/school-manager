using BusinessObjects.Entities;
using Repositories.Interface.GenericRepository;

namespace Repositories.Interface;

public interface IStudentRepository : ICreateRepository<Student>, IUpdateRepository<Student>, IDeleteRepository<Student>, IReadRepository<Student>
{
    
}