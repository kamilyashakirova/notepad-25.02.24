using System;
using System.Drawing;
using System.Windows.Forms;

namespace notebook
{
    public partial class FontSettings : Form
    {
        public int size = 0;
        public System.Drawing.FontStyle fs = FontStyle.Regular;
        public System.Drawing.Color fc = System.Drawing.Color.Black;
        public FontSettings()
        {
            InitializeComponent();
            stylebox.SelectedItem = stylebox.Items[0];
            sizebox.SelectedItem = sizebox.Items[0];
            colorbox.SelectedItem = colorbox.Items[0];
        }
        private void FontSettings_Load(object sender, EventArgs e)
        {

        }
        private void OnSize(object sender, EventArgs e)
        {
            examplefont.Font = new Font(examplefont.Font.FontFamily, int.Parse(sizebox.SelectedItem.ToString()));
            size = int.Parse(sizebox.SelectedItem.ToString());
        }
        private void OnStyle(object sender, EventArgs e)
        {
            switch (stylebox.SelectedItem.ToString())
            {
                case "обычный":
                    examplefont.Font = new Font(examplefont.Font.FontFamily, int.Parse(sizebox.SelectedItem.ToString()), FontStyle.Regular);
                    break;
                case "курсив":
                    examplefont.Font = new Font(examplefont.Font.FontFamily, int.Parse(sizebox.SelectedItem.ToString()), FontStyle.Italic);
                    break;
                case "полужирный":
                    examplefont.Font = new Font(examplefont.Font.FontFamily, int.Parse(sizebox.SelectedItem.ToString()), FontStyle.Bold);
                    break;
                case "подчёркивание":
                    examplefont.Font = new Font(examplefont.Font.FontFamily, int.Parse(sizebox.SelectedItem.ToString()), FontStyle.Underline);
                    break;
            }
            fs = examplefont.Font.Style;
        }
        private void OnColor(object sender, EventArgs e)
        {
            switch (colorbox.SelectedItem.ToString())
            {
                case "чёрный":
                    examplefont.ForeColor = System.Drawing.Color.Black;
                    break;
                case "синий":
                    examplefont.ForeColor = System.Drawing.Color.Blue;
                    break;
                case "зелёный":
                    examplefont.ForeColor = System.Drawing.Color.Green;
                    break;
                case "фиолетовый":
                    examplefont.ForeColor = System.Drawing.Color.Purple;
                    break;
                case "красный":
                    examplefont.ForeColor = System.Drawing.Color.Red;
                    break;
            }
            fc = examplefont.ForeColor;
        }
        private void font_Click(object sender, EventArgs e)
        {

        }
        private void fontchange_Click(object sender, EventArgs e)
        {

        }
        private void example_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
