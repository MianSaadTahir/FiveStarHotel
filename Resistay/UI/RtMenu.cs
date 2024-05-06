using HostelDll.DlDb;
using HostelDll.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Resistay.UI
{
    public partial class RtMenu : Form
    {
        private string ConnectionString = @"Data Source=ALI-HAMZA;Initial Catalog=FiveStarHostels;Integrated Security=True;";

        RT Rt;
        public RtMenu()
        {
            InitializeComponent();
        }
        public RtMenu(RT rt):this()
        {
            this.Rt = rt;
        }

        private void RtMenu_Load(object sender, EventArgs e)
        {


        }
        private void LeaveRoom_LeaveConfirmed(object sender, EventArgs e)
        {
            this.Close(); // Close the StudentMenu form
            ((LeaveRoom)sender).Close(); // Close the LeaveRoom form
        }
        private void leavehostelbtn_Click(object sender, EventArgs e)
        {
            LeaveRoom leaveRoom = new LeaveRoom(Rt.GetName(), this);
            leaveRoom.LeaveConfirmed += LeaveRoom_LeaveConfirmed;
            leaveRoom.Show();
        }

         

        private void RulesBtn_Click(object sender, EventArgs e)
        {
            Ruleform ruleform = new Ruleform();
            ruleform.Show();
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogOut logOutForm = new LogOut();
            logOutForm.LoggedOut += LogOutForm_LoggedOut;
            logOutForm.Show();
        }
        private void LogOutForm_LoggedOut(object sender, EventArgs e)
        {
            this.Close(); 
            ((LogOut)sender).Close(); 
        }

         

        private void hosteDetailbtn_Click(object sender, EventArgs e)
        {
            HostelSpecifiedStudents hostelspecifiedstudents = new HostelSpecifiedStudents(Rt);
            hostelspecifiedstudents.Show();
        }

        private void ComplainsBtn_Click(object sender, EventArgs e)
        {
            CheckComplain checkComplain = new CheckComplain(Rt);
            checkComplain.Show();
        }
    }
}
