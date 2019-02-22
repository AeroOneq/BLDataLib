﻿using System.Collections.Generic;
using System.Threading.Tasks;
using DataLib.Models;
using System.Data.SqlClient;

namespace DataLib.Services
{
    /// <summary>
    /// Class where all operations connected with goods and database are stored
    /// </summary>
    public class GoodsService
    {
        private Database Database { get; }

        /// <summary>
        /// Initializes the connection with a given connection string
        /// </summary>
        public GoodsService(string connectionString)
            => Database = new Database(connectionString);

        /// <summary>
        /// Create and returns sorted list where a key is a category and a value is 
        /// a list of goods of this category
        /// </summary>
        /// <exception cref="SqlException"></exception>
        public async Task<SortedList<string, List<GoodInfo>>> GetAllGoodsAsync()
        {
            return await Task.Run(() =>
            {
                List<GoodInfo> goodInfosList = Database.GetAllGoods();
                return CreateCategorySortedList(goodInfosList); ;
            });
        }
        private SortedList<string, List<GoodInfo>> CreateCategorySortedList(
            List<GoodInfo> goodInfosList)
        {
            SortedList<string, List<GoodInfo>> categoriesSortedList
                = new SortedList<string, List<GoodInfo>>();
            foreach (GoodInfo goodInfo in goodInfosList)
            {
                string category = goodInfo.Category;
                if (categoriesSortedList.ContainsKey(category))
                {
                    categoriesSortedList[category].Add(goodInfo);
                }
                else
                {
                    categoriesSortedList[category] = new List<GoodInfo>
                        {
                            goodInfo
                        };
                }
            }
            return categoriesSortedList;
        }

        /// <summary>
        /// Inserts the given good into the GoodInfo table
        /// </summary>
        /// <exception cref="SqlException"></exception>
        public async void InsertGoodAsync(GoodInfo goodInfo)
        {
            await Task.Run(() =>
            {
                Database.InsertGood(goodInfo);
            });
        }

    }
}
