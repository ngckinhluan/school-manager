using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class SubjectRepository(SubjectDao subjectDao) : ISubjectRepository
{
    public SubjectDao SubjectDao { get; set; } = subjectDao;
    
    public async Task<int> Create(Subject subject)
    {
        return await SubjectDao.AddSubjectAsync(subject);
    }

    public async Task<int> Update(int id, Subject subject)
    {
        return await SubjectDao.UpdateSubjectAsync(id, subject);
    }

    public async Task<int> Delete(int id)
    {
        return await SubjectDao.DeleteSubjectAsync(id);
    }

    public async Task<IEnumerable<Subject>?> GetAll()
    {
        return await SubjectDao.GetSubjects();
    }

    public async Task<Subject?> GetById(int id)
    {
        return await SubjectDao.GetSubjectById(id);
    }
}