using BusinessObjects.Entities;
using DAO;
using Repositories.Interface;

namespace Repositories.Implementation;

public class AssignmentRepository(AssignmentDao assignmentDao) : IAssignmentRepository
{
    public AssignmentDao AssignmentDao { get; set; } = assignmentDao;
    
    public async Task<int> Create(Assignment assignment)
    {
        return await AssignmentDao.AddAssignmentAsync(assignment);
    }

    public async Task<int> Update(int id, Assignment assignment)
    {
        return await AssignmentDao.UpdateAssignmentAsync(id, assignment);
    }

    public async Task<int> Delete(int id)
    {
        return await AssignmentDao.DeleteAssignmentAsync(id);
    }

    public async Task<IEnumerable<Assignment>?> GetAll()
    {
        return await AssignmentDao.GetAssignmentsAsync();
    }

    public async Task<Assignment?> GetById(int id)
    {
        return await AssignmentDao.GetAssignmentByIdAsync(id);
    }
}