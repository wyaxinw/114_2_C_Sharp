using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MutiFormVariable
{
    public partial class MainForm : Form
    {
        public string userName = "Xenia";

        public MainForm()
        {
            InitializeComponent();
            // wire up the button click handler if not set in Designer
            this.button1.Click += this.button1_Click;
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            // optional initialization
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecondForm secondForm = new SecondForm(this);
            secondForm.Show();
        }
    }
}
