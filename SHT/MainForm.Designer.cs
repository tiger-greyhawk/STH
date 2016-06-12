namespace SHT
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.targetTime = new System.Windows.Forms.DateTimePicker();
            this.timeCalculationTimer = new System.Windows.Forms.Timer(this.components);
            this.attackTimeLabel = new System.Windows.Forms.Label();
            this.armyWavesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // targetTime
            // 
            this.targetTime.CustomFormat = "HH\':\'mm\':\'ss  dd\'.\'MM\'.\'yyyy";
            this.targetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.targetTime.Location = new System.Drawing.Point(95, 12);
            this.targetTime.Name = "targetTime";
            this.targetTime.Size = new System.Drawing.Size(129, 20);
            this.targetTime.TabIndex = 1;
            // 
            // timeCalculationTimer
            // 
            this.timeCalculationTimer.Interval = 1000;
            this.timeCalculationTimer.Tick += new System.EventHandler(this.timeCalculationTimer_Tick);
            // 
            // attackTimeLabel
            // 
            this.attackTimeLabel.AutoSize = true;
            this.attackTimeLabel.Location = new System.Drawing.Point(12, 12);
            this.attackTimeLabel.Name = "attackTimeLabel";
            this.attackTimeLabel.Size = new System.Drawing.Size(64, 13);
            this.attackTimeLabel.TabIndex = 3;
            this.attackTimeLabel.Text = "Attack Time";
            // 
            // armyWavesFlowLayoutPanel
            // 
            this.armyWavesFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armyWavesFlowLayoutPanel.AutoScroll = true;
            this.armyWavesFlowLayoutPanel.Location = new System.Drawing.Point(12, 38);
            this.armyWavesFlowLayoutPanel.Name = "armyWavesFlowLayoutPanel";
            this.armyWavesFlowLayoutPanel.Size = new System.Drawing.Size(778, 423);
            this.armyWavesFlowLayoutPanel.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.armyWavesFlowLayoutPanel);
            this.Controls.Add(this.attackTimeLabel);
            this.Controls.Add(this.targetTime);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker targetTime;
        private System.Windows.Forms.Timer timeCalculationTimer;
        private System.Windows.Forms.Label attackTimeLabel;
        private System.Windows.Forms.FlowLayoutPanel armyWavesFlowLayoutPanel;
    }
}

