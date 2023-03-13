using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore.Services.Data
{
    public interface ICategoryService
    {
        Task<ICollection<CategoryDTO>> GetAllCategoriesAsync();
    }
}
