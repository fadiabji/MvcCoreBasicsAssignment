using MvcCoreBasicsAssignment.Data;
using MvcCoreBasicsAssignment.Models;

namespace MvcCoreBasicsAssignment.Services
{
    public class GetListService : IGetListService
    {

        public ApplicationDbContext db;
        public IEnumerable<Student> GetStudentSList()
        {
            var students = db.Students.Select(c => c).OrderBy(c => c).ToList();
            return students;
        }
    }
}
