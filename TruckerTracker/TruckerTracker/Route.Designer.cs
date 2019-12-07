namespace TruckerTracker
{
    partial class Route
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.addRoute = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.startRoute = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.truckerTrackerDataSet = new TruckerTracker.TruckerTrackerDataSet();
            this.stopsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopsTableAdapter = new TruckerTracker.TruckerTrackerDataSetTableAdapters.StopsTableAdapter();
            this.routeList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.truckerTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeList)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert An Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stops For This Route";
            // 
            // address
            // 
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(12, 158);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(267, 26);
            this.address.TabIndex = 9;
            // 
            // addRoute
            // 
            this.addRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoute.Location = new System.Drawing.Point(88, 190);
            this.addRoute.Name = "addRoute";
            this.addRoute.Size = new System.Drawing.Size(128, 43);
            this.addRoute.TabIndex = 15;
            this.addRoute.Text = "Add To Route";
            this.addRoute.UseVisualStyleBackColor = true;
            this.addRoute.Click += new System.EventHandler(this.AddRoute_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 494);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(128, 43);
            this.back.TabIndex = 19;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Create Route";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startRoute
            // 
            this.startRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startRoute.Location = new System.Drawing.Point(88, 428);
            this.startRoute.Name = "startRoute";
            this.startRoute.Size = new System.Drawing.Size(128, 43);
            this.startRoute.TabIndex = 21;
            this.startRoute.Text = "Start Route";
            this.startRoute.UseVisualStyleBackColor = true;
            this.startRoute.Click += new System.EventHandler(this.StartRoute_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(167, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 22;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // truckerTrackerDataSet
            // 
            this.truckerTrackerDataSet.DataSetName = "TruckerTrackerDataSet";
            this.truckerTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stopsBindingSource
            // 
            this.stopsBindingSource.DataMember = "Stops";
            this.stopsBindingSource.DataSource = this.truckerTrackerDataSet;
            // 
            // stopsTableAdapter
            // 
            this.stopsTableAdapter.ClearBeforeFill = true;
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
            this.routeList.Location = new System.Drawing.Point(15, 283);
            this.routeList.MultiSelect = false;
            this.routeList.Name = "routeList";
            this.routeList.ReadOnly = true;
            this.routeList.RowHeadersVisible = false;
            this.routeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.routeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.routeList.ShowEditingIcon = false;
            this.routeList.Size = new System.Drawing.Size(264, 127);
            this.routeList.TabIndex = 24;
            this.routeList.TabStop = false;
            this.routeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RouteList_CellContentClick);
            // 
            // Route
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 549);
            this.Controls.Add(this.routeList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startRoute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.back);
            this.Controls.Add(this.addRoute);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Route";
            this.Text = "Route";
            ((System.ComponentModel.ISupportInitialize)(this.truckerTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Button addRoute;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startRoute;
        private System.Windows.Forms.Button button1;
        private TruckerTrackerDataSet truckerTrackerDataSet;
        private System.Windows.Forms.BindingSource stopsBindingSource;
        private TruckerTrackerDataSetTableAdapters.StopsTableAdapter stopsTableAdapter;
        private System.Windows.Forms.DataGridView routeList;
    }
}