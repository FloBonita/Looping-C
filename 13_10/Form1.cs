using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            
           lstNumbers.Items.Clear();
          
            int i;
            for (i = 0; i <= 100; i++)
             {
              lstNumbers.Items.Add(i);
             }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
            int i = 1;
            while (i <= 100)
            {
            lstNumbers.Items.Add(i);
            i++;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
            int i = 1;
            do
            {
             lstNumbers.Items.Add(i);
             i++;
             } while (i <= 100) ;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstNumbers.Items.Clear();
        }
    }
}
