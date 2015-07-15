using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentOrganizarFinalVersion
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            List andrei = new List();
            andrei.Show();
            this.Hide();
        }
    }
}
