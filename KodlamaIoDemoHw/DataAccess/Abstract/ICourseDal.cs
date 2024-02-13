using KodlamaIoDemoHw.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemoHw.DataAccess.Abstract;

public interface ICourseDal
{
    void Add(Course course);
    void Delete(int id);
    void Update(Course course);
    List<Course> GetAll();
    Course GetById(int id);
    public void PrintAll(List<Course> courses);
    void PrintCourse(Course course);
}


