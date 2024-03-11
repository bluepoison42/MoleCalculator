using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 checklist
basic function
    calculate
    sig
 */
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int ponum = 0;
        public Form1()
        {
            InitializeComponent();
            
    }
        private void ChangeAllColors(Control control,Color newForeColor,Color newBackColor)//optional cool function, change theme
        {
            control.ForeColor = newForeColor; 
            control.BackColor = newBackColor; 
            foreach (Control childControl in control.Controls)
            {
                ChangeAllColors(childControl, newForeColor, newBackColor);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)// improve display
        {
            Output.Text = "";
            int inp1 = listBox1.SelectedIndex;
            if (inp1 == 0)
            {
                label7.Text = "Mol";
                label9.Text = "";
                Numin2.Visible = false;
            }
            if (inp1 == 1)
            {
                label7.Text = "";
                label9.Text = "X10^";
                Numin2.DecimalPlaces = 0;
                Numin2.Visible = true;
            }
            if (inp1 == 2)
            {
                label7.Text = "L";
                label9.Text = "";
                Numin2.Visible = false;
            }
            if (inp1 == 3)
            {
                label7.Text = "g";
                label9.Text = "MM";
                Numin2.DecimalPlaces = 2;
                Numin2.Visible = true;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Scinot (ref double num1, ref int num2)// num1 cofficient num2 exponent
        {
            if (num1 >= 10)
            {
                while (num1 >= 10)
                {
                    num1 /= 10;
                    num2++;
                }
            }
            if (num1 <= 1)
            {
                while (num1 <= 1)
                {
                    num1 *= 10;
                    num2--;
                }
            }
            //return 0;
        }
        public double Mol2P(double mol)
        {
            ponum += 22;
            return mol * 6.02;
        }
        public double P2Mol(double p)
        {
            ponum -= 22;
            return p/6.02;
        }
        public double Mol2Gas(double mol)
        {
            return mol*22.4;
        }
        public double Gas2Mol(double gas)
        {
            return gas/22.4;
        }
        public double Mol2Mas(double mol, double MM)
        {
            return mol * MM;
        }
        public double Mas2Mol(double mas, double MM)
        {
            return mas/MM;
        }
        private void button1_Click(object sender, EventArgs e)//calculate
        {
            ponum = 1;
            double mol=0,pnum,vol,mas;
            double inpnum1 = (double)Numin.Value;
            double inpnum2 = (double)Numin2.Value;
            double inpnum3 = (double)Numin3.Value;
            int inp1 = listBox1.SelectedIndex;
            int inp2 = listBox2.SelectedIndex;
            //if (inp == "0") label7.Text = "Mol";

            if (inp2 == -1 || inp1 == -1 || inpnum1 == 0 || (Numin2.Visible == true && inpnum2==0)) 
                Output.Text = "ERROR";
            else
            {
                if (inp1 == 0)
                {
                    mol = inpnum1;
                }
                if (inp1 == 1)
                {
                    ponum = (int)inpnum2;
                    mol = P2Mol(inpnum1);
                    if(inp2 !=1 )mol *= Math.Pow(10, inpnum2 - 23);
                }
                if (inp1 == 2)
                {
                    mol = Gas2Mol(inpnum1);
                }
                if (inp1 == 3)
                {
                    mol = Mas2Mol(inpnum1,inpnum2);
                }
                vol =Mol2Gas(mol);
                pnum = Mol2P(mol);
                mas=Mol2Mas(mol,inpnum3);
                mol = Math.Round(mol, 5);
                //pnum = Math.Round(mol, 5);
                if (inp2 == 0)
                {
                    Output.Text = mol.ToString();
                    //Output.Text = mol.ToString();
                    //label8.Text = "X10^" + ponum+" Mol";
                }
                if (inp2 == 1)
                {
                    Scinot(ref pnum, ref ponum);
                    Output.Text = pnum.ToString();
                    label8.Text = "X10^"+ponum;
                }
                if (inp2 == 2)
                {
                    Output.Text = vol.ToString();
                }
                if (inp2 == 3)
                {
                    Output.Text = mas.ToString();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)//change theme
        {
            int inp3 = listBox3.SelectedIndex;
            if (inp3 == 0)
            {
                ChangeAllColors(this,Color.Black,Color.White);
                
            }
            if (inp3 == 1)
            {
                ChangeAllColors(this,Color.White,Color.Black);
                
            }
            if (inp3 == 2)
            {
                ChangeAllColors(this, Color.LimeGreen,Color.Black);
                
            }


        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Numin_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Output.Text = "";
            int inp2 = listBox2.SelectedIndex;//display unit
            if (inp2 == 0) label8.Text = "Mol";
            if (inp2 == 1) label8.Text = "X10^";
            if (inp2 == 2) label8.Text = "L";
            if (inp2 == 3) {
                label6.Visible = true;
                //Numin2.DecimalPlaces = 2;
                Numin3.Visible = true;
                label8.Text = "g";
            }
            else
            {
                label6.Visible = false;
                //Numin2.DecimalPlaces = 2;
                Numin3.Visible = false;
            }
        }

        private void Output_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
