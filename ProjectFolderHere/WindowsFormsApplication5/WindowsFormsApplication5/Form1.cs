using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uxFindPrimesBtn_Click(object sender, EventArgs e)
        {
            if(uxInputBox.Text.Length > 0)
            {
                SeiveList sl = new SeiveList(int.Parse(uxInputBox.Text));
                sl.FindPrimes();
                //uxOutputBox.Text = sl.output.ToString();
                StringBuilder build = new StringBuilder();
                foreach (int num in sl)
                {
                    build.Append(num + " ");
                }
                uxOutputBox.Text = build.ToString();
            }
        }
    }
}
