﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Models;

namespace DataLib.Services
{
    public class CategoryService
    {
        private Database Database { get; }

        /// <summary>
        /// Initializes the connection with a given connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public CategoryService(string connectionString) =>
            Database = new Database(connectionString);

        /// <summary>
        /// Gets all categories and returns a list of CategoryInfo
        /// </summary>
        /// <returns></returns>
        public async Task<List<CategoryInfo>> GetAllCategories()
        {
            return await Task.Run(() => Database.GetAllCategories());
        }
    }
}
