namespace TruckerTracker
{
    partial class Logs
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogNotes = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numCars = new System.Windows.Forms.Label();
            this.acciType = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LogDates = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trucker Tracker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Accident Logs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Any other notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Involved cars";
            // 
            // LogNotes
            // 
            this.LogNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogNotes.Location = new System.Drawing.Point(30, 263);
            this.LogNotes.Name = "LogNotes";
            this.LogNotes.ReadOnly = true;
            this.LogNotes.Size = new System.Drawing.Size(249, 194);
            this.LogNotes.TabIndex = 18;
            this.LogNotes.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type of accident";
            // 
            // numCars
            // 
            this.numCars.AutoSize = true;
            this.numCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCars.Location = new System.Drawing.Point(263, 163);
            this.numCars.Name = "numCars";
            this.numCars.Size = new System.Drawing.Size(16, 17);
            this.numCars.TabIndex = 21;
            this.numCars.Text = "0";
            // 
            // acciType
            // 
            this.acciType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acciType.AutoSize = true;
            this.acciType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acciType.Location = new System.Drawing.Point(191, 196);
            this.acciType.Name = "acciType";
            this.acciType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.acciType.Size = new System.Drawing.Size(42, 17);
            this.acciType.TabIndex = 22;
            this.acciType.Text = "None";
            this.acciType.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Date";
            // 
            // LogDates
            // 
            this.LogDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogDates.FormattingEnabled = true;
            this.LogDates.ItemHeight = 16;
            this.LogDates.Location = new System.Drawing.Point(112, 115);
            this.LogDates.Name = "LogDates";
            this.LogDates.ScrollAlwaysVisible = true;
            this.LogDates.Size = new System.Drawing.Size(175, 36);
            this.LogDates.TabIndex = 24;
            this.LogDates.SelectedIndexChanged += new System.EventHandler(this.LogDates_SelectedIndexChanged);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(112, 473);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 43);
            this.BackButton.TabIndex = 25;
            this.BackButton.Text = "Main Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 547);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.LogDates);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.acciType);
            this.Controls.Add(this.numCars);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LogNotes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Logs";
            this.Text = "Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox LogNotes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numCars;
        private System.Windows.Forms.Label acciType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox LogDates;
        private System.Windows.Forms.Button BackButton;
    }
}