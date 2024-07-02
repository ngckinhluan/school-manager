using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class GradeRepository(GradeDao gradeDao) : IGradeRepository
{
    public GradeDao GradeDao { get; set; } = gradeDao;
    
    public async Task<int> Create(Grade grade)
    {
        return await GradeDao.AddGradeAsync(grade);
    }

    public async Task<int> Update(int id, Grade grade)
    {
        return await GradeDao.UpdateGradeAsync(id, grade);
    }

    public async Task<int> Delete(int id)
    {
        return await GradeDao.DeleteGradeAsync(id);
    }

    public async Task<IEnumerable<Grade>?> GetAll()
    {
        return await GradeDao.GetGradesAsync();
    }

    public async Task<Grade?> GetById(int id)
    {
        return await GradeDao.GetGradeByIdAsync(id);
    }
}