using Laboratorio14C.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Laboratorio14C.Interfaces;
namespace Laboratorio14C.ViewModels
{
    public class InsertCourseViewModel : BaseViewModel
    {
        private string _name;
        private string _description;
        private decimal _credit;
        private DateTime _startDate;
        private ICommand _insertCommand;
        private IDatabaseService _databaseService;

        public string Name
        {
            get => _name;
            set => SetValue(ref _name, value);
        }

        public string Description
        {
            get => _description;
            set => SetValue(ref _description, value);
        }

        public decimal Credit
        {
            get => _credit;
            set => SetValue(ref _credit, value);
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => SetValue(ref _startDate, value);
        }

        public ICommand InsertCommand
        {
            get
            {
                if (_insertCommand == null)
                    _insertCommand = new RelayCommand(Insert, CanInsert);

                return _insertCommand;
            }
        }

        public InsertCourseViewModel(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        private void Insert()
        {
            // Lógica para insertar los datos en la base de datos
            Course newCourse = new Course
            {
                Name = Name,
                Description = Description,
                Credit = Credit,
                StartDate = StartDate
            };

            _databaseService.InsertCourse(newCourse);
        }

        private bool CanInsert()
        {
            return !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Description) && Credit > 0 && StartDate != default(DateTime);
        }
    }
}
