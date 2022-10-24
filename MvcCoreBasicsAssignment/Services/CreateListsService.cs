using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MvcCoreBasicsAssignment.Data;
using MvcCoreBasicsAssignment.Models;
using MvcCoreBasicsAssignment.Services;
using System;

namespace MvcCoreBasicsAssignment.Services

{
    public class CreateListsService : ICreateListService
    {
        public  ApplicationDbContext db;

       
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
            db.Students.AddRange(studentsList);
            db.SaveChanges();
            
        }

    }
}
