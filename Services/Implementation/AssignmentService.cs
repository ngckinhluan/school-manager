using BusinessObjects.Entities;
using Repositories.Implementation;
using Repositories.Interface;
using Services.Interface;

namespace Services.Implementation;

public class AssignmentService(IAssignmentRepository assignmentRepository) : IAssignmentService
{
    public IAssignmentRepository AssignmentRepository { get; set; } = assignmentRepository;
    public async Task<IEnumerable<Assignment?>?> GetAllAssignmentsAsync()
    {
        return await AssignmentRepository.GetAll();
    }

    public async Task<Assignment?> GetAssignmentByIdAsync(int id)
    {
        return await AssignmentRepository.GetById(id);
    }

    public async Task<int> AddAssignmentAsync(Assignment assignment)
    {
        return await AssignmentRepository.Create(assignment);
    }

    public async Task<int> UpdateAssignmentAsync(int id, Assignment assignment)
    {
        return await AssignmentRepository.Update(id, assignment);
    }

    public async Task<int> DeleteAssignmentAsync(int id)
    {
        return await AssignmentRepository.Delete(id);
    }
}