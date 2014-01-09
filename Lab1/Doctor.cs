using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Doctor
    {
        private string _name;
        public string DName
        {
            set { _name = value; }
            get { return _name; }
        }
        public Doctor(string DName)
        {
            _name = DName;
        }
    }
}
