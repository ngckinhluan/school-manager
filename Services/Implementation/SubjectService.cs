using BusinessObjects.Entities;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class SubjectService(ISubjectRepository subjectRepository) : ISubjectService
{
    public ISubjectRepository SubjectRepository { get; set; } = subjectRepository;
    public async Task<IEnumerable<Subject?>?> GetAllSubjectsAsync()
    {
        return await SubjectRepository.GetAll();
    }

    public async Task<Subject?> GetSubjectByIdAsync(int id)
    {
        return await SubjectRepository.GetById(id);
    }

    public async Task<int> CreateSubjectAsync(Subject subject)
    {
        return await SubjectRepository.Create(subject);
    }

    public async Task<int> UpdateSubjectAsync(int id, Subject subject)
    {
        return await SubjectRepository.Update(id, subject);
    }

    public async Task<int> DeleteSubjectAsync(int id)
    {
        return await SubjectRepository.Delete(id);
    }
}