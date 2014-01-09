using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*private void NewOperationBtn_Click(object sender, EventArgs e)
        {
            NewOperation NewOp = new NewOperation();
            NewOp.ShowDialog();
        }*/

        private void ShowOperationBtn_Click(object sender, EventArgs e)
        {
            Operation.GetInfoAll();
        }
    }
}
