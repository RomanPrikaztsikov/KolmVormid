using System;
using System.Windows.Forms;

namespace KolmVormid
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Vali Vorm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vorm1 v1 = new Vorm1();
            v1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vorm2 v2 = new Vorm2();
            v2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            matchingGame v3 = new matchingGame();
            v3.ShowDialog();
        }
    }
}
