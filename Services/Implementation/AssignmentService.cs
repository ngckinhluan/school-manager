using BusinessObjects.Entities;
using Services.Interface;

namespace Services.Implementation;

public class AssignmentService : IAssignmentService
{
    public Task<IEnumerable<Assignment>> GetAllAssignmentsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Assignment?> GetAssignmentByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAssignmentAsync(Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task<int> UpdateAssignmentAsync(int id, Assignment assignment)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAssignmentAsync(int id)
    {
        throw new NotImplementedException();
    }
}