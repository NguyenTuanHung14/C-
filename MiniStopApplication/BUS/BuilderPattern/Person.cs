using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStopApplication.BUS.BuilderPattern
{
    public class Person
    {

        private string _personType;
        // Constructor

        public Person(string personType)
        {
            this._personType = personType;
        }

        // Indexer

        public string FullName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Position { get; set; }

    }
}
