using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace trydll
{
    public partial class Form1 : Form
    {
        [DllImport("F:\\code\\c#\\trydll\\Release\\dlltest.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);
        [DllImport("F:\\code\\c#\\trydll\\Release\\dlltest.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void lex();
        public Form1()
        {
          // 
            InitializeComponent();
        }
       
        private void 确认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            richTextBox1.LoadFile("F:\\shuchu.txt", RichTextBoxStreamType.PlainText);
        }

        private void 输出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lex();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            sum = add(2,3);
            if (sum == 5)
            {
                label1.Text = "ok";
            }
            else
            {
                label1.Text = "failed";
            }
        }
    }
}
