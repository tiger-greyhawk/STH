using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SHT
{
    public partial class MainForm : Form
    {

        public ArmyWave[] armyWaves = new ArmyWave[]
        {
            new ArmyWave(0, 22123122, 2, "Nieaset"),
            new ArmyWave(0, 37712313, 2, "Bolivian"),
            new ArmyWave(0, 137712222, 2, "Olivastr")
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            armyWavesDataGridView.DataSource = armyWaves;

        }
    }
}
