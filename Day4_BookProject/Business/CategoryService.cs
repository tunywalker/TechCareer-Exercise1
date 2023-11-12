using Day4_BookProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_BookProject.Business;

public class CategoryService:ICategoryService
{

    private readonly ICategoryRepository _categoryRepository;

     CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void GetList()
    {
        throw new NotImplementedException();
    }
}
