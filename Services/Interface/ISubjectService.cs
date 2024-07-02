using BusinessObjects.Entities;

namespace Services.Interface;

public interface ISubjectService
{
    public Task<IEnumerable<Subject?>?> GetAllSubjectsAsync();
    public Task<Subject?> GetSubjectByIdAsync(int id);
    public Task<int> CreateSubjectAsync(Subject subject);
    public Task<int> UpdateSubjectAsync(int id, Subject subject);
    public Task<int> DeleteSubjectAsync(int id);
}