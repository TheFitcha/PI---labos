using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanovniciHrvatske
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
        }

        private object GetSensors()
        {
            using (var context = new DB_EntityEntities())
            {
                return context.Sensors.ToList();
            }
        }

        private void btnAddSensor_Click(object sender, EventArgs e)
        {
            AddSensorForm addSensorForm = new AddSensorForm();
            addSensorForm.ShowDialog();
            RefreshUI();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            AssignUnitForm assignUnitForm = new AssignUnitForm(dataGridView1.CurrentRow.DataBoundItem as Sensor);
            assignUnitForm.ShowDialog();
            RefreshUI();
        }

        private void btnDeleteSensor_Click(object sender, EventArgs e)
        {
            var selectedSensor = dataGridView1.CurrentRow.DataBoundItem as Sensor;
            using (var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(selectedSensor); 
                context.Sensors.Remove(selectedSensor);
                context.SaveChanges();
            }
            RefreshUI();
        }

        private void RefreshUI()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = GetSensors();
            dataGridView1.Columns["MeasurementUnit"].Visible = false;
            dataGridView1.Columns["SensorReadings"].Visible = false;
            dataGridView1.Columns["SensorType"].Visible = false;
        }
    }
}
