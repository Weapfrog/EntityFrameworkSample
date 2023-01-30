using EntityFrameworkSample.Core;
using EntityFrameworkSample.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using EntityFrameworkSample.Core.Model.Context;



namespace EntityFrameworkSample.Business
{
    public class UnitOfWork : IUnitOfWork
    {
        DatabaseHelper helper;
        public UnitOfWork()
        {
            helper = new DatabaseHelper();
        }
        public List<Student> StudentList()
        {
            try
            {
                return helper.StudentList();
            }
            catch (Exception ex)
            {
                return new List<Student>();
            }
        }
        public List<Lecture> LectureList()
        {
            try
            {
                return helper.LectureList();

            }
            catch (Exception ex)
            {
                return new List<Lecture>();
            }
        }
        public List<Grade> GradesList()
        {
            try
            {
                return helper.GradesList();
            }
            catch (Exception ex)
            {
                return new List<Grade>();
            }
        }
        public List<Student> Insert(Student student)
        {
            try
            {
                helper.Insert(student);
                return helper.StudentList();
            }
            catch (Exception ex)
            {
                return new List<Student>();
            }
        }
        public List<Student> Delete(Student student)
        {
            try
            {
                return helper.Delete(student);
            }
            catch (Exception ex)
            {
                return new List<Student>();
            }
        }
        public Student Find(int id)
        {
            try
            {
                return helper.Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<Student> Update(Student student, string studentName, string studentSurname)
        {
            helper.Update(student, studentName, studentSurname);
            return helper.StudentList();
        }
        public IEnumerable<object> GetProcedure()
        {
            return helper.GetProcedure();
        }

        public Grade FindGrade(int id)
        {
            try
            {
                return helper.FindGrade(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<object> Update(Grade grade, int grade1, int grade2, int average, bool success)
        {
            try
            {
                return helper.Update(grade, grade1, grade2, average, success);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
