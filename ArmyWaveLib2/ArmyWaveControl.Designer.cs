namespace ArmyWaveLib
{
    partial class ArmyWaveControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.armyTime = new System.Windows.Forms.MaskedTextBox();
            this.armyCard = new System.Windows.Forms.ComboBox();
            this.armyComment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // armyTime
            // 
            this.armyTime.Location = new System.Drawing.Point(3, 3);
            this.armyTime.Mask = "00:00:00";
            this.armyTime.Name = "armyTime";
            this.armyTime.Size = new System.Drawing.Size(51, 20);
            this.armyTime.TabIndex = 0;
            this.armyTime.Leave += new System.EventHandler(this.armyTime_Leave);
            // 
            // armyCard
            // 
            this.armyCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.armyCard.FormattingEnabled = true;
            this.armyCard.Location = new System.Drawing.Point(60, 3);
            this.armyCard.Name = "armyCard";
            this.armyCard.Size = new System.Drawing.Size(42, 21);
            this.armyCard.TabIndex = 1;
            // 
            // armyComment
            // 
            this.armyComment.Location = new System.Drawing.Point(108, 3);
            this.armyComment.Name = "armyComment";
            this.armyComment.Size = new System.Drawing.Size(152, 20);
            this.armyComment.TabIndex = 2;
            // 
            // ArmyWaveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.armyComment);
            this.Controls.Add(this.armyCard);
            this.Controls.Add(this.armyTime);
            this.Name = "ArmyWaveControl";
            this.Size = new System.Drawing.Size(264, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox armyTime;
        private System.Windows.Forms.ComboBox armyCard;
        private System.Windows.Forms.TextBox armyComment;
    }
}
