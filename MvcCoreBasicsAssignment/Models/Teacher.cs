using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication;

namespace MvcCoreBasicsAssignment.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        virtual public School School { get; set; }

        public virtual ICollection<Student> Students { get; set; }


        public Teacher()
        {

        }
        public Teacher(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname;
        }
    }
}
