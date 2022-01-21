using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Titanfall2_SkinTool
{
    public partial class ProgressForm : Form
    {

        System.Resources.ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        private int TotalEntries = 0, Entries = 0;
        bool isClosing = false;

        public ProgressForm(int totalEntries,string title)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            TotalEntries = totalEntries;
            this.progressBar.Maximum= (int)totalEntries;
            switch (title)
            {
                case "Download":
                    TitleLabel.Text = rm.GetString("Downloading");
                    ProgressBarText.Text = rm.GetString("ProgressBarText");
                    break;
                case "SkinPack":
                    TitleLabel.Text = rm.GetString("GeneratingSkinPack");
                    ProgressBarText.Text = rm.GetString("ProgressBarText");
                    break;
            }
        }

        private void ProgressMessage_Load(object sender, EventArgs e)
        {
            
        }

        public void AdvanceEntry(int number)
        {
            Entries= number;

            Console.WriteLine("TestEntries:" + Entries);
            Console.WriteLine("Testnumber:" + number);
            Console.WriteLine("Test:"+ TotalEntries);

            Action SetProgress = delegate { progressBar.Value = Entries; };
            Action Display= delegate { ProgressBarText.Text = rm.GetString("ProgressBarText") + ((int)Math.Round((double)Entries * 100 / (double)TotalEntries, 2)).ToString() + "%"; };

            progressBar.Invoke(SetProgress);
            ProgressBarText.Invoke(Display);
           
            Action CloseForm = delegate { this.Close(); };
            
            if (Entries == TotalEntries)
            {
                Thread.Sleep(500);
                this.Invoke(CloseForm);
            }
        }

        private void ProgressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;
        }

        public void ForceClose()
        {
            if (isClosing == true) return;
            
            Action CloseForm = delegate { this.Close(); };
            Thread.Sleep(500);
            this.Invoke(CloseForm);
        }


    }
}
