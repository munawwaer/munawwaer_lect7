using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{

  public  class Class3:Form
    {
        public TextBox txtone, txttow, txtthree;
        public Label numone, numtow, result, equle, option;
        public Button butresult, butclose;
        public Class3()
        {
            //    textbox
            txtone = new TextBox();
            txttow = new TextBox();
            txtthree = new TextBox();
            //   label
            numone = new Label();
            numtow = new Label();
            result = new Label();
            equle = new Label();
            option = new Label();
            //button
            butclose = new Button();
            butresult = new Button();
            // text 
            butresult.Click += btnResult_click;
            butclose.Click += butclose_click;

            numone.Text = "العدد الاول";
            numone.Location = new Point(360,40);
            numone.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);

            numtow.Location = new Point(185,40);
            numtow.Text = "العدد الثاني";
            numtow.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);

            equle.Location = new Point(140,100);
            equle.Size = new Size(20, 40);
            equle.Text = "=";
            equle.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);

            result.Location = new Point(30,40);
            result.Text = "Result";
            result.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);

            option.Location = new Point(300,100);
            option.Size = new Size(20, 40);
            option.Text = "";
            option.Font = new Font(Font.FontFamily, 11, FontStyle.Bold);

            txtone.Location = new Point(340,100);
            numone.Size = new Size(150,50);
            

            txttow.Location = new Point(180,100);
            txttow.Size = new Size(100, 50);

            txtthree.Location = new Point(20,100);
            txtthree.Size = new Size(100,50);

            butclose.Location = new Point(20, 170);
            butclose.Text = "Exit";

            butresult.Location = new Point(380,170);
            butresult.Text = "process";

        }
        public void controlsAddTooles(Form f)
        {
         
            f.Controls.Add(numone);
            f.Controls.Add(numtow);
            f.Controls.Add(butresult);
            f.Controls.Add(butclose);
            f.Controls.Add(option);
            f.Controls.Add(equle);
            f.Controls.Add(txtone);
            f.Controls.Add(txttow);
            f.Controls.Add(txtthree);
            f.Controls.Add(result);
        }
        public void opreations(string op)
        {
            option.Text = op;
        }
        void btnResult_click(object sender,EventArgs e)
        {
            if (txtone.Text.Trim() != "")
            {
                if (txttow.Text.Trim() != "")
                {
                    switch (option.Text)
                    {
                        case "+":
                            txtthree.Text = ((int.Parse(txtone.Text)) + (int.Parse(txttow.Text))).ToString();
                            break;
                        case "-":
                            txtthree.Text = (Convert.ToInt32(txtone.Text) - Convert.ToInt32(txttow.Text)).ToString();
                            break;
                        case "/":
                            if (txttow.Text != "0")
                            {
                                txtthree.Text = (Convert.ToDouble(txtone.Text) / Convert.ToDouble(txttow.Text)).ToString();
                            }
                            else
                            {
                                MessageBox.Show("the number Zero ");
                                txttow.Text = "";
                                txttow.Focus();
                            }
                            break;
                        case "*":
                            txtthree.Text = (Convert.ToInt32(txtone.Text) * Convert.ToInt32(txttow.Text)).ToString();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("العدد الثاني غير صالح");
                    txttow.Focus();
                }
            }
            else
            {
                MessageBox.Show("العدد الاول غير صالح");
                txtone.Focus();
            }
        }
        void butclose_click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
