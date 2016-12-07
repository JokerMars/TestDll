using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TestDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txtbox_one.Text);
                int b = Convert.ToInt32(txtbox_two.Text);

                txtbox_product.Text = add(a, b).ToString();
            }
            catch(Exception)
            {

            }
        }

        [DllImport("Dll.dll", EntryPoint = "add", ExactSpelling = false, CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);
    }

   
}
