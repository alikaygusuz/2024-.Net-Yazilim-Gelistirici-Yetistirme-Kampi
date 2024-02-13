using KodlamaIoDemoHw.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemoHw.DataAccess.Abstract;

public interface ICategoryDal
{
    void Add(Category category);
    void Delete(int id);
    void Update(Category category);
    public List<Category> GetAll();
    public Category GetById(int id);
    public void PrintAll(List<Category> categories);
    void PrintCategory(Category category);
}


