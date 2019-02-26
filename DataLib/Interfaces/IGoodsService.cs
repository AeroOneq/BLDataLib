using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Models;

namespace DataLib.Interfaces
{
    public interface IGoodsService
    {
        /// <summary>
        /// Gets all goods grouped by caategories
        /// </summary>
        Task<SortedList<string, List<GoodInfo>>> GetAllAsync();
        /// <summary>
        /// Gets a list of GoodInfo of given category
        /// </summary>
        Task<List<GoodInfo>> GetAllAsync(string category);

        Task InsertAsync(GoodInfo good);
    }
}
