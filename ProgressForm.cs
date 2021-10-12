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

        public ProgressForm(int totalEntries)
        {
            InitializeComponent();
            TotalEntries = totalEntries;
        }

        private void ProgressMessage_Load(object sender, EventArgs e)
        {
            generatingLabel.Text = rm.GetString("GeneratingSkinPack");
        }

        public void AdvanceEntry()
        {
            Entries++;
            Action SetProgress = delegate { progressBar.Value = Entries * 100 / TotalEntries; };
            progressBar.Invoke(SetProgress);

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
