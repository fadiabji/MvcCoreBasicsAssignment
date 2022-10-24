using MvcCoreBasicsAssignment.Models;

namespace MvcCoreBasicsAssignment.Services
{
    public interface IGetListService
    {
        IEnumerable<Student> GetStudentSList();
    }
}
