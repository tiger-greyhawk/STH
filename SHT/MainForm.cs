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
            populateEditArmy(new List<ArmyWave>(armyWaveService.FindAll()));
            //timeCalculationTimer.Enabled = true;
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

        private void populateEditArmy(List<ArmyWave> armyWaves)
        {
            int j = 0;
            foreach(ArmyWave armyWave in armyWaves)
            {
                MaskedTextBox timeArmy = new MaskedTextBox();
                ComboBox cardArmy = new ComboBox();
                TextBox commentArmy = new TextBox();
                timeArmy.Width = 50;
                timeArmy.Left = 10;
                timeArmy.Top = 10 + j * 25;
                timeArmy.Mask = "00:00:00";
                timeArmy.Text = armyWave.TravelTime;
                timeArmy.Tag = Convert.ToString(j);
                timeArmy.Leave += new EventHandler(timeArmy_Leave);
                //this.timeArmy.Leave += new EventHandler(maskedTextBox1_Leave);
                for (int i = 1; i < 7; i++)
                {
                    cardArmy.Items.Add("X" + i);
                }
                cardArmy.SelectedIndex = 0;
                cardArmy.Width = 40;
                cardArmy.Left = 70;
                cardArmy.Top = 10 + j * 25;
                cardArmy.SelectedIndex = armyWave.GetMultiplier()-1;
                cardArmy.Tag = Convert.ToString(j);

                commentArmy.Width = 100;
                commentArmy.Left = 120;
                commentArmy.Top = 10 + j * 25;
                commentArmy.Text = armyWave.Name;
                commentArmy.Tag = Convert.ToString(j);
                this.Controls.Add(timeArmy);
                this.Controls.Add(cardArmy);
                this.Controls.Add(commentArmy);
                j++;
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

        private void timeArmy_Leave(object sender, EventArgs e)
        {
            armyWaveService.SetArmyWave(Convert.ToInt32((sender as MaskedTextBox).Tag), new ArmyWave(3, TimeToLong((sender as MaskedTextBox).Text), 2, "Goodies"));
            populateListView(armyWavesListView, new List<ArmyWave>(armyWaveService.FindAll()));
            
        }

        private long TimeToLong(string time)
        {
            DateTime temp = Convert.ToDateTime(time);
            long time1 = temp.Millisecond + temp.Second * 1000 + temp.Minute * 60 * 1000 + temp.Hour * 60 * 60 * 1000;

            
            //temp = temp.
            return time1;
            //return temp.Ticks;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timeCalculationTimer.Enabled = true;
        }
    }
}
