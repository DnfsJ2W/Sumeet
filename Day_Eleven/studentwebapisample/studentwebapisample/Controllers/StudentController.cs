using studentwebapisample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace studentwebapisample.Controllers
{
    [RoutePrefix("api/Students" )]
    public class StudentController : ApiController
    {
        static List<Student> students = new List<Student>() {

            new Student(){ Id=1,Name="sumeet"},
             new Student(){ Id=2,Name="mohit"},
              new Student(){ Id=3,Name="mahendra"},


        };

        [Route("")]
        public IEnumerable<Student> Get()
        {
            return students;
        }
        [Route("{id:int:min(1):max(3)}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(a=>a.Id==id);
        }
        [Route("{name:alpha}")]
        public Student Get(string name)
        {
            return students.FirstOrDefault(a => a.Name == name);
        }
        [Route("{id}/Courses")]
        public IEnumerable<string> GetStudentCourses(int id)
        {
            if (id ==1)
            {
                return new List<string>() { "C#", "Asp.Net", "Sql" };
            }
            if (id == 2)
            {
                return new List<string>() { "Webapi", "Core", "Mongo" };
            }
            else {

                return new List<string>() { "Bootstrap", "jQuery", "Angularjs" };
            }

           
        }


        static List<Teacher> teachers = new List<Teacher>() {

            new Teacher(){ Id=1,Name="teacher1"},
             new Teacher(){ Id=2,Name="teacher2"},
              new Teacher(){ Id=3,Name="teacher2"},


        };

        [Route("~/api/teachers/")]
        public IEnumerable<Teacher> GetTeachers()
        {
            return teachers;
        }
    }
}
