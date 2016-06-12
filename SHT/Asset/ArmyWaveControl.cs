using System.Windows.Forms;
using SHT.Dto;
using System;

namespace SHT.Asset
{
    public partial class ArmyWaveControl : UserControl
    {

        public event EventHandler BeforeRemove;
        public ArmyWave ArmyWave { get; set; }

        public ArmyWaveControl(ArmyWave armyWave)
        {
            InitializeComponent();
            this.ArmyWave = armyWave;
            this.travelTime.DataBindings.Add("Text", ArmyWave, "TravelTime");
            this.multiplier.DataBindings.Add("Value", ArmyWave, "Multiplier");
            this.name.DataBindings.Add("Text", ArmyWave, "Name");
        }

        public void SetTimeLeft(long ticks)
        {
            timeLeft.Text = (ticks < 0 ? "-" : "") + new TimeSpan(ticks).ToString(@"dd\.hh\:mm\:ss");
            if (ticks < 0)
            {
                timeLeft.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                timeLeft.ForeColor = System.Drawing.Color.Black;
            }
        }

        /// <summary>
        /// Self-removes from parent control on button click.
        /// </summary>
        /// <param name="sender">object that requests removal</param>
        /// <param name="e">event arguments</param>
        private void removeButton_Click(object sender, System.EventArgs e)
        {
            // Simplified form of if (BeforeRemove != null) { BeforeRemove(this, e); }
            BeforeRemove?.Invoke(this, e);
            Parent.Controls.Remove(this);
        }
    }
}
