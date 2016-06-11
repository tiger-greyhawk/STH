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
            armyWavesListView.DoubleBuffering(true);
            populateListView(armyWavesListView, new List<ArmyWave>(armyWaveService.FindAll()));
            timeCalculationTimer.Enabled = true;
        }

        private void timeCalculationTimer_Tick(object sender, EventArgs e)
        {
            UpdateTiming();
        }


        private void populateListView(ListView listView, List<ArmyWave> armyWaves)
        {
            listView.Items.Clear();
            foreach (ArmyWave armyWave in armyWaves)
            {
                ListViewItem listViewItem = new ListViewItem(armyWave.Id);
                listViewItem.Tag = armyWave;
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, armyWave.TravelTime));
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, armyWave.Multiplier));
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, armyWave.Name));
                listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, "------"));
                listView.Items.Add(listViewItem);
            }
        }

        delegate void UpdateTimingCallback();

        private void UpdateTiming()
        {
            if (armyWavesListView.InvokeRequired)
            {
                UpdateTimingCallback updateTimingCallback = new UpdateTimingCallback(UpdateTiming);
                this.Invoke(updateTimingCallback);
            }
            else
            {
                long targetTimeTicks = targetTime.Value.Ticks - DateTime.Now.Ticks;
                armyWavesListView.BeginUpdate();
                foreach (ListViewItem armyWavesListViewItem in armyWavesListView.Items)
                {
                    ArmyWave armyWave = (ArmyWave)armyWavesListViewItem.Tag;
                    TimeSpan timeLeft = new TimeSpan(targetTimeTicks - (armyWave.GetTravelTime() * 10000) / armyWave.GetMultiplier());
                    armyWavesListViewItem.SubItems[4].Text = timeLeft.ToString();
                    if (Math.Abs(timeLeft.Ticks) <= 100000000)
                    {
                        armyWavesListViewItem.BackColor = Color.Green;
                    }
                    else if (timeLeft.Ticks < 0)
                    {
                        armyWavesListViewItem.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        armyWavesListViewItem.BackColor = Color.LightGreen;
                    }
                }
                armyWavesListView.EndUpdate();
            }
        }

    }
}
