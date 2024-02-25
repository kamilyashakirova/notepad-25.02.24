using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace notebook
{
    public partial class Form1 : Form
    {
        private string of;
        public string fname;
        public bool ischanged;
        public int size = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;
        public System.Drawing.Color fc = System.Drawing.Color.Black;
        public FontSettings fset;
        public Form1()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            fname = "";
            ischanged = false;
            UpdateTitle();
        }
        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fset = new FontSettings();
            fset.Show();
            ischanged = true;
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "all (*.*) |*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(ofd.FileName);
                of = ofd.FileName;
            }
        }
        public void SaveFile(string filename)
        {
            ischanged = true;
            SaveFileDialog sf = new SaveFileDialog();
            if (filename == "")
            {
                if (sf.ShowDialog() == DialogResult.OK) 
                { 
                    filename = sf.FileName;
                }
            }
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.Write(richTextBox1.Text);
                fname = filename;
                ischanged = false;
            }
            catch
            {
                MessageBox.Show("error");
            }
            UpdateTitle();
        }
        public void FormClosing(string fname)
        {
            if (ischanged == true)
            {
                DialogResult message = MessageBox.Show("Сохранить текущий документ перед выходом?", "Выход из программы", MessageBoxButtons.YesNoCancel);
                if (message == DialogResult.Yes)
                {
                    if (fname != "")
                    {
                        SaveFile(fname);
                        Application.Exit();
                    }
                    else if (fname == "")
                    {
                        SaveFile(fname);
                        Application.Exit();
                    }
                }
                else if (message == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(fname);
            ischanged = false;
        }
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pdoc = new PrintDocument();
            pdoc.PrintPage += PrintPages;
            PrintDialog pD = new PrintDialog();
            pD.Document = pdoc;
            if (pD.ShowDialog() == DialogResult.OK) 
            { 
                pD.Document.Print();
            }
        }
        public void PrintPages(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 0, 0);
        }
        public void CreateNewDoc(object sender, EventArgs e)
        {

        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            fname = "";
        }
        public void UpdateTitle()
        {
            if (fname != "")
            {
                this.Text = fname + " - Notepad";
            }
            else
            {
                this.Text = "Безымянный - Notepad";
            }
        }
        public void CopyText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }
        public void CutText()
        {
            Clipboard.SetText(richTextBox1.SelectedText);
            richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
        }
        public void PasteText()
        {
            richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.SelectionStart + 1 ) + Clipboard.GetText() + richTextBox1.Text.Substring(richTextBox1.SelectionStart, richTextBox1.SelectionLength - richTextBox1.SelectionStart);
        }
        private void OnCopyText(object sender, EventArgs e)
        {
            CopyText();
        }
        private void OnCutText(object sender, EventArgs e)
        {
            CutText();
        }
        private void OnPasteText(object sender, EventArgs e)
        {
            PasteText();
        }
        private void Exit(object sender, EventArgs e)
        {
            FormClosing(fname);
            Application.Exit();
        }

        private void AboutProgram(object sender, EventArgs e)
        {

            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void OnFocus(object sender, EventArgs e)
        {
            ischanged = true;
            if (fset != null)
            {
                size = fset.size;
                fs = fset.fs;
                fc = fset.fc;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, size, fs);
                richTextBox1.ForeColor = fc;
                fset.Close();
            }
        }
    }
}
