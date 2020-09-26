using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            label2.Text = Resource1.FullName;
            button1.Text = Resource1.Add;
            listBox1.DataSource = users;
            listBox1.ValueMember = "ID";
            listBox1.DisplayMember = "FullName";
            button2.Text = Resource1.Write;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.FullName = textBox2.Text;
            users.Add(user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "users.txt";

            sfd.FileOk += Sfd_FileOk;
            sfd.ShowDialog();
        }

        private void Sfd_FileOk(object sender, CancelEventArgs e)

        {

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter sw = new StreamWriter(Path.Combine(docPath, "users.txt")))
            {
                foreach (var u in users)
                {
                    string str = u.ID + " ; " + u.FullName;
                    sw.WriteLine(str);

                }
                sw.Close();

            }

        }
    }
}
