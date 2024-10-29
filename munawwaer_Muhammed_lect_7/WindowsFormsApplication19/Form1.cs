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
    public partial class Form1 : Form
    {
        Button butsum = new Button(), butmult = new Button(), butdivide = new Button(), butsub = new Button();
        Class3 subform, mulform, dividform, sumform;
        
        public Form1()
        {
            InitializeComponent();
           
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(449, 200);
            //---
            butsum.Location =new Point(1,100);
            butsum.Size = new Size(94,35);
            butsum.Text = "جمع";
            butsum.Click += butsum_click;

            butsub.Location = new Point(butsum.Left+10+94,100);
            butsub.Size = new Size(94,35);
            butsub.Text = "طرح";
            butsub.Click += butsub_click;

            butmult.Location = new Point(butsub.Left+10+94,100);
            butmult.Size = new Size(94,35);
            butmult.Text = "ضرب";
            butmult.Click += multy_click;

            butdivide.Location = new Point(butmult.Left+10+94,100);
            butdivide.Size = new Size(94, 35);
            butdivide.Text = "قسمة";
            butdivide.Click += divid_click;

            this.Controls.Add(butsum);
            this.Controls.Add(butdivide);
            this.Controls.Add(butmult);
            this.Controls.Add(butsub);

           
        }
        void butsum_click(object sender, EventArgs e)
        {

            if (formisdisposed(sumform))
            {

                sumform = new Class3();
                sumform.Text = "sumform";
                sumform.Size = new Size(500, 250);
                sumform.BackColor = Color.Plum;
                sumform.opreations("+");
                sumform.controlsAddTooles(sumform);
                sumform.Show(this);
            }
            else
            {
                sumform.Show();
               sumform.Focus();
            }
        }
        void butsub_click(object sender, EventArgs e)
        {
            if (formisdisposed(subform))
            {
                subform = new Class3();
                subform.BackColor = Color.CadetBlue;
                subform.Text = "subform";
                subform.opreations("-");
                subform.controlsAddTooles(subform);
                subform.Size = new Size(500, 250);
                subform.Show(this);

            }
            else
            {
               
               // subform.Show();
                 subform.Focus();
            }
        }
        void divid_click(object sender, EventArgs e)
        {
            if (formisdisposed(dividform))
            {
                dividform = new Class3();
                dividform.Text = "dividform";
                dividform.BackColor = Color.BlueViolet;
                dividform.opreations("/");
                dividform.controlsAddTooles(dividform);
                dividform.Size = new Size(500, 250);
                dividform.Show(this);

            }
            else
            {
                // dividform.Show();
                 dividform.Focus();
            }
        }
        void multy_click(object sender, EventArgs e)
        {

            if (formisdisposed(mulform))
            {

                mulform = new Class3();
                mulform.Text = "mulform";
                mulform.Size = new Size(500, 250);
                mulform.BackColor = Color.Plum;
                mulform.opreations("*");
                mulform.controlsAddTooles(mulform);
                mulform.Show(this);
            }
            else
            {
                mulform.Show();
                mulform.Focus();
            }
        }

        bool formisdisposed(Class3 f)
        {
            return (f==null||f.IsDisposed);

        }

     

    }
}
