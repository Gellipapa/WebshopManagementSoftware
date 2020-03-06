namespace WebshopManagmentSoftware
{
    partial class MainPage
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
            this.buttonFill = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.metroLabelHiba = new MetroFramework.Controls.MetroLabel();
            this.metroButtonCreateDatabase = new MetroFramework.Controls.MetroButton();
            this.metroButtonDeleteDatabase = new MetroFramework.Controls.MetroButton();
            this.metroButtonFillDatabase = new MetroFramework.Controls.MetroButton();
            this.metroButtonDeleteData = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(622, 72);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 0;
            this.buttonFill.Text = "Feltölt";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(14, 72);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(561, 327);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            // 
            // metroLabelHiba
            // 
            this.metroLabelHiba.AutoSize = true;
            this.metroLabelHiba.Location = new System.Drawing.Point(616, 147);
            this.metroLabelHiba.Name = "metroLabelHiba";
            this.metroLabelHiba.Size = new System.Drawing.Size(0, 0);
            this.metroLabelHiba.TabIndex = 2;
            // 
            // metroButtonCreateDatabase
            // 
            this.metroButtonCreateDatabase.Location = new System.Drawing.Point(610, 229);
            this.metroButtonCreateDatabase.Name = "metroButtonCreateDatabase";
            this.metroButtonCreateDatabase.Size = new System.Drawing.Size(167, 23);
            this.metroButtonCreateDatabase.TabIndex = 3;
            this.metroButtonCreateDatabase.Text = "Adatbázis létrehozása";
            this.metroButtonCreateDatabase.Click += new System.EventHandler(this.metroButtonCreateDatabase_Click);
            // 
            // metroButtonDeleteDatabase
            // 
            this.metroButtonDeleteDatabase.Location = new System.Drawing.Point(610, 327);
            this.metroButtonDeleteDatabase.Name = "metroButtonDeleteDatabase";
            this.metroButtonDeleteDatabase.Size = new System.Drawing.Size(167, 23);
            this.metroButtonDeleteDatabase.TabIndex = 4;
            this.metroButtonDeleteDatabase.Text = "Adatbázis törlése";
            this.metroButtonDeleteDatabase.Click += new System.EventHandler(this.metroButtonDeleteDatabase_Click);
            // 
            // metroButtonFillDatabase
            // 
            this.metroButtonFillDatabase.Location = new System.Drawing.Point(610, 187);
            this.metroButtonFillDatabase.Name = "metroButtonFillDatabase";
            this.metroButtonFillDatabase.Size = new System.Drawing.Size(167, 23);
            this.metroButtonFillDatabase.TabIndex = 5;
            this.metroButtonFillDatabase.Text = "Adatbázis feltöltése adatokkal";
            this.metroButtonFillDatabase.Click += new System.EventHandler(this.metroButtonFillDatabase_Click);
            // 
            // metroButtonDeleteData
            // 
            this.metroButtonDeleteData.Location = new System.Drawing.Point(610, 289);
            this.metroButtonDeleteData.Name = "metroButtonDeleteData";
            this.metroButtonDeleteData.Size = new System.Drawing.Size(167, 23);
            this.metroButtonDeleteData.TabIndex = 6;
            this.metroButtonDeleteData.Text = "Adatbázisból adatok törlése";
            this.metroButtonDeleteData.Click += new System.EventHandler(this.metroButtonDeleteData_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButtonDeleteData);
            this.Controls.Add(this.metroButtonFillDatabase);
            this.Controls.Add(this.metroButtonDeleteDatabase);
            this.Controls.Add(this.metroButtonCreateDatabase);
            this.Controls.Add(this.metroLabelHiba);
            this.Controls.Add(this.dataGridViewOrders);
            this.Controls.Add(this.buttonFill);
            this.Name = "MainPage";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Kezdőlap";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private MetroFramework.Controls.MetroLabel metroLabelHiba;
        private MetroFramework.Controls.MetroButton metroButtonCreateDatabase;
        private MetroFramework.Controls.MetroButton metroButtonDeleteDatabase;
        private MetroFramework.Controls.MetroButton metroButtonFillDatabase;
        private MetroFramework.Controls.MetroButton metroButtonDeleteData;
    }
}

