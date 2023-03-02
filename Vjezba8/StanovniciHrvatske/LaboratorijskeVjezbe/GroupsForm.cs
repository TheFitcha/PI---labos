using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorijskeVjezbe
{
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        private void Groups_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void RefreshUI()
        {
            var listGroups = new List<Group>(); 
            using(var context = new EntityDBEntities())
            {
                listGroups = context.Groups.ToList();
            }
            dataGridView1.DataSource = listGroups;
            dataGridView1.Columns["Students"].Visible = false;
        }

        private void btnAddRemove_Click(object sender, EventArgs e)
        {
            var chosen = dataGridView1.CurrentRow.DataBoundItem as Group;
            GroupParticipants group = new GroupParticipants(chosen);
            group.ShowDialog();
            RefreshUI();
        }
    }
}
