using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab1
{
    class Operation
    {
        private static List<Operation> _loperation = new List<Operation>();
        public List<Operation> LOperation
        {
            get
            {
                return _loperation;
            }
        }
        private string _name;
        private string _doctor;
        private string _patient;
        public string OName
        {
            set { _name = value; }
            get { return _name; }
        }
        public Operation(string OName, string DName, string Pname)
        {
            _name = OName;
            _doctor = DName;
            _patient = Pname;
        }
        
        public void GetInfo()
        {
            MessageBox.Show("Доктор: " + _doctor + "\nПациент: " + _patient + "\nОперация: " +
                _name);
        }
        public static void GetInfoAll()
        {
            foreach (Operation operation in _loperation)
            {
                operation.GetInfo();
            }
        }
    }
}
