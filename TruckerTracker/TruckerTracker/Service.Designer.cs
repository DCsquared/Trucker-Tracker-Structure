namespace TruckerTracker
{
    partial class Service
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
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lastDate = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updateCon = new System.Windows.Forms.Label();
            this.getServiced = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Trucker Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(37, 126);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // lastDate
            // 
            this.lastDate.AutoSize = true;
            this.lastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDate.Location = new System.Drawing.Point(50, 76);
            this.lastDate.Name = "lastDate";
            this.lastDate.Size = new System.Drawing.Size(214, 20);
            this.lastDate.TabIndex = 7;
            this.lastDate.Text = "Last Service Date: 6/28/2017";
            this.lastDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.Black;
            this.update.Location = new System.Drawing.Point(68, 453);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(156, 43);
            this.update.TabIndex = 8;
            this.update.Text = "Update Service";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select the date of your last service check";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updateCon
            // 
            this.updateCon.AutoSize = true;
            this.updateCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCon.ForeColor = System.Drawing.Color.Green;
            this.updateCon.Location = new System.Drawing.Point(15, 380);
            this.updateCon.Name = "updateCon";
            this.updateCon.Size = new System.Drawing.Size(264, 17);
            this.updateCon.TabIndex = 10;
            this.updateCon.Text = "Your last service date has been updated";
            this.updateCon.Visible = false;
            // 
            // getServiced
            // 
            this.getServiced.AutoSize = true;
            this.getServiced.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getServiced.ForeColor = System.Drawing.Color.Red;
            this.getServiced.Location = new System.Drawing.Point(51, 380);
            this.getServiced.Name = "getServiced";
            this.getServiced.Size = new System.Drawing.Size(204, 17);
            this.getServiced.TabIndex = 11;
            this.getServiced.Text = "It is time for you to get serviced";
            this.getServiced.Visible = false;
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 531);
            this.Controls.Add(this.getServiced);
            this.Controls.Add(this.updateCon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.lastDate);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.Name = "Service";
            this.Text = "v";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lastDate;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label updateCon;
        private System.Windows.Forms.Label getServiced;
    }
}