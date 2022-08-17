namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.clear = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.TextBox();
            this.endDate = new System.Windows.Forms.TextBox();
            this.daysResult = new System.Windows.Forms.TextBox();
            this.selectEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(247, 87);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(171, 87);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(247, 248);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(114, 23);
            this.select.TabIndex = 2;
            this.select.Text = "Select Start";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(474, 88);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(227, 59);
            this.startDate.Name = "startDate";
            this.startDate.PlaceholderText = "Start Date:";
            this.startDate.Size = new System.Drawing.Size(125, 23);
            this.startDate.TabIndex = 4;
            this.startDate.TextChanged += new System.EventHandler(this.startDate_TextChanged);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(358, 59);
            this.endDate.Name = "endDate";
            this.endDate.PlaceholderText = "End Date";
            this.endDate.Size = new System.Drawing.Size(125, 23);
            this.endDate.TabIndex = 5;
            // 
            // daysResult
            // 
            this.daysResult.Location = new System.Drawing.Point(247, 30);
            this.daysResult.Name = "daysResult";
            this.daysResult.PlaceholderText = "Days between";
            this.daysResult.Size = new System.Drawing.Size(222, 23);
            this.daysResult.TabIndex = 6;
            this.daysResult.TextChanged += new System.EventHandler(this.daysResult_TextChanged);
            // 
            // selectEnd
            // 
            this.selectEnd.Location = new System.Drawing.Point(358, 248);
            this.selectEnd.Name = "selectEnd";
            this.selectEnd.Size = new System.Drawing.Size(116, 23);
            this.selectEnd.TabIndex = 7;
            this.selectEnd.Text = "Select End";
            this.selectEnd.UseVisualStyleBackColor = true;
            this.selectEnd.Click += new System.EventHandler(this.selectEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectEnd);
            this.Controls.Add(this.daysResult);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.select);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button clear;
        private Button select;
        private Button calculate;
        private TextBox startDate;
        private TextBox endDate;
        private TextBox daysResult;
        private Button selectEnd;
    }
}