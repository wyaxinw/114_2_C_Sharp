using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiform_Practice
{
    public partial class MessageForm : Component
    {
        public MessageForm()
        {
            InitializeComponent();
        }

       private void MessageForm_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
