using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Models;

namespace BusinessLogic.Interfaces
{
    public interface IProdCategoryBL : IGenericBL<Category>
    {
        Category GetCategoryById(int Id);

        IEnumerable<Category> GetAllCategory();
    }
}
