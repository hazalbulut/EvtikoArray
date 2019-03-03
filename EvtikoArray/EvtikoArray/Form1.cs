using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvtikoArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] A = { 3, 6, 9, 12 };
        int i;
        int x;
        private void button1_Click(object sender, EventArgs e)
        {
            int[] B = new int[A.Length];
            for (i = 0; i < A.Length; i++)
            {
                int carpim = 1;
                for (x = 0; x < A.Length; x++)
                {
                    carpim = carpim * A[x];
                }
                B[i] = carpim / A[i];
                listBox1.Items.Add("B[" + i + "]= " + B[i]);
            }
        }
    }
}
