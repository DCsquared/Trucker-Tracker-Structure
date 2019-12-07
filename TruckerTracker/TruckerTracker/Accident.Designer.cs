namespace TruckerTracker
{
    partial class Accident
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
            this.label2 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cars = new System.Windows.Forms.NumericUpDown();
            this.BackButton = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.accType = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.cars)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of accident";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(28, 196);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(249, 194);
            this.notes.TabIndex = 8;
            this.notes.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Involved cars";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Any other notes";
            // 
            // cars
            // 
            this.cars.Location = new System.Drawing.Point(28, 122);
            this.cars.Name = "cars";
            this.cars.Size = new System.Drawing.Size(120, 20);
            this.cars.TabIndex = 11;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(17, 445);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 43);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(205, 445);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(88, 43);
            this.Submit.TabIndex = 13;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Log
            // 
            this.Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log.Location = new System.Drawing.Point(111, 445);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(88, 43);
            this.Log.TabIndex = 14;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.Click += new System.EventHandler(this.Log_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(111, 396);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(88, 43);
            this.Reset.TabIndex = 15;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // accType
            // 
            this.accType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accType.FormattingEnabled = true;
            this.accType.ItemHeight = 16;
            this.accType.Items.AddRange(new object[] {
            "T-boned",
            "Car Collision",
            "Flipped",
            "Blown Tire",
            "False Engine Start",
            "Trailer Fire",
            "Off the Road",
            "Tree Collision",
            "Median Collision",
            "Hydroplaned",
            "Dead Battery"});
            this.accType.Location = new System.Drawing.Point(183, 122);
            this.accType.Name = "accType";
            this.accType.Size = new System.Drawing.Size(120, 36);
            this.accType.TabIndex = 16;
            // 
            // Accident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 500);
            this.Controls.Add(this.accType);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.cars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Accident";
            this.Text = "Accident";
            ((System.ComponentModel.ISupportInitialize)(this.cars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown cars;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Log;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.ListBox accType;
    }
}