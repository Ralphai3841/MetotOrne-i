using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetotOrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int number;
        private void Form1_Load(object sender, EventArgs e)
        {
            Assign();
        }

        public void Assign()              // Assign metodu
        {
            lblNumber.Text = number.ToString();
        }
        private void btnincrement_Click(object sender, EventArgs e)
        {
            number++;
            Assign();
        }

        private void btnDecrement_Click(object sender, EventArgs e)
        {
            number--;
            Assign();
        }
    }
}
