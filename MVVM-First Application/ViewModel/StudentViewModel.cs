using MVVM_First_Application.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_First_Application.ViewModel
{
    public class StudentViewModel
    {
        public ObservableCollection<Student> Students
        {
            get;
            set;
        }

        public void LoadStudents()
        {
            ObservableCollection<Student> students = new ObservableCollection<Student>();
            students.Add(new Student { FirstName = "Merjem", LastName = "Kadunic" });
            students.Add(new Student { FirstName = "Vigor", LastName = "Dundovic" });
            students.Add(new Student { FirstName = "Hadzera", LastName = "Dzihana" });

            Students = students;
        }
    }
}
