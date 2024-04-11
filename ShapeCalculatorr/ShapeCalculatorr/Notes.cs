using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShapeCalculatorr
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog
            {
                Filter = "RTF Files|*.rtf"
            };
            try
            {
                if (sf.ShowDialog() == DialogResult.OK)
                    richTextBox1.SaveFile(sf.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                Filter = "RTF Files|*.rtf"
            };
            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                    richTextBox1.LoadFile(of.FileName, RichTextBoxStreamType.RichText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
