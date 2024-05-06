 using HostelDll.Bl;
using HostelDll.DlDb;
using HostelDll.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class AllotmentofRoom : Form
    {
        private string ConnectionString = @"Data Source=ALI-HAMZA;Initial Catalog=FiveStarHostels;Integrated Security=True;";
         
        public AllotmentofRoom()
        {
            InitializeComponent();
            LoadAlloatedStudents();
            
            AllotStudentCombo.SelectedIndexChanged += AllotStudentCombo_SelectedIndexChanged;
            AllotHostelCombo.SelectedIndexChanged += AllotHostelCombo_SelectedIndexChanged;
            LoadAlloatedStudents();
        }

        private void LoadAlloatedStudents()
        {
            List<Student> AllotedStudentlist = StudentDb.GetStudentsWithAllotedStatus(ConnectionString);
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Cnic", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Hostel", typeof(string));
            dataTable.Columns.Add("RoomNumber", typeof(int));

            
            for (int i = 0; i < AllotedStudentlist.Count; i++)
            {
                dataTable.Rows.Add(AllotedStudentlist[i].GetName(), AllotedStudentlist[i].GetGender(), AllotedStudentlist[i].GetCnic(), AllotedStudentlist[i].GetAge(), AllotedStudentlist[i].GetHostel().GetHostelName(), AllotedStudentlist[i].GetRoom().GetNumber());
            }

            AllotedStudenrGridView.DataSource = dataTable;

           
            List<string> unallotedStudents = StudentDb.GetNameOfUnallotedStudents(ConnectionString);
            AllotStudentCombo.DataSource = unallotedStudents;
        }

        private void AllotBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(AllotStudentCombo.Text))
            {
                StudentDb.UpdateStudentStatus(AllotStudentCombo.Text, int.Parse(AllotRoomNoCombo.Text), AllotHostelCombo.Text, ConnectionString);
                DwellerDB.UpdateDwellerHostelName(AllotStudentCombo.Text, AllotHostelCombo.Text, ConnectionString);
                HostelDb.GetHostelByName(AllotHostelCombo.Text, ConnectionString).AddStudents(StudentDb.GetStudentByName(AllotStudentCombo.Text, ConnectionString));

                int roomNo = StudentDb.GetRoomNoOfSelectedStudent(AllotStudentCombo.Text, ConnectionString);

                RoomDb.UpdateRoomStatusAlloted(roomNo,AllotHostelCombo.Text, ConnectionString);
                MessageBox.Show("Allotted Successfully");
                LoadAlloatedStudents();
            }
            else
            {
                MessageBox.Show("Failed to Allot");
            }
        }

        private void AllotStudentCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllotStudentCombo.SelectedItem != null)
            {
                // Update the Hostel combo box text based on the selected Student
                string selectedStudent = AllotStudentCombo.SelectedItem.ToString();
                string gender = DwellerDB.GetGenderOfSelectedPerson(selectedStudent, ConnectionString);
                List<string> availableHostels = HostelDb.GetHostelNamesByGender(gender, ConnectionString);
                if (availableHostels != null && availableHostels.Count > 0)
                {
                    AllotHostelCombo.DataSource = availableHostels;
                }
                else
                {
                    AllotHostelCombo.DataSource = null;
                }
            }
            else
            {
                AllotHostelCombo.DataSource = null;
                AllotRoomNoCombo.DataSource = null;
            }
        }

        private void AllotHostelCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AllotHostelCombo.SelectedItem != null)
            {
                
                string selectedHostel = AllotHostelCombo.SelectedItem.ToString();
                List<int> roomNumbers = RoomDb.GetRoomNumbersByHostelName(selectedHostel, ConnectionString);
                if (roomNumbers != null && roomNumbers.Count > 0)
                {
                    AllotRoomNoCombo.DataSource = roomNumbers;
                }
                else
                {
                    AllotRoomNoCombo.DataSource = null;
                }
            }
            else
            {
                AllotRoomNoCombo.DataSource = null;
            }
        }


        private void AllotmentofRoom_Load(object sender, EventArgs e)
        {
            
            LoadAlloatedStudents();
            AllotStudentCombo.SelectedIndexChanged += AllotStudentCombo_SelectedIndexChanged;
            AllotHostelCombo.SelectedIndexChanged += AllotHostelCombo_SelectedIndexChanged;
        }
        private void AllotRoomNoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide(); 
        }
    }
}

