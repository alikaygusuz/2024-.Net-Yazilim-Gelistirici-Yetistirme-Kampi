using KodlamaIoDemoHw.DataAccess.Abstract;
using KodlamaIoDemoHw.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemoHw.DataAccess.Concretes;

internal class CategoryDal : ICategoryDal
{
    public List<Category> categories;
    public CategoryDal()
    {
        categories =
            new List<Category>() {
                new Category { CategoryName="C#,",CategoryId=1,CategoryDescription="0 dan ileri seviyeye C# eğitimleri."},
                new Category { CategoryName="JAVA,",CategoryId=2,CategoryDescription="0 dan ileri seviyeye Java eğitimleri."},
                new Category { CategoryName="PYTHON,",CategoryId=3,CategoryDescription="0 dan ileri seviyeye Python eğitimleri."}
            };
    }

    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(int id)
    {
        foreach (var c in categories)
        {
            if (c.CategoryId == id)
            {
                categories.Remove(c);
            }
        }

    }

    public List<Category> GetAll()
    {
        return categories.ToList();
    }

    public Category GetById(int id)
    {

        foreach (var c in categories)
        {
            if (c.CategoryId == id)
            {
                return c;

            }
        }
        throw new Exception("Girdiğiniz Id ile eşleşen bir Kategori bulunmamaktadır.");
    }

  


    public void Update(Category c)

    {
      
       
            var willUpdateCategory = GetById(c.CategoryId);
            willUpdateCategory.CategoryName = c.CategoryName;
            willUpdateCategory.CategoryDescription = c.CategoryDescription;
     
        
    }

    
    public void PrintAll(List<Category> categories)
    {
        foreach (var c in categories)
        {
            PrintCategory(c);
        }
    }

    public void PrintCategory(Category c)
    {
        Console.WriteLine("Kategori ID'si: " + c.CategoryId);
        Console.WriteLine("Kategori İsmi: " + c.CategoryName);
        Console.WriteLine("Kategori Açıklaması: " + c.CategoryDescription);
        Console.WriteLine("");
    }
}