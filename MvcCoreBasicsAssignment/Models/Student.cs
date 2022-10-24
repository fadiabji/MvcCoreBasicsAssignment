namespace MvcCoreBasicsAssignment.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual School School { get; set; }
        
        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}
