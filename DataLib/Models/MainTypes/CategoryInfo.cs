using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroORMFramework;

namespace DataLib.Models
{
    public class CategoryInfo
    {
        [PrimaryKey]
        [AutoincrementID]
        [CanBeNull(false)]
        public int ID { get; set; }
        [CanBeNull(false)]
        public string CategoryName { get; set; }
        [CanBeNull(false)]
        [Json]
        public byte[] Icon { get; set; }
    }
}
