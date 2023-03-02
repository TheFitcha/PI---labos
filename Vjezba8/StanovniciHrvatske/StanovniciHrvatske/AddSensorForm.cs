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
    public partial class AddSensorForm : Form
    {
        public AddSensorForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddSensorForm_Load(object sender, EventArgs e)
        {
            List<SensorType> sensorTypes;
            using (var context = new DB_EntityEntities())
            {
                sensorTypes = context.SensorTypes.ToList();
            }

            comboBox1.DataSource = sensorTypes;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedType = comboBox1.SelectedItem as SensorType;
            Sensor newSensor = new Sensor()
            {
                Name = textBox1.Text,
                IdSensorTypes = selectedType.Id,
                SensorType = selectedType
            };
            using (var context = new DB_EntityEntities())
            {
                context.Sensors.Add(newSensor);
                context.SaveChanges();  
            }
            Close();
        }
    }
}
