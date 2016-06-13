using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArmyWaveLib
{
    public partial class ArmyWaveControl: UserControl
    {
        private string armyTimeText;
        private string armyCardText;
        private string armyCommentText;
        public ArmyWaveControl()
        {
            
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            for (int i = 1; i < 7; i++)
            {
                //ArmyCard = ("X" + i);
                armyCard.Items.Add(Convert.ToString(i));
            }
            armyCard.SelectedIndex = 0;
        }

        public string ArmyTime
        {
            get
            {
                return armyTimeText;
            }
            set
            {
                armyTimeText = value;
                armyTime.Text = armyTimeText;
            }

        }

        public string ArmyCard
        {
            get
            {
                //return armyCardText;
                return Convert.ToString(armyCard.SelectedIndex + 1);
            }
            set
            {
                armyCardText = value;
            //    if (armyCard.SelectedIndex != -1)
                armyCard.SelectedIndex = Convert.ToInt32(armyCardText)-1;
                //armyCard.Items.Add(armyCardText);
                //armyCard.Items.Add(armyCardText);
                //armyCard.Text = (armyCardText);
            }

        }

        public string ArmyComment
        {
            get
            {
                return armyCommentText;
            }
            set
            {
                armyCommentText = value;
                armyComment.Text = armyCommentText;
            }

        }

        protected virtual void armyTime_Leave(object sender, EventArgs e)
        {
            armyTimeText = armyTime.Text;
        }
    }
}
