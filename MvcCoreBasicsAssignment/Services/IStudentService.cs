using MvcCoreBasicsAssignment.Models;

namespace MvcCoreBasicsAssignment.Services
{
    public interface IStudentService
    {
        public void CreateStudents();
        IEnumerable<Student> GetStudentSList();

        public void CreateOneStudent(Student s);
    }
}
