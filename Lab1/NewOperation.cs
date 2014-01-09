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
    public partial class NewOperation : Form
    {
        public NewOperation()
        {
            InitializeComponent();
        }
        Operation op;
        Doctor doc;
        Patient pat;
        private void createbtn_Click(object sender, EventArgs e)
        {
            pat = new Patient(PatientTB.Text);
            doc = new Doctor(DoctorTB.Text);
            op = new Operation(OperationTB.Text, doc.DName, pat.PName);
            op.LOperation.Add(op);
            this.Close();

        }
    }
}
