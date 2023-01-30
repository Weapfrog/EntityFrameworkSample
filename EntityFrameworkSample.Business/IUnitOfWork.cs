using EntityFrameworkSample.Core.Model.Entity;
using System.Collections.Generic;

namespace EntityFrameworkSample.Business
{
    public interface IUnitOfWork
    {
        Student Find(int id);
        Grade FindGrade(int id);
        IEnumerable<object> GetProcedure();
        List<Grade> GradesList();
        List<Student> Insert(Student student);
        List<Lecture> LectureList();
        IEnumerable<object> Update(Grade grade, int grade1, int grade2, int average, bool success);
        List<Student> StudentList();
        List<Student> Update(Student student, string studentName, string studentSurname);
    }
}