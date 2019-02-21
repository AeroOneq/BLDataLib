using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Models;
using AeroORMFramework;
using DataLib;
using System.IO;
using DataLib.Services;

namespace DatabaseController
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /* byte[] image;
                 using (FileStream fs = new FileStream("C:\\Users\\Aero\\Desktop\\secondCat.jpg", FileMode.Open,
                     FileAccess.Read))
                 {
                     image = new byte[fs.Length];
                     fs.Read(image, 0, (int)fs.Length);
                     fs.Close();
                 }

                 GoodInfo goodInfo = new GoodInfo()
                 {
                     ID = 1,
                     CreatorID = 0,
                     Name = "Дрель - водоворт",
                     Description = "я в тильте СУКА ЭТУ ДРЕЛЬ!!! !!!!!11111",
                     Category = "Крутилка",
                     CreationDate = DateTime.Now,
                     Address = new Address
                     {
                         Country = "Russia",
                         City = "Moscow",
                         Street = "Kochna",
                         BuildingNumber = "49/1",
                         PostIndex = "111555"
                     },
                     PhotosList = new List<byte[]>()
                     {
                         image
                     },
                     Status = "В аренде",
                     Parameters = new Parameters
                     {
                         Pledge = 1000,
                         CostOfRent = 10000,
                         PaymentType = "Cash",
                         RentTime = new TimeSpan(5, 10, 0, 0)
                     },
                 };
                 Connector connector = new Connector(DatabaseSettings.СonnectionString);*/
                GetRecords();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey(true);
            }
        }

        private async static void GetRecords()
        {
            GoodsService goodsService = new GoodsService(DatabaseSettings.СonnectionString);
            var sortedList = await goodsService.GetAllGoodsAync();
            Console.WriteLine("Success");
        }
    }
}
