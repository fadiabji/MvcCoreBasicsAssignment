using MvcCoreBasicsAssignment.Models;

namespace MvcCoreBasicsAssignment.Services
{
    public interface ITeacherService
    {
        public void CreateTeachers(Teacher t);
        IEnumerable<Teacher> GetTeachersList();
    }
}
