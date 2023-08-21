using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transaction
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public DateTime DateTime { get; set; }
    }
}
