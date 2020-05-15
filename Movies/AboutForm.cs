using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();

        }

        private void aboutFormCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Select(0, 25);
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.Select(27, 260);
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 12, FontStyle.Italic);
            richTextBox1.SelectionColor = Color.Blue;
            richTextBox1.Select(289, 300);
            richTextBox1.SelectionFont = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            richTextBox1.Select(350, 351);

        }
    }
}
