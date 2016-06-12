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
                return armyCardText;
            }
            set
            {
                armyCardText = value;
                armyCard.Text = armyCardText;
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
    }
}
