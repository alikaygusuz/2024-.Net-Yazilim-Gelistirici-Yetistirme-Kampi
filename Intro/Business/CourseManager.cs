
using Intro.DataAccess.Concretes;
using Intro.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    
    public List<Course> GetAll()
    {
        CourseDal courseDal = new CourseDal();
        return courseDal.GetAll();
    }
}
}