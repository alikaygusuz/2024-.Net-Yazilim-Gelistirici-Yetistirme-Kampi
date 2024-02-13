using KodlamaIoDemoHw.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KodlamaIoDemoHw.Business.Abstract;

public interface ICourseService
{ 
    void Add(Course course);
    void Delete(int id);
    void Update(Course course);
    List<Course> GetAll();
    Course GetById(int id);
    void PrintAll(List<Course> courses);
    void PrintCourse(Course course);
}