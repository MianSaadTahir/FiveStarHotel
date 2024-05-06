using HostelDll.DlDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelDll.Bl;
using HostelDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class LeaveRoom : Form
    {
        private string ConnectionString = @"Data Source=ALI-HAMZA;Initial Catalog=FiveStarHostels;Integrated Security=True;";
        public event EventHandler LeaveConfirmed;
         
        private string Name;
        private StudentMenu studentMenu;
        private RtMenu RtMenu;
        public LeaveRoom()
        {
            InitializeComponent();
        }
        public LeaveRoom(string name,StudentMenu studentMenu) : this() 
        {
            this.Name = name;
            this.studentMenu = studentMenu;
           
            
        }
        public LeaveRoom(string name, RtMenu rtMenu) : this()
        {
            this.Name = name;
            this.RtMenu = rtMenu;


        }

        private void leaveRoomBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void leaveRoomBtn2_Click(object sender, EventArgs e)
        {
            int roomNo = StudentDb.GetRoomNoOfSelectedStudent(Name, ConnectionString);
            string hostel = StudentDb.GetHostelOfSelectedStudent(Name, ConnectionString);
            ComplainDb.DeleteComplainbyStudentName(Name, ConnectionString);
            StudentDb.DeleteStudent( Name, ConnectionString);
            DwellerDB.DeleteDweller(Name, ConnectionString);
            RtDb.DeleteRt( Name, ConnectionString);
            RoomDb.UpdateRoomStatusVacant(roomNo, hostel, ConnectionString);
            
                MessageBox.Show("You left room.");
            Hide();
            OnLeaveConfirmed(EventArgs.Empty);
            MainPage mainpage = new MainPage();
            mainpage.Show();





        }
        protected virtual void OnLeaveConfirmed(EventArgs e)
        {
            LeaveConfirmed?.Invoke(this, e);
        }
        private void LeaveRoom_Load(object sender, EventArgs e)
        {

        }

        private void leaveRoomlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
