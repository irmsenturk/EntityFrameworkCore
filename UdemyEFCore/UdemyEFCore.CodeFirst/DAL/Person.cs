﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace UdemyEFCore.CodeFirst.DAL
{
    public class Person
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string Phone { get; set; }


    }
}
