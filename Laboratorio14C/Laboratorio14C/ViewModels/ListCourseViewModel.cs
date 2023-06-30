using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Laboratorio14C.Interfaces;

namespace Laboratorio14C.ViewModels
{
    public class ListCourseViewModel : BaseViewModel
    {
        private ObservableCollection<Course> _courses;
        private IDatabaseService _databaseService;

        public ObservableCollection<Course> Courses
        {
            get => _courses;
            set => SetValue(ref _courses, value);
        }

        public ListCourseViewModel(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
            Courses = new ObservableCollection<Course>();
        }

       

        public void LoadData()
        {
            // Lógica para cargar los datos de la base de datos
            List<Course> coursesFromDatabase = _databaseService.GetCourses();
            Courses.Clear();
            foreach (var course in coursesFromDatabase)
            {
                Courses.Add(course);
            }
        }
    }
}
