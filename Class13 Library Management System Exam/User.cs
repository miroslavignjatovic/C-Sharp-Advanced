﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> CheckedOutBooks { get; set; }
        public User()
        {
            CheckedOutBooks = new List<Book>();
        }
    }
}
