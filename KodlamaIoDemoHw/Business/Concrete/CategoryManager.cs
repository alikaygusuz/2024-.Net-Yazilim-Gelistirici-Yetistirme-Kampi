using KodlamaIoDemoHw.Business.Abstract;
using KodlamaIoDemoHw.DataAccess.Abstract;
using KodlamaIoDemoHw.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemoHw.Business.Concrete;

public class CategoryManager : ICategoryService
    
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {   //Business Rules
        _categoryDal = categoryDal;
    }

    public void Add(Category category)
    {   //Business Rules
        _categoryDal.Add(category);
    }

    public void Delete(int id)
    {   //Business Rules
        _categoryDal.Delete(id);
    }

    public List<Category> GetAll()
    {   //Business Rules
        return _categoryDal.GetAll();
    }

    public Category GetById(int id)
    {   //Business Rules
        return _categoryDal.GetById(id);
    }

    public void PrintAll(List<Category> categories)
    {
        _categoryDal.PrintAll(categories);
    }

    public void PrintCourse(Category category)
    {
        _categoryDal.PrintCategory(category);
    }

    public void Update(Category category)
    {   //Business Rules
        _categoryDal.Update(category);  
    }

}