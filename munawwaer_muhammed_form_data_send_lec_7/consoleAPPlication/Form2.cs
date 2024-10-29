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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string staticvarebel = "";
        public Form2(string name)
        {
            InitializeComponent();
            this.Text = name;
        }

        Form1 objects;
        public Form2(Form1 form11)
        {
            InitializeComponent();

           txtform12.Text=form11.getname();
           txtform12.Text = form11.textform1.Text;
           objects = form11;
        }
        public Form2(ListBox mylistbox)
        {
            InitializeComponent();
            listBox1 = mylistbox;
        }
        public void setvalue(string name)
        {
            txtform12.Text = name;
        }
        public string getvalue()
        {
            return txtform12.Text;
        }
        static Form2 n = new Form2();
        public static void colores()
        {
                Random r = new Random();
                n.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255),
                r.Next(0, 255));
                n.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(txtform12.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            objects.Updatename(getvalue());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
       
       
    }
}
