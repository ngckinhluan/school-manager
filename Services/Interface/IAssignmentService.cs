using BusinessObjects.Entities;

namespace Services.Interface;

public interface IAssignmentService
{
    public Task<IEnumerable<Assignment>> GetAllAssignmentsAsync();
    public Task<Assignment?> GetAssignmentByIdAsync(int id);
    public Task<int> AddAssignmentAsync(Assignment assignment);
    public Task<int> UpdateAssignmentAsync(int id, Assignment assignment);
    public Task<int> DeleteAssignmentAsync(int id);
}