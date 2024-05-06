using HostelDll.Bl;
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
using HostelDll.Utilities;
using HostelDll.DlFH;
using HostelDll.DLInterfaces;

namespace Resistay.UI
{
    public partial class Ruleform : Form
    {
        private string Path = "C:\\Users\\M JUNAID BASHIR\\Desktop\\OOP Project\\ProjectRules.txt";
        //private string ConnectionString = @"Data Source=ALI-HAMZA;Initial Catalog=FiveStarHostels;Integrated Security=True;"
       
        IRule RulesFH;
        public Ruleform()
        {
            InitializeComponent();
            RulesFH = new RulesFH(Path);
            LoadRules();
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {

            Hide();
             
        }
        private void LoadRules()
        {
            List<HostelDll.Bl.Rule> Rulelist = RulesFH.GetAllRules();
            List<int> RuleIdList = RulesFH.GetRuleIds();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("RulesId", typeof(int));
            dataTable.Columns.Add("Date", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));

            for (int i = 0; i < Rulelist.Count; i++)
            {
                dataTable.Rows.Add(RuleIdList[i], Rulelist[i].GetDate(), Rulelist[i].GetDescription());
            }

            RulesGrid.DataSource = dataTable;

            rulesId.Items.Clear(); 
            foreach (int ruleId in RuleIdList)
            {
                rulesId.Items.Add(ruleId);
            }
        }

        private void Rule_Load(object sender, EventArgs e)
        {

        }

        private void RulesDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void RulesBtn_Click(object sender, EventArgs e)
        {
            if (Validation.IsEmptyInput(Rule.Text))
            {
                MessageBox.Show("Added Successfully");
                HostelDll.Bl.Rule rule = new HostelDll.Bl.Rule(Rule.Text, RulesDate.Text);
                RulesFH.AddRule(rule);
                LoadRules();

            }
            else
            {
                MessageBox.Show("Invalid Annoucement");
            }

        }

         

        private void rulesId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveRuleBtn_Click(object sender, EventArgs e)
        {

            RulesFH.DeleteRule(int.Parse(rulesId.Text));
            MessageBox.Show("Deleted Successfully");
            LoadRules();


        }

        private void RulesLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
