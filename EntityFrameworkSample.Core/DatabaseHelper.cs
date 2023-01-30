using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkSample.Core;
using EntityFrameworkSample.Core.Model.Context;
using EntityFrameworkSample.Core.Model.Entity;

namespace EntityFrameworkSample.Core
{
    public class DatabaseHelper : IDatabaseHelper
    {
        EntityFrameworkSampleContext db = new EntityFrameworkSampleContext();
        public DatabaseHelper()
        {

        }
        public List<Student> StudentList()
        {
            try
            {
                return db.Students.ToList();
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
                return db.Lectures.ToList();

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
                return db.Grades.ToList();
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
                db.Students.Add(student);
                db.SaveChanges();
                return db.Students.ToList();
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
                db.Entry(student).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return db.Students.ToList();

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
                return db.Students.Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        public List<Student> Update(Student student, string studentName, string studentSurname)
        {
            student.StudentName = studentName;
            student.StudentSurname = studentSurname;
            db.SaveChanges();
            return db.Students.ToList();
        }
        public IEnumerable<object> Update(Grade grade, int grade1, int grade2, int average,bool success)
        {
            grade.Grade1 = grade1;
            grade.Grade2 = grade2;
            grade.Average = average;
            grade.StudentState = success;
            db.SaveChanges();
            return GetProcedure();
        }
        public IEnumerable<object> GetProcedure()
        {
            var query = from Grades in db.Grades.ToList()
                        join Students in db.Students.ToList() on Grades.StudentID equals Students.StudentID
                        join Lectures in db.Lectures.ToArray() on Grades.LectureID equals Lectures.LectureID
                        select new
                        {
                            GradeID = Grades.GradeID,
                            StudentName = Students.StudentName + " " + Students.StudentSurname,
                            LectureName = Lectures.LectureName,
                            Grade1 = Grades.Grade1,
                            Grade2 = Grades.Grade2,
                            Average = Grades.Average,
                            State = Grades.StudentState
                        };
            return query.ToList();
        }
        public Grade FindGrade(int id)
        {
            try
            {
                return db.Grades.Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
