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
    public partial class AssignUnitForm : Form
    {
        private Sensor selectedSensor;
        public AssignUnitForm(Sensor selectedSensor)
        {
            InitializeComponent();
            this.selectedSensor = selectedSensor;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            var selectedUnit = comboBox1.SelectedItem as MeasurementUnit;
            using (var context = new DB_EntityEntities())
            {
                context.MeasurementUnits.Attach(selectedUnit);
                context.Sensors.Attach(selectedSensor);
                selectedSensor.IdMeasurementUnits = selectedUnit.Id;
                selectedSensor.MeasurementUnit = selectedUnit;

                context.SaveChanges();
            }
            Close();
        }

        private void AssignUnitForm_Load(object sender, EventArgs e)
        {
            List<MeasurementUnit> listUnits;
            using (var context = new DB_EntityEntities())
            {
                context.Sensors.Attach(selectedSensor);
                listUnits = context.MeasurementUnits.ToList();
            }

            comboBox1.DataSource = listUnits;
        }
        
    }
}
