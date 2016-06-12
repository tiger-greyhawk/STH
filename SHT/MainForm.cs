using SHT.Asset;
using SHT.Dto;
using SHT.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SHT
{
    public partial class MainForm : Form
    {

        private ArmyWaveService armyWaveService = new ArmyWaveService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            foreach (ArmyWave armyWave in armyWaveService.FindAll()) {
                ArmyWaveControl armyWaveControl = new ArmyWaveControl(armyWave);
                armyWavesFlowLayoutPanel.Controls.Add(armyWaveControl);
            }
            timeCalculationTimer.Enabled = true;
            
        }

        private void timeCalculationTimer_Tick(object sender, EventArgs e)
        {
            new UpdateTimingCallback(UpdateTiming).Invoke();
        }

        delegate void UpdateTimingCallback();

        private void UpdateTiming()
        {
            long targetTimeTicks = targetTime.Value.Ticks - DateTime.Now.Ticks;
            foreach (ArmyWaveControl armyWaveControl in armyWavesFlowLayoutPanel.Controls)
            {
                ArmyWave armyWave = armyWaveControl.ArmyWave;
                TimeSpan timeLeft = new TimeSpan(targetTimeTicks - (armyWave.GetTravelTime() * 10000) / armyWave.GetMultiplier());
                armyWaveControl.SetTimeLeft(timeLeft.Ticks);
            }
        }

    }
}
