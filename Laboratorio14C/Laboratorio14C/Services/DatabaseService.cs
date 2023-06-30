using Laboratorio14C.Interfaces;
using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14C.Services
{
    public class DatabaseService : IDatabaseService
    {
        private List<Course> _courses;

        public DatabaseService()
        {
            // Inicializar la lista de cursos
            _courses = new List<Course>();
        }

        public void InsertCourse(Course course)
        {
            // Lógica para insertar el curso en la base de datos
            _courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            // Lógica para obtener los cursos de la base de datos
            return _courses;
        }
    }
}
