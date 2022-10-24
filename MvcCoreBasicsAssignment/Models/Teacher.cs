using AspNetCore;
using Microsoft.AspNetCore.Authentication;

namespace MvcCoreBasicsAssignment.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public  string? FirstName { get; set; }
        public string? LastName { get; set; }
        virtual public School School { get; set; }

        public virtual ICollection<Student> Students { get; set; }

    }
}
