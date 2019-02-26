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
        public const string SERVER = "borrowlend222";
        public const string DATABASE = "DOU";
        public const string LOGIN = "roman";
        public const string PASSWORD = "Cap_obviousness1";

        /// <summary>
        /// Connect to Azure Data Base
        /// </summary>
        public static string ConnectionString => $@"Data Source={SERVER}.database.windows.net;
                       Initial Catalog={DATABASE};
                       Integrated Security=True; 
                       User ID={LOGIN};
                       Password={PASSWORD}; 
                       Trusted_Connection=False; 
                       Encrypt=True;";
        static void Main(string[] args)
        {
            try
            {
                 byte[] image;
                 using (FileStream fs = new FileStream("C:\\Users\\Aero\\Desktop\\secondCat.jpg", FileMode.Open,
                     FileAccess.Read))
                 {
                     image = new byte[fs.Length];
                     fs.Read(image, 0, (int)fs.Length);
                     fs.Close();
                 }

                 GoodInfo goodInfo = new GoodInfo()
                 {
                     CreatorID = 0,
                     Name = "Дрель - водоворт",
                     Description = "я в тильте СУКА ЭТУ ДРЕЛЬ!!! !!!!!11111",
                     Category = "Гвоздь",
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



                Go(goodInfo);
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

        private async static void Go(GoodInfo good)
        {
            Connector connector = new Connector(ConnectionString);
            byte[] image;
            using (FileStream fs = new FileStream("C:\\Users\\Aero\\Downloads\\applicationIcon.png", FileMode.Open,
                FileAccess.Read))
            {
                image = new byte[fs.Length];
                fs.Read(image, 0, (int)fs.Length);
                fs.Close();
            }
            connector.Insert<CategoryInfo>(new CategoryInfo { CategoryName = "Инструменты", Icon = image });

            Console.WriteLine("Success");
        }
    }
}
