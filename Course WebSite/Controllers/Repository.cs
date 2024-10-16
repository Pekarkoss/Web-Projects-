using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspBasics.Models;

namespace AspBasics.Controllers
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>(){
                  new Course {
                     Id = 1 ,
                     Title = "Asp", 
                     Description = "Güzel Kurs",
                     Image = "1.jpeg",
                     Tags = new string[]  {"Asp.net","Web Geliştirme"},
                     isActive = true,
                     isHome = true
                     },
                  new Course {
                     Id = 2 ,
                     Title = "Django",
                     Description ="10/10 kurs",
                     Image = "2.jpeg" ,
                     Tags = new string[]  {"","Web Geliştirme"},
                     isActive = true,
                     isHome = true
                     },
                  new Course {
                     Id = 3 ,
                     Title = "Myongo",
                     Description= "Fake kurs",
                     Image = "3.jpeg" ,
                     Tags = new string[]  {"Asp.FAKE","Web Geliştirme"},
                     isActive = true,
                     isHome = true
                     }
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public static Course? GetbyId(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}