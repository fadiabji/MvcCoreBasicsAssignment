using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using MvcCoreBasicsAssignment.Data;
using MvcCoreBasicsAssignment.Models;
using MvcCoreBasicsAssignment.Services;
using System;

namespace MvcCoreBasicsAssignment.Services

{
    public class TeacherService : ITeacherService
    {
        public  ApplicationDbContext _db;

        public TeacherService(ApplicationDbContext db)
        {
            _db = db;
        }


        public void CreateTeachers(Teacher t)
        {
            _db.Teachers.Add(t);
            _db.SaveChanges();
        }

        public IEnumerable<Teacher> GetTeachersList()
        {
            var Teachers = _db.Teachers.Select(t => t).OrderBy(t => t.FirstName).ToList();
            return Teachers;
        }

    }
}
