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
            UpdateTiming();
        }

        delegate void UpdateTimingCallback();

        private void UpdateTiming()
        {
            if (armyWavesFlowLayoutPanel.InvokeRequired)
            {
                UpdateTimingCallback updateTimingCallback = new UpdateTimingCallback(UpdateTiming);
                this.Invoke(updateTimingCallback);
            }
            else
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
}
