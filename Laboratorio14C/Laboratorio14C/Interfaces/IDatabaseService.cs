using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio14C.Interfaces
{
    public interface IDatabaseService
    {
        void InsertCourse(Course course);
        List<Course> GetCourses();
    }
}
