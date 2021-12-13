using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Casio : Form
    {
        double fn, sn, result;
        int opstatus;
        public Casio()
        {
            InitializeComponent();
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
                txtresult.Clear();
            txtresult.Text = txtresult.Text + "9";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            txtresult.Clear();
            opstatus = 1;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            txtresult.Clear();
            opstatus = 2;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            txtresult.Clear();
            opstatus = 3;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            txtresult.Clear();
            opstatus = 4;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            sn = Convert.ToDouble(txtresult.Text);
            txtresult.Clear();
            switch (opstatus)
            {
                case 1: result = fn * sn;
                    break;
                case 2: result = fn - sn;
                    break;
                case 3: result = fn / sn;
                    break;
                case 4: result = fn + sn;
                    break;
                case 5: result = Math.Pow(fn, sn);
                    break;
                
             }
            txtresult.Text = result.ToString();
        }

        private void btnexp_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            txtresult.Clear();
            opstatus = 5; 
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            result = Math.Sin((Math.PI / 180) * fn);
            txtresult.Text = result.ToString();
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            result = Math.Cos((Math.PI / 180) * fn);
            txtresult.Text = result.ToString();
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            result = Math.Tan((Math.PI / 180) * fn);
            txtresult.Text = result.ToString();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            result = Math.Log(fn);
            txtresult.Text = result.ToString();
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            result = fn * fn;
            txtresult.Clear();
            txtresult.Text = result.ToString();
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            result = fn = sn = 0;
            txtresult.Clear();
        }

        private void btndec_Click(object sender, EventArgs e)
        {
            if (txtresult.Text == "0")
            txtresult.Clear();
            txtresult.Text = txtresult.Text + ".";
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            fn = Convert.ToDouble(txtresult.Text);
            result = Math.Sqrt(fn);
            txtresult.Clear();
            txtresult.Text = result.ToString();
        }
        

    }
}
