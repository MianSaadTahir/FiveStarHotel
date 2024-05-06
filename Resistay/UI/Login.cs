using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using HostelDll.Bl;
using HostelDll.DlDb;
using HostelDll.DLInterfaces;
using HostelDll.Utilities;

namespace Resistay.UI
{
    public partial class Login : Form
    {
        private string ConnectionString = @"Data Source=ALI-HAMZA;Initial Catalog=FiveStarHostels;Integrated Security=True;";
          
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage Main = new MainPage();
            Main.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignOnBtn_Click(object sender, EventArgs e)
        {
            Dwellers dwellers = DwellerDB.IsDwellerFound(Username.Text, Password.Text, ConnectionString);
             if (dwellers != null) {
                
                if (dwellers.GetRole() == "warden")
                {
                   
                    this.Hide();
                     AdminMenu adminmenu = new AdminMenu(dwellers);

                    adminmenu.Show();
                }
                else if (dwellers.GetRole() == "student")
                {
                    Student student = StudentDb.GetStudentByName(dwellers.GetName(), ConnectionString);

                     
                        this.Hide();
                        StudentMenu studentmenu = new StudentMenu(student);
                        studentmenu.Show();
                    
                     

                }
                else if (dwellers.GetRole() == "rt")
                {
                    RT rt = RtDb.GetRtByName(dwellers.GetName(), ConnectionString);

                     
                        this.Hide();
                        RtMenu rtmenu = new RtMenu(rt);
                        rtmenu.Show();
                     

                }


            }
            else MessageBox.Show("You Entered Non Creditional Data");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
