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
    public partial class GroupParticipants : Form
    {
        private readonly Group chosenGroup;
        public GroupParticipants(Group group)
        {
            chosenGroup = group;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUI();
        }

        private void RefreshUI()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            using (var context = new EntityDBEntities())
            {
                var students = context.Students.ToList();
                List<Student> unassignedStudents = new List<Student>();
                List<Student> assignedStudents = new List<Student>();
                foreach (var student in students)
                {
                    if (student.IdGroups == null)
                        unassignedStudents.Add(student);
                    else if(student.IdGroups == chosenGroup.Id)
                        assignedStudents.Add(student);
                }
                dataGridView1.DataSource = unassignedStudents;
                dataGridView2.DataSource = assignedStudents;

                textBox1.Text = chosenGroup.Name;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddToGroup_Click(object sender, EventArgs e)
        {
            var chosen = dataGridView1.CurrentRow.DataBoundItem as Student;
            using(var context = new EntityDBEntities())
            {
                context.Groups.Attach(chosenGroup);
                context.Students.Attach(chosen);

                chosen.IdGroups = chosenGroup.Id;

                context.SaveChanges();
            }
            RefreshUI();    
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            var chosen = dataGridView2.CurrentRow.DataBoundItem as Student;
            using(var context = new EntityDBEntities())
            {
                context.Groups.Attach(chosenGroup);
                context.Students.Attach(chosen);

                chosen.IdGroups = null;

                context.SaveChanges();
            }
            RefreshUI();
        }
    }
}
