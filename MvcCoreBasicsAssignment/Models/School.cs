using Microsoft.AspNetCore.Authentication;

namespace MvcCoreBasicsAssignment.Models
{
    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
