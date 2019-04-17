using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ExtensionFinder
{
    public partial class Form1 : Form
    {
        List<string> VirtualList = new List<string> { };
        private string path;
        private string fileOfExtension;

        private void FindFile(string inComingPath, string inComingExtension)
        {
            if (inComingPath.Equals(path))
            {
                foreach (var item in Directory.GetFiles(inComingPath))
                {
                    string onefectextension = Path.GetExtension(item);
                    if (onefectextension == inComingExtension || inComingExtension == "")
                    {
                        lstIncomingFile.Items.Add(item);
                    }
                }
            }
            foreach (var item in Directory.GetDirectories(inComingPath))
            {
                foreach (var item2 in Directory.GetFiles(item))
                {
                    string factextension = Path.GetExtension(item2);
                    if (factextension == inComingExtension || inComingExtension == "")
                    {
                        lstIncomingFile.Items.Add(item2);
                    }
                }
                FindFile(item, fileOfExtension);
                backgroundWorker1.ReportProgress(progressBar1.Value + ((90 - progressBar1.Value) / inComingPath.Length));
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;// it is to not get an error while using backgroundworker
            InitializeComponent();
        }
        // choose path
        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
                txtSelectedPath.Text = path;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////

        private void btnFind_Click(object sender, EventArgs e)
        {
            lblPercent.Text = "%";
            progressBar1.Value = 0;
            lstIncomingFile.Items.Clear();
            VirtualList.Clear();
            fileOfExtension = txtEnteredExtension.Text;
            if (path == null)
            {
                MessageBox.Show("You did not choose any paths! Please choose a path first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (fileOfExtension != "")
            {
                string firstletter = fileOfExtension.Substring(0, 1);// dot control
                if (firstletter != ".")// Check if you put dot
                {
                    MessageBox.Show("Don't forget to add 'dot' at the beginning!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    progressBar1.Visible = true;
                    lblPercent.Visible = true;
                    btnFind.Enabled = false;
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync(); // start backgroundworker
                    }
                }
            }
            else if (fileOfExtension == "")
            {
                DialogResult result = MessageBox.Show("You did not enter any exetensions! If you continue, all extensions will be searched.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    btnFind.Enabled = false;
                    if (!backgroundWorker1.IsBusy)
                    {
                        progressBar1.Visible = true;
                        lblPercent.Visible = true;
                        backgroundWorker1.RunWorkerAsync(); // start backgroundworker
                    }
                }

            }

        }
        /////////////////////////////////////////////////////////////////////////////////////////////////
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FindFile(path, fileOfExtension);
            AddToVirtualList();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblPercent.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnFind.Enabled = true;
            progressBar1.Value = 100;
            lblPercent.Text = "100%";
            progressBar1.Visible = false;
            lblPercent.Visible = false;
            if (lstIncomingFile.Items.Count == 0)
            {
                MessageBox.Show("A file matching the " + fileOfExtension + " extension was not found !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            barStaticItem1.Caption = "Total File: " + lstIncomingFile.Items.Count.ToString();

        }
        // To search 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searched = textBox1.Text;
            if (searched == "")
            {
                lstIncomingFile.Items.Clear();
                for (int i = 0; i < VirtualList.Count; i++)
                {
                    lstIncomingFile.Items.Add(VirtualList[i].ToString());
                }
                barStaticItem1.Caption = "Total File: " + lstIncomingFile.Items.Count.ToString();
            }
            else if (searched != "" && searched.Length >= 3 && VirtualList.Count != 0)
            {
                lstIncomingFile.Items.Clear();
                foreach (string item in VirtualList)
                {
                    if (item.ToLower().Contains(searched.ToLower()))
                    {
                        lstIncomingFile.Items.Add(item);
                    }
                }

                barStaticItem1.Caption = "Total File: " + lstIncomingFile.Items.Count.ToString();
            }

            barStaticItem1.Caption = "Total File: " + lstIncomingFile.Items.Count.ToString(); // if any records are not founded
        }

        private void btnFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                btnFind.PerformClick();
            }
        }
        private void AddToVirtualList()
        {
            for (int i = 0; i < lstIncomingFile.Items.Count; i++)
            {
                VirtualList.Add(lstIncomingFile.Items[i].ToString());
            }
        }
        // to open selected path in listbox
        private void lstIncomingFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string selectedpath = lstIncomingFile.SelectedItem.ToString();
            Process.Start(selectedpath);

        }
    }
}
