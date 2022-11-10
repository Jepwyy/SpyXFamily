using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpyXFamily.Models;

namespace SpyXFamily.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featuredPosts = new List<FeaturedViewModel>
            {
                new FeaturedViewModel() {
                    Id = "anya",
                    Header = "Characters",
                    Title = "Anya Forger",
                    PostedDate = DateTime.Now,
                    Description = @"Anya Forger is the deuteragonist in the Japanese anime and manga series Spy X Family. She is the adoptive daughter of Loid Forger and Yor Forger, having been taking under Loid's care as part of his current mission.",
                    ImageUrl = "anya.jpg"
                },
                new FeaturedViewModel() {
                    Id = "loid",
                    Header = "Videos",
                    Title = "Loid Forger",
                    PostedDate = DateTime.Now,
                    Description = @"Loid Forger, codenamed Twilight, is the titular main protagonist of the 2019 comedy spy manga series Spy × Family and its anime adaptation.",
                    ImageUrl = "loid.jpg"
                }
            };

            return View(featuredPosts);
        }

        public IActionResult School()
        {




            List<Teacher> TeachersDetails()
            {
                List<Teacher> teachers = new List<Teacher>();
                teachers.Add(new Teacher 
                { 
                    TeacherId = 1,
                    Code = "HH",
                    Name = "Henry Henderson"
                });
                teachers.Add(new Teacher 
                {
                    TeacherId = 2,
                    Code = "MS",
                    Name = "Murdoch Swan"
                });
                teachers.Add(new Teacher 
                {
                    TeacherId = 3,
                    Code = "WE",
                    Name = "Walter Evance"
                });
                return teachers;
            }

            List<Student> StudentsDetails()
            {
                List<Student> students = new List<Student>();
                students.Add(new Student 
                { 
                    StudentId = 1,
                    Code = "AJ01",
                    Name = "Damian Desmond",
                    EnrollmentNo = "456234467"
                });
                students.Add(new Student 
                {
                    StudentId = 2,
                    Code = "3JJ6",
                    Name = "Anya Forger",
                    EnrollmentNo = "583573583" 
                });
                students.Add(new Student 
                {
                    StudentId = 3,
                    Code = "LJ43",
                    Name = "Becky Blackbell",
                    EnrollmentNo = "562857364"
                });
                return students;
            }


            TableModel SchoolModel = new TableModel();
            SchoolModel.Teachers = TeachersDetails();
            SchoolModel.Students = StudentsDetails();
            return View(SchoolModel);
        }



    }




    
}  


