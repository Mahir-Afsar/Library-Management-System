using Library_Management_System.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.Interface
{
    interface IStudent
    {
        bool InsertStudent(Student s);
        bool DeleteStudent(Student s);
        bool UpdateStudent(Student s);
        Student GetStudent(string studentId);
        List<Student> GetAllStudents();
    }
}
