using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyIndex
{
    public partial class frmBodyIndex : Form
    {
        public frmBodyIndex()
        {
            InitializeComponent();
            pbResult.SizeMode = PictureBoxSizeMode.Zoom;
            pbResult.ImageLocation = Application.StartupPath + "//images//start.png";
        }

        double height = 0;
        double weight = 0;
        double result = 0;

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (txtHeight.Text == "")
            {

                MessageBox.Show("Lütfen Boyunuzu Giriniz .", "Uyarı", MessageBoxButtons.OK);
                txtHeight.Focus();
            }
            else if (txtWeight.Text == "")
            {

                MessageBox.Show("Lütfen Boyunuzu Giriniz .", "Uyarı", MessageBoxButtons.OK);
                txtWeight.Focus();
            }
            else
            {
                height = Convert.ToDouble(txtHeight.Text);
                weight = Convert.ToDouble(txtWeight.Text);
                result = weight / (height * height);
                lblResult.Text = Convert.ToString(result);
                ShowResult(result);

            }
        }


        void ShowResult(double result)
        {

            if (result <= 18.5)
            {
                pbResult.ImageLocation = Application.StartupPath + "//images//blue.png";
            }
            else if (18.5 < result && result <= 24.9)
            {
                pbResult.ImageLocation = Application.StartupPath + "//images//green.png";
            }
            else if (24.9 < result && result <= 29.9)
            {
                pbResult.ImageLocation = Application.StartupPath + "//images//yellow.png";
            }
            else if (29.9 < result && result <= 39.9)
            {
                pbResult.ImageLocation = Application.StartupPath + "//images//red.png";
            }
        }

        private void pbHelp_Click(object sender, EventArgs e)
        {
            Form help = new Help() ;
            help.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtHeight.Text = "";
            txtWeight.Text = "";
            height = 0;
            weight = 0;
            result = 0;
            pbResult.ImageLocation = Application.StartupPath + "//images//start.png";
        }
    }
}
