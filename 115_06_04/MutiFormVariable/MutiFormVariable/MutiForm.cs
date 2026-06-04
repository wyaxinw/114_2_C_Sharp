using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiFormVariable
{
    public partial class MutiForm : Form
    {
        private string username = "Xenia";
        //public string Username    
        //{
        //    get { return username; }
        //}
        public MutiForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm1 secondForm = new SecondForm1(ref username);
            secondForm.ShowDialog();
            MessageBox.Show("Username in MutiForm: " + username);
        }
    }
}
