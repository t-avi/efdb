using Domen.Concrete;
using Domen.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPresentation
{
    public partial class Form1 : Form
    {
        EfUserRepository rep;
        public Form1()
        {
            InitializeComponent();
            rep = new EfUserRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = rep.AddUser(new User
            {
                FirstName = textBox3.Text,
                LastName = textBox4.Text,
                Login = textBox1.Text,
                Password = textBox2.Text,
                //MailAdress = textBox5.Text
            });

            label1.Text = id.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rep.DelUser(Convert.ToInt32(textBox6.Text));
        }
    }
}
