﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class Person : IDataErrorInfo
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (value.All(x => Char.IsLetter(x)))
                    name = value;
                else
                    throw new Exception("Bitte gib nur Buchstaben ein");
            }
        }

        public int Alter { get; set; }

        public string Error => null;

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case (nameof(Alter)):
                        if (Alter < 0) return "Du musst älter sein als -1";
                        if (Alter > 150) return "Bitte gib dein wahres Alter an";
                        break;
                }

                return null;
            }
        }
    }
}