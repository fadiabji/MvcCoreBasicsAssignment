using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MvcCoreBasicsAssignment.Data;
using MvcCoreBasicsAssignment.Models;
using MvcCoreBasicsAssignment.Services;
using System;

namespace MvcCoreBasicsAssignment.Services

{
    public class StudentService : IStudentService
    {
        public  ApplicationDbContext _db;

        public StudentService(ApplicationDbContext db)
        {
            _db = db;
        }
        public void CreateStudents()
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student("Justin", "Bieber"),
                new Student( "Well", "Smith"),
                new Student("Eddie", "Sheran"),
                new Student( "Micheal", "Jackson"),
                new Student( "Bob", "Marley"),
                new Student( "Iron", "Maiden"),
            };
            _db.Students.AddRange(studentsList);
            _db.SaveChanges();
        }


        public void CreateOneStudent(Student s)
        {
            _db.Students.Add(s);
            _db.SaveChanges();
        }

        public IEnumerable<Student> GetStudentSList()
        {
            var students = _db.Students.Select(c => c).OrderBy(c => c.FirstName).ToList();
            return students;
        }

    }
}
