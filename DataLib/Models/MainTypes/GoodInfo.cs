using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroORMFramework;

namespace DataLib.Models
{
    public class GoodInfo
    {
        [PrimaryKey]
        [CanBeNull(false)]
        [AutoincrementID]
        public int ID { get; set; }
        [CanBeNull(false)]
        public int CreatorID { get; set; }
        [CanBeNull(false)]
        public string Name { get; set; }
        [CanBeNull(false)]
        public string Description { get; set; }
        [CanBeNull(false)]
        public string Category { get; set; }
        [CanBeNull(false)]
        public DateTime CreationDate { get; set; }
        [CanBeNull(false)]
        [Json]
        public Address Address { get; set; }
        [CanBeNull(false)]
        [Json]
        public List<byte[]> PhotosList { get; set; }
        [CanBeNull(false)]
        public string Status { get; set; }
        [CanBeNull(false)]
        [Json]
        public Parameters Parameters { get; set; }


    }
}
