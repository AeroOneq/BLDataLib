using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Models;

namespace DataLib.Interfaces
{
    /// <summary>    
    /// Interface which determines set of functions which must be realised
    /// by the Category services
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Gets the List of CategoryInfo objects
        /// </summary>
        Task<List<CategoryInfo>> GetAll();
    }
}
