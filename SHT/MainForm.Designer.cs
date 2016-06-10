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
            this.targetTime = new System.Windows.Forms.DateTimePicker();
            this.armyWavesDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.armyWavesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // targetTime
            // 
            this.targetTime.CustomFormat = "hh\':\'mm\':\'ss  dd\'.\'MM\'.\'yyyy";
            this.targetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.targetTime.Location = new System.Drawing.Point(100, 12);
            this.targetTime.Name = "targetTime";
            this.targetTime.Size = new System.Drawing.Size(129, 20);
            this.targetTime.TabIndex = 1;
            // 
            // armyWavesDataGridView
            // 
            this.armyWavesDataGridView.AllowUserToAddRows = false;
            this.armyWavesDataGridView.AllowUserToDeleteRows = false;
            this.armyWavesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.armyWavesDataGridView.Location = new System.Drawing.Point(13, 68);
            this.armyWavesDataGridView.Name = "armyWavesDataGridView";
            this.armyWavesDataGridView.ReadOnly = true;
            this.armyWavesDataGridView.Size = new System.Drawing.Size(710, 349);
            this.armyWavesDataGridView.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.armyWavesDataGridView);
            this.Controls.Add(this.targetTime);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.armyWavesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker targetTime;
        private System.Windows.Forms.DataGridView armyWavesDataGridView;
    }
}

