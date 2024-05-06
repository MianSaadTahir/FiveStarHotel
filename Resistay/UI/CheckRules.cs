using HostelDll.DlDb;
using HostelDll.DlFH;
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
    public partial class CheckRules : Form
    {
        //private string ConnectionString = @"Data Source=ALI-HAMZA;Initial Catalog=FiveStarHostels;Integrated Security=True;";

        IRule RulesDb;
        private string Path = "C:\\Users\\M JUNAID BASHIR\\Desktop\\OOP Project\\ProjectRules.txt";
        public CheckRules()
        {
            InitializeComponent();
            RulesDb = new RulesFH(Path);
            LoadRules();    
        }
        private void LoadRules()
        {
            List<HostelDll.Bl.Rule> Rulelist = RulesDb.GetAllRules();
            List<int> RuleIdList = RulesDb.GetRuleIds();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("RulesId", typeof(int));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            
            for (int i = 0; i < Rulelist.Count; i++)
            {
                dataTable.Rows.Add(RuleIdList[i], Rulelist[i].GetDate(), Rulelist[i].GetDescription());
            }

            RulesGrid.DataSource = dataTable;

             
        }
        private void RulesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void CheckRules_Load(object sender, EventArgs e)
        {

        }
    }
}
