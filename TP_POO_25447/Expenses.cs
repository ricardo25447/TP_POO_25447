﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO_25447
{
    internal class Expenses
    {
        //attributes
        public string TypeOfExpense { get; set; }

        public double AmountOfExpense { get; set; }

        public DateTime DateOfExpense { get; set; }

        //constructor
        public Expenses(string typeOfExpense, double amountOfExpense, DateTime dateOfExpense)
        {
            TypeOfExpense = typeOfExpense;
            AmountOfExpense = amountOfExpense;
            DateOfExpense = dateOfExpense;
        }
    }
}
