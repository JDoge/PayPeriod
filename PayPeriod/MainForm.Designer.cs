namespace PayPeriod
{
    partial class MainWindows
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
            this.GoButton = new System.Windows.Forms.Button();
            this.StartDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.EndDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.MondayHourBox = new System.Windows.Forms.TextBox();
            this.TuesdayHourBox = new System.Windows.Forms.TextBox();
            this.WednesdayHourBox = new System.Windows.Forms.TextBox();
            this.ThursdayHourBox = new System.Windows.Forms.TextBox();
            this.FridayHourBox = new System.Windows.Forms.TextBox();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.ThursdayLabel = new System.Windows.Forms.Label();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.OutputTable = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // GoButton
            // 
            this.GoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoButton.Location = new System.Drawing.Point(474, 216);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(100, 100);
            this.GoButton.TabIndex = 0;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click); // was button1_Click
            // 
            // StartDateCalendar
            // 
            this.StartDateCalendar.Location = new System.Drawing.Point(27, 86);
            this.StartDateCalendar.Name = "StartDateCalendar";
            this.StartDateCalendar.TabIndex = 2;
            this.StartDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // EndDateCalendar
            // 
            this.EndDateCalendar.Location = new System.Drawing.Point(27, 285);
            this.EndDateCalendar.Name = "EndDateCalendar";
            this.EndDateCalendar.TabIndex = 3;
            this.EndDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(22, 55);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(105, 25);
            this.StartDateLabel.TabIndex = 4;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(22, 257);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(99, 25);
            this.EndDateLabel.TabIndex = 5;
            this.EndDateLabel.Text = "End Date:";
            // 
            // MondayHourBox
            // 
            this.MondayHourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayHourBox.Location = new System.Drawing.Point(393, 206);
            this.MondayHourBox.Name = "MondayHourBox";
            this.MondayHourBox.Size = new System.Drawing.Size(40, 26);
            this.MondayHourBox.TabIndex = 6;
            this.MondayHourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TuesdayHourBox
            // 
            this.TuesdayHourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayHourBox.Location = new System.Drawing.Point(393, 231);
            this.TuesdayHourBox.Name = "TuesdayHourBox";
            this.TuesdayHourBox.Size = new System.Drawing.Size(40, 26);
            this.TuesdayHourBox.TabIndex = 7;
            this.TuesdayHourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WednesdayHourBox
            // 
            this.WednesdayHourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayHourBox.Location = new System.Drawing.Point(393, 257);
            this.WednesdayHourBox.Name = "WednesdayHourBox";
            this.WednesdayHourBox.Size = new System.Drawing.Size(40, 26);
            this.WednesdayHourBox.TabIndex = 8;
            this.WednesdayHourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ThursdayHourBox
            // 
            this.ThursdayHourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayHourBox.Location = new System.Drawing.Point(393, 283);
            this.ThursdayHourBox.Name = "ThursdayHourBox";
            this.ThursdayHourBox.Size = new System.Drawing.Size(40, 26);
            this.ThursdayHourBox.TabIndex = 9;
            this.ThursdayHourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FridayHourBox
            // 
            this.FridayHourBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayHourBox.Location = new System.Drawing.Point(393, 309);
            this.FridayHourBox.Name = "FridayHourBox";
            this.FridayHourBox.Size = new System.Drawing.Size(40, 26);
            this.FridayHourBox.TabIndex = 10;
            this.FridayHourBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayLabel.Location = new System.Drawing.Point(294, 206);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(65, 20);
            this.MondayLabel.TabIndex = 11;
            this.MondayLabel.Text = "Monday";
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayLabel.Location = new System.Drawing.Point(294, 232);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(69, 20);
            this.TuesdayLabel.TabIndex = 12;
            this.TuesdayLabel.Text = "Tuesday";
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayLabel.Location = new System.Drawing.Point(294, 258);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(93, 20);
            this.WednesdayLabel.TabIndex = 13;
            this.WednesdayLabel.Text = "Wednesday";
            // 
            // ThursdayLabel
            // 
            this.ThursdayLabel.AutoSize = true;
            this.ThursdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThursdayLabel.Location = new System.Drawing.Point(294, 284);
            this.ThursdayLabel.Name = "ThursdayLabel";
            this.ThursdayLabel.Size = new System.Drawing.Size(74, 20);
            this.ThursdayLabel.TabIndex = 14;
            this.ThursdayLabel.Text = "Thursday";
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayLabel.Location = new System.Drawing.Point(294, 310);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(52, 20);
            this.FridayLabel.TabIndex = 15;
            this.FridayLabel.Text = "Friday";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.Location = new System.Drawing.Point(381, 172);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(64, 25);
            this.HoursLabel.TabIndex = 16;
            this.HoursLabel.Text = "Hours";
            // 
            // OutputTable
            // 
            this.OutputTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTable.Location = new System.Drawing.Point(610, 159);
            this.OutputTable.Name = "OutputTable";
            this.OutputTable.Size = new System.Drawing.Size(192, 228);
            this.OutputTable.TabIndex = 17;
            this.OutputTable.UseCompatibleStateImageBehavior = false;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 542);
            this.Controls.Add(this.OutputTable);
            this.Controls.Add(this.HoursLabel);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.ThursdayLabel);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.FridayHourBox);
            this.Controls.Add(this.ThursdayHourBox);
            this.Controls.Add(this.WednesdayHourBox);
            this.Controls.Add(this.TuesdayHourBox);
            this.Controls.Add(this.MondayHourBox);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.EndDateCalendar);
            this.Controls.Add(this.StartDateCalendar);
            this.Controls.Add(this.GoButton);
            this.Name = "MainWindows";
            this.Text = "PayPeriod Hour Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.MonthCalendar StartDateCalendar;
        private System.Windows.Forms.MonthCalendar EndDateCalendar;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.TextBox MondayHourBox;
        private System.Windows.Forms.TextBox TuesdayHourBox;
        private System.Windows.Forms.TextBox WednesdayHourBox;
        private System.Windows.Forms.TextBox ThursdayHourBox;
        private System.Windows.Forms.TextBox FridayHourBox;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.Label ThursdayLabel;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.ListView OutputTable;
    }
}

