using BusinessObjects.Entities;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class GradeService(IGradeRepository gradeRepository) : IGradeService
{
    public IGradeRepository GradeRepository { get; set; } = gradeRepository;
    public async Task<IEnumerable<Grade?>?> GetAllGradesAsync()
    {
       return await GradeRepository.GetAll();
    }

    public async Task<Grade?> GetGradeByIdAsync(int id)
    {
        return await GradeRepository.GetById(id);
    }

    public async Task<int> CreateGradeAsync(Grade grade)
    {
        return await GradeRepository.Create(grade);
    }

    public async Task<int> UpdateGradeAsync(int id, Grade grade)
    {
        return await GradeRepository.Update(id, grade);
    }

    public async Task<int> DeleteGradeAsync(int id)
    {
        return await GradeRepository.Delete(id);
    }
}