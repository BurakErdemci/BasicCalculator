using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {

        bool optDurum = false;
        double result = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumberEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || optDurum)

                txtResult.Clear();
            optDurum = false;


            Button btn = (Button)sender;
            txtResult.Text += btn.Text;

        }

        private void OptHesap(object sender, EventArgs e)
        {
            optDurum = true;

            Button btn = (Button)sender;
            string newOpt = btn.Text;
            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOpt;

            switch (opt)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;



            }

            result = double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            opt = newOpt;



        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            opt = "";
            result = 0;
            optDurum = false;
        }

        private void btnEqualize_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;



            }

            result = double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            opt = "";


        }

        private void btnComma_Click(object sender, EventArgs e)
        {


            if (txtResult.Text == "0")
            {
                txtResult.Text = "0";

            }


            else if (optDurum)

            {
                txtResult.Text = "0";
            }

            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            optDurum = false;
        }
    }
}
