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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlRecLbl_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pnlRecLbl, "Click to copy to clipboard");
        }

        private void pnlRecLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetText(lblArea.Text + "\n" + lblperi.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAreaPeri_Click(object sender, EventArgs e)
        {
            // 5 => "5" => 5 and 5 >0 -- lbox T/F
            // -8 => "-8" => -8 AND  -8>0 -- f
            var lBox = Double.TryParse(txtLength.Text, out double L) && L > 0;
            var wBox = Double.TryParse(txtWidth.Text, out double W) && W > 0;
            if (lBox && wBox)
            {
                int round = (int)nmrRec.Value;
                lblperi.Text = $"Perimeter: {Math.Round(2 * (L + W), round)}";
                lblArea.Text = $"Area: {Math.Round(L * W, round)}";
            }
            else
            {
                MessageBox.Show("Input value is not numeric or number is less than 0");
            }

        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            Notes nt = new Notes();
            nt.Show();
        }

       
        private void btn_CylVol_Click_1(object sender, EventArgs e)
        {

            var Height = double.TryParse(txtHeight.Text, out double H) && H >= 0;
            var radius = double.TryParse(txtRadius.Text, out double R) && R >= 0;
            if (Height && radius)
            {
                int round = (int)nmrCyl.Value;
                lblVolume.Text = $"Volume: {Math.Round(Math.PI * R * R * H, round)}";
            }
            else
                MessageBox.Show("Input value is not numeric or number is less than 0.");
        }

        private void pnlCylLbl_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pnlCylLbl, "Click to copy to clipboard");
        }

        private void pnlCylLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                Clipboard.SetText(lblVolume.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPar_AreaPeri_Click(object sender, EventArgs e)
        {

            var bBox = Double.TryParse(txtBase.Text, out double B) && B > 0;
            var hBox = Double.TryParse(txtParHeight.Text, out double H) && H > 0;
            if (bBox && hBox)
            {
                int round = (int)nmrPar.Value;
                lblPar_peri.Text = $"Perimeter: {Math.Round(2 * (B + H), round)}";
                lblPar_area.Text = $"Area: {Math.Round(B * H, round)}";
            }
            else
            {
                MessageBox.Show("Input value is not numeric or number is less than 0");
            }
        }

        private void pnlParLbl_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            try
            {
                Clipboard.SetText(lblPar_peri.Text + "\n" + lblPar_area.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pnlParLbl_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(pnlParLbl, "Click to copy to clipboard");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    pnlCyl.Visible = false;
                    pnlRec.Visible = true;
                    pnlPar.Visible = false;
                    break;

                case 1:
                    pnlCyl.Visible = true;
                    pnlRec.Visible = false;
                    pnlPar.Visible = false;
                    break;

                case 2:
                    pnlCyl.Visible = false;
                    pnlRec.Visible = false;
                    pnlPar.Visible = true;
                    break;

            }
        }
    }
}
