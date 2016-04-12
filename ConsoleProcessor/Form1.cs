using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConsoleProcessor
{
    public partial class Form1 : Form
    {
        Process p = new Process();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "..\\..\\..\\ConsoleStdout\\bin\\Debug\\ConsoleStdout.exe";
            info.UseShellExecute = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;

            p.StartInfo = info;

            p.OutputDataReceived += new DataReceivedEventHandler(MyProcOutputHandler);
            p.Start();

            p.BeginOutputReadLine();
        }

        private void MyProcOutputHandler(object sendingProcess,
            DataReceivedEventArgs outLine)
        {
            // Collect the sort command output. 
            if (!String.IsNullOrEmpty(outLine.Data))
            {
                if (outLine.Data.EndsWith("m"))
                {
                    Debug.Write("*");
                }
                else
                {
                    Debug.Write("-");
                }
                Debug.WriteLine(outLine.Data);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Kill();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            p.Kill();
        }
    }
}
