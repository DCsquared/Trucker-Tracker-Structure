namespace TruckerTracker
{
    partial class GPS
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
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.routeList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.routeList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trucker Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(12, 93);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(262, 69);
            this.Timer.TabIndex = 7;
            this.Timer.Text = "00:00:00";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(12, 376);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 43);
            this.start.TabIndex = 24;
            this.start.Text = "Start Driving";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.Start_Click);
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(168, 376);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(128, 43);
            this.pause.TabIndex = 23;
            this.pause.Text = "Pause Route";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(12, 430);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(128, 43);
            this.end.TabIndex = 25;
            this.end.Text = "End Route";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.End_Click);
            // 
            // resume
            // 
            this.resume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resume.Location = new System.Drawing.Point(168, 430);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(128, 43);
            this.resume.TabIndex = 26;
            this.resume.Text = "Resume Route";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.Back_Click);
            // 
            // routeList
            // 
            this.routeList.AllowUserToAddRows = false;
            this.routeList.AllowUserToDeleteRows = false;
            this.routeList.AllowUserToResizeColumns = false;
            this.routeList.AllowUserToResizeRows = false;
            this.routeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.routeList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.routeList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.routeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.routeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeList.Location = new System.Drawing.Point(12, 217);
            this.routeList.MultiSelect = false;
            this.routeList.Name = "routeList";
            this.routeList.ReadOnly = true;
            this.routeList.RowHeadersVisible = false;
            this.routeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.routeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.routeList.ShowEditingIcon = false;
            this.routeList.Size = new System.Drawing.Size(284, 128);
            this.routeList.TabIndex = 27;
            this.routeList.TabStop = false;
            this.routeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RouteList_CellContentClick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stops For This Route";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(37, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Time on Current Route";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(85, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 30;
            this.button1.Text = "Start New Day";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 534);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.routeList);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.end);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.Timer);
            this.Controls.Add(this.label1);
            this.Name = "GPS";
            this.Text = "GPS";
            ((System.ComponentModel.ISupportInitialize)(this.routeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Timer;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.DataGridView routeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}