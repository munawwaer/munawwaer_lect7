using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Database
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }
        public string getname()
        { return textform1.Text; }
        public void Updatename(string name)
        {
            textform1.Text = name;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //show
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
        }
        //show constractor
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2("التعامل مع الواجهات المتعدده");
            f2.ShowDialog();
            f2.Show();
        }
        //show with function
        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f3 = new Form2();
            f3.setvalue(textform1.Text);
            f3.Show();
           
        }
        //show with static
        private void button9_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            Form2.staticvarebel = textform1.Text;
            MessageBox.Show(Form2.staticvarebel);
          //  f.Show();
        }
        //show with real objects
        private void button10_Click(object sender, EventArgs e)
        {
            new Form2(textform1.Text).Show();
        }
        //shoe send listbox
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(listBox1);
            listBox1.Items.Add(listBox1);
            f.Show();
       }
        //show form
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f=new Form2(this);
            f.Show();
        }
        //show onse
        Form2 formons = new Form2();
        private void button8_Click(object sender, EventArgs e)
        {
            formons.Show();
        }
        //show form objects
        Form2 formobjects;
        private void button7_Click(object sender, EventArgs e)
        {
            if (formobjects == null || formobjects.IsDisposed)
            {
                formobjects = new Form2();
                formobjects.txtform12.Text = textform1.Text;
                formobjects.Show();
            }
            else
                formobjects.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //midiver
        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.txtform12.Text = textform1.Text;
            f.Show();
        }
        //function  that works to change th background of the form2
        private void button12_Click(object sender, EventArgs e)
        {
            Form2.colores();
        }
      

    }
}
