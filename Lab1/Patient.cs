using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Patient
    {
        private string _name;
        public string PName
        {
            set { _name = value; }
            get { return _name; }
        }
        public Patient(string Name)
        {
            _name = Name;
        }
    }
}
