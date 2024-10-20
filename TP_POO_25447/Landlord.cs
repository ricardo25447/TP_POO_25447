﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_25447
{
    internal class Landlord
    {
        //attributes
        public string LandlordFullName { get; set; }
        public string LandlordContracts { get; set; }
        public string LandlordCCNumber { get; set; }

        //constructor
        public Landlord(string landlordFullName, string landlordContracts, string landlordCCNumber)
        {
            LandlordFullName = landlordFullName;
            LandlordContracts = landlordContracts;
            LandlordCCNumber = landlordCCNumber;
        }
    }
}
