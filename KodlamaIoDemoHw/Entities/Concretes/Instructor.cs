﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoDemoHw.Entities.Concretes
{
    public class Instructor : BasePerson
    {
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string NationalIdentity { get; set; }

    }
}
