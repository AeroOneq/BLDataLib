﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AeroORMFramework;

namespace DataLib.Models
{
    public class UserInfo
    {
        [PrimaryKey]
        [AutoincrementID]
        [CanBeNull(false)]
        public int ID { get; set; }
        [CanBeNull(false)]
        public string Name { get; set; }
        [CanBeNull(false)]
        public string Surname { get; set; }
        [CanBeNull(false)]
        public string FamilyName { get; set; }
        [CanBeNull(false)]
        public string Password { get; set; }
        [CanBeNull(false)]
        public DateTime BirthDate { get; set; }
        [CanBeNull(false)]
        public string Email { get; set; }
        [CanBeNull(false)]
        public string Sex { get; set; }
        [CanBeNull(false)]
        public byte[] PassportPhoto { get; set; }
        [CanBeNull(false)]
        public byte[] DrivingLiscencePhoto { get; set; }
        [CanBeNull(false)]
        public string PhoneNumber { get; set; }
        [CanBeNull(false)]
        public string Promocode { get; set; }
        [CanBeNull(false)]
        public int Raiting { get; set; }
        [CanBeNull(false)]
        public bool PassportVerificationStatus { get; set; }
        [CanBeNull(false)]
        [Json]
        public Address Address { get; set; }
        [CanBeNull(false)]
        [Json]
        public Settings Settings { get; set; }
    }
}
