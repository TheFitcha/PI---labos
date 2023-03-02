using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IzvrseniZadaci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshUI();
            for (int i = 1; i<=5; i++)
                cmbPriority.Items.Add(i.ToString());
        }

        private void RefreshUI()
        {
            var listTasks = new List<Task>();
            using(var context = new EF_DBEntities())
            {
                listTasks = context.Tasks.ToList(); 
            }
            var completedTasks = new List<Task>();
            var uncompletedTasks = new List<Task>();
            foreach(var task in listTasks)
            {
                if (!task.Completed)
                {
                    completedTasks.Add(task);
                }
                else
                {
                    uncompletedTasks.Add(task);
                }
            }
            dataGridView1.DataSource = completedTasks;
            dataGridView1.Columns["Employee"].Visible = false;

            dataGridView2.DataSource = uncompletedTasks;
            dataGridView2.Columns["Employee"].Visible = false;
        }

        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            var chosen = dataGridView1.CurrentRow.DataBoundItem as Task;
            using (var context = new EF_DBEntities())
            {
                context.Tasks.Attach(chosen);
                chosen.Completed = true;
                context.SaveChanges();
            }
            RefreshUI();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                var description = txtDescription.Text;
                var prioritet = int.Parse(cmbPriority.SelectedItem.ToString());

                Task newTask = new Task()
                {
                    Description = description,
                    Completed = false,
                    EmployeeId = null,
                    Employee = null,
                    Priority = prioritet
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();
            }
            txtDescription.Text = null;
            cmbPriority.SelectedIndex = -1;
            RefreshUI();
        }
    }
}
