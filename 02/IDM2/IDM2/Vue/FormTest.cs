using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDM2.BaseDonnee;
using IDM2.Controleur;

namespace IDM2.Vue
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            Test t  =new Test();
            dateTimePicker1.Value = t.Date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.Date = dateTimePicker1.Value;

        }
    }
}
