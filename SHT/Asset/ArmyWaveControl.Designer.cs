using SHT.Dto;
using System;

namespace SHT.Asset
{
    partial class ArmyWaveControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.travelTime = new System.Windows.Forms.MaskedTextBox();
            this.multiplier = new System.Windows.Forms.NumericUpDown();
            this.name = new System.Windows.Forms.TextBox();
            this.timeLeft = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.armyWaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyWaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.travelTime);
            this.flowLayoutPanel.Controls.Add(this.multiplier);
            this.flowLayoutPanel.Controls.Add(this.name);
            this.flowLayoutPanel.Controls.Add(this.timeLeft);
            this.flowLayoutPanel.Controls.Add(this.removeButton);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(703, 28);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // travelTime
            // 
            this.travelTime.Location = new System.Drawing.Point(3, 3);
            this.travelTime.Mask = "00\\.00:00:00";
            this.travelTime.Name = "travelTime";
            this.travelTime.Size = new System.Drawing.Size(140, 20);
            this.travelTime.TabIndex = 0;
            // 
            // multiplier
            // 
            this.multiplier.Location = new System.Drawing.Point(149, 3);
            this.multiplier.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.multiplier.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.multiplier.Name = "multiplier";
            this.multiplier.Size = new System.Drawing.Size(47, 20);
            this.multiplier.TabIndex = 1;
            this.multiplier.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(202, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(270, 20);
            this.name.TabIndex = 2;
            // 
            // timeLeft
            // 
            this.timeLeft.Location = new System.Drawing.Point(478, 3);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(134, 20);
            this.timeLeft.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(618, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // armyWaveBindingSource
            // 
            this.armyWaveBindingSource.DataSource = typeof(SHT.Dto.ArmyWave);
            // 
            // ArmyWaveControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "ArmyWaveControl";
            this.Size = new System.Drawing.Size(703, 28);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.armyWaveBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.MaskedTextBox travelTime;
        private System.Windows.Forms.NumericUpDown multiplier;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox timeLeft;
        private System.Windows.Forms.BindingSource armyWaveBindingSource;
        private System.Windows.Forms.Button removeButton;
    }
}
