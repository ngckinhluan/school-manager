using BusinessObjects.Entities;

namespace Services.Interface;

public interface IGradeService
{
    public Task<IEnumerable<Grade>> GetAllGradesAsync();
    public Task<Grade?> GetGradeByIdAsync(int id);
    public Task<int> CreateGradeAsync(Grade grade);
    public Task<int> UpdateGradeAsync(int id, Grade grade);
    public Task<int> DeleteGradeAsync(int id);
}