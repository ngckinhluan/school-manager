using BusinessObjects.Entities;
using Services.Interface;

namespace Services.Implementation;

public class GradeService : IGradeService
{
    public Task<IEnumerable<Grade>> GetAllGradesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Grade?> GetGradeByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateGradeAsync(Grade grade)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateGradeAsync(int id, Grade grade)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteGradeAsync(int id)
    {
        throw new NotImplementedException();
    }
}