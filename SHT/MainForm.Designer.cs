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
            this.armyWavesListView = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.multiplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeCalculationTimer = new System.Windows.Forms.Timer(this.components);
            this.attackTimeLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.armyWaveControl1 = new ArmyWaveLib.ArmyWaveControl();
            this.SuspendLayout();
            // 
            // targetTime
            // 
            this.targetTime.CustomFormat = "HH\':\'mm\':\'ss  dd\'.\'MM\'.\'yyyy";
            this.targetTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.targetTime.Location = new System.Drawing.Point(403, 5);
            this.targetTime.Name = "targetTime";
            this.targetTime.Size = new System.Drawing.Size(129, 20);
            this.targetTime.TabIndex = 1;
            // 
            // armyWavesListView
            // 
            this.armyWavesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.armyWavesListView.CausesValidation = false;
            this.armyWavesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.time,
            this.multiplier,
            this.name,
            this.timeLeft});
            this.armyWavesListView.Location = new System.Drawing.Point(12, 199);
            this.armyWavesListView.Name = "armyWavesListView";
            this.armyWavesListView.Size = new System.Drawing.Size(778, 262);
            this.armyWavesListView.TabIndex = 2;
            this.armyWavesListView.UseCompatibleStateImageBehavior = false;
            this.armyWavesListView.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            // 
            // time
            // 
            this.time.Text = "Time";
            // 
            // multiplier
            // 
            this.multiplier.Text = "multiplier";
            // 
            // name
            // 
            this.name.Text = "name";
            // 
            // timeLeft
            // 
            this.timeLeft.Text = "Time Left";
            // 
            // timeCalculationTimer
            // 
            this.timeCalculationTimer.Interval = 1000;
            this.timeCalculationTimer.Tick += new System.EventHandler(this.timeCalculationTimer_Tick);
            // 
            // attackTimeLabel
            // 
            this.attackTimeLabel.AutoSize = true;
            this.attackTimeLabel.Location = new System.Drawing.Point(333, 5);
            this.attackTimeLabel.Name = "attackTimeLabel";
            this.attackTimeLabel.Size = new System.Drawing.Size(64, 13);
            this.attackTimeLabel.TabIndex = 3;
            this.attackTimeLabel.Text = "Attack Time";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(585, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "button1";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // armyWaveControl1
            // 
            this.armyWaveControl1.ArmyCard = "0";
            this.armyWaveControl1.ArmyComment = null;
            this.armyWaveControl1.ArmyTime = null;
            this.armyWaveControl1.Location = new System.Drawing.Point(403, 56);
            this.armyWaveControl1.Name = "armyWaveControl1";
            this.armyWaveControl1.Size = new System.Drawing.Size(264, 27);
            this.armyWaveControl1.TabIndex = 5;
            this.armyWaveControl1.Leave += new System.EventHandler(this.armyWaveControl1_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 473);
            this.Controls.Add(this.armyWaveControl1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.attackTimeLabel);
            this.Controls.Add(this.armyWavesListView);
            this.Controls.Add(this.targetTime);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker targetTime;
        private System.Windows.Forms.ListView armyWavesListView;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader multiplier;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader timeLeft;
        private System.Windows.Forms.Timer timeCalculationTimer;
        private System.Windows.Forms.Label attackTimeLabel;
        private System.Windows.Forms.Button startButton;
        private ArmyWaveLib.ArmyWaveControl armyWaveControl1;
    }
}

