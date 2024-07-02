using BusinessObjects.Entities;
using Services.Interface;

namespace Services.Implementation;

public class SubjectService : ISubjectService
{
    public Task<IEnumerable<Subject>> GetAllSubjectsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Subject?> GetSubjectByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> CreateSubjectAsync(Subject subject)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateSubjectAsync(int id, Subject subject)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteSubjectAsync(int id)
    {
        throw new NotImplementedException();
    }
}