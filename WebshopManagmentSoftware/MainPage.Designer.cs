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
            this.metroTextBoxID = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProductName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButtonOrderAdd = new MetroFramework.Controls.MetroButton();
            this.metroButtonOrderModify = new MetroFramework.Controls.MetroButton();
            this.metroButtonOrderDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(640, 72);
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
            this.dataGridViewOrders.Size = new System.Drawing.Size(545, 162);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            this.dataGridViewOrders.SelectionChanged += new System.EventHandler(this.dataGridViewOrders_SelectionChanged);
            this.dataGridViewOrders.Click += new System.EventHandler(this.dataGridViewOrders_Click);
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
            this.metroButtonCreateDatabase.Location = new System.Drawing.Point(597, 143);
            this.metroButtonCreateDatabase.Name = "metroButtonCreateDatabase";
            this.metroButtonCreateDatabase.Size = new System.Drawing.Size(167, 23);
            this.metroButtonCreateDatabase.TabIndex = 3;
            this.metroButtonCreateDatabase.Text = "Adatbázis létrehozása";
            this.metroButtonCreateDatabase.Click += new System.EventHandler(this.metroButtonCreateDatabase_Click);
            // 
            // metroButtonDeleteDatabase
            // 
            this.metroButtonDeleteDatabase.Location = new System.Drawing.Point(597, 201);
            this.metroButtonDeleteDatabase.Name = "metroButtonDeleteDatabase";
            this.metroButtonDeleteDatabase.Size = new System.Drawing.Size(167, 23);
            this.metroButtonDeleteDatabase.TabIndex = 4;
            this.metroButtonDeleteDatabase.Text = "Adatbázis törlése";
            this.metroButtonDeleteDatabase.Click += new System.EventHandler(this.metroButtonDeleteDatabase_Click);
            // 
            // metroButtonFillDatabase
            // 
            this.metroButtonFillDatabase.Location = new System.Drawing.Point(597, 114);
            this.metroButtonFillDatabase.Name = "metroButtonFillDatabase";
            this.metroButtonFillDatabase.Size = new System.Drawing.Size(167, 23);
            this.metroButtonFillDatabase.TabIndex = 5;
            this.metroButtonFillDatabase.Text = "Adatbázis feltöltése adatokkal";
            this.metroButtonFillDatabase.Click += new System.EventHandler(this.metroButtonFillDatabase_Click);
            // 
            // metroButtonDeleteData
            // 
            this.metroButtonDeleteData.Location = new System.Drawing.Point(597, 172);
            this.metroButtonDeleteData.Name = "metroButtonDeleteData";
            this.metroButtonDeleteData.Size = new System.Drawing.Size(167, 23);
            this.metroButtonDeleteData.TabIndex = 6;
            this.metroButtonDeleteData.Text = "Adatbázisból adatok törlése";
            this.metroButtonDeleteData.Click += new System.EventHandler(this.metroButtonDeleteData_Click);
            // 
            // metroTextBoxID
            // 
            this.metroTextBoxID.Location = new System.Drawing.Point(168, 240);
            this.metroTextBoxID.Name = "metroTextBoxID";
            this.metroTextBoxID.ReadOnly = true;
            this.metroTextBoxID.Size = new System.Drawing.Size(50, 23);
            this.metroTextBoxID.TabIndex = 7;
            // 
            // metroTextBoxCustomerName
            // 
            this.metroTextBoxCustomerName.Location = new System.Drawing.Point(168, 269);
            this.metroTextBoxCustomerName.Name = "metroTextBoxCustomerName";
            this.metroTextBoxCustomerName.Size = new System.Drawing.Size(108, 23);
            this.metroTextBoxCustomerName.TabIndex = 8;
            // 
            // metroTextBoxProductName
            // 
            this.metroTextBoxProductName.Location = new System.Drawing.Point(168, 298);
            this.metroTextBoxProductName.Name = "metroTextBoxProductName";
            this.metroTextBoxProductName.Size = new System.Drawing.Size(108, 23);
            this.metroTextBoxProductName.TabIndex = 9;
            // 
            // metroTextBoxProductQuantity
            // 
            this.metroTextBoxProductQuantity.Location = new System.Drawing.Point(168, 327);
            this.metroTextBoxProductQuantity.Name = "metroTextBoxProductQuantity";
            this.metroTextBoxProductQuantity.Size = new System.Drawing.Size(108, 23);
            this.metroTextBoxProductQuantity.TabIndex = 10;
            // 
            // metroTextBoxProductPrice
            // 
            this.metroTextBoxProductPrice.Location = new System.Drawing.Point(168, 356);
            this.metroTextBoxProductPrice.Name = "metroTextBoxProductPrice";
            this.metroTextBoxProductPrice.Size = new System.Drawing.Size(110, 23);
            this.metroTextBoxProductPrice.TabIndex = 11;
            // 
            // metroLabelID
            // 
            this.metroLabelID.AutoSize = true;
            this.metroLabelID.Location = new System.Drawing.Point(23, 240);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(21, 19);
            this.metroLabelID.TabIndex = 12;
            this.metroLabelID.Text = "ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 273);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Vásárló neve";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 302);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Termék Neve";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 331);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Termék mennyisége";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 360);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Termék Ára";
            // 
            // metroButtonOrderAdd
            // 
            this.metroButtonOrderAdd.Location = new System.Drawing.Point(331, 240);
            this.metroButtonOrderAdd.Name = "metroButtonOrderAdd";
            this.metroButtonOrderAdd.Size = new System.Drawing.Size(135, 23);
            this.metroButtonOrderAdd.TabIndex = 17;
            this.metroButtonOrderAdd.Text = "Rendelés hozzádása";
            this.metroButtonOrderAdd.Click += new System.EventHandler(this.metroButtonOrderAdd_Click);
            // 
            // metroButtonOrderModify
            // 
            this.metroButtonOrderModify.Location = new System.Drawing.Point(331, 269);
            this.metroButtonOrderModify.Name = "metroButtonOrderModify";
            this.metroButtonOrderModify.Size = new System.Drawing.Size(135, 23);
            this.metroButtonOrderModify.TabIndex = 18;
            this.metroButtonOrderModify.Text = "Rendelés módosítása";
            this.metroButtonOrderModify.Click += new System.EventHandler(this.metroButtonOrderModify_Click);
            // 
            // metroButtonOrderDelete
            // 
            this.metroButtonOrderDelete.Location = new System.Drawing.Point(331, 298);
            this.metroButtonOrderDelete.Name = "metroButtonOrderDelete";
            this.metroButtonOrderDelete.Size = new System.Drawing.Size(135, 23);
            this.metroButtonOrderDelete.TabIndex = 19;
            this.metroButtonOrderDelete.Text = "Rendelés törlése";
            this.metroButtonOrderDelete.Click += new System.EventHandler(this.metroButtonOrderDelete_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroButtonOrderDelete);
            this.Controls.Add(this.metroButtonOrderModify);
            this.Controls.Add(this.metroButtonOrderAdd);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelID);
            this.Controls.Add(this.metroTextBoxProductPrice);
            this.Controls.Add(this.metroTextBoxProductQuantity);
            this.Controls.Add(this.metroTextBoxProductName);
            this.Controls.Add(this.metroTextBoxCustomerName);
            this.Controls.Add(this.metroTextBoxID);
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
            this.Load += new System.EventHandler(this.MainPage_Load);
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
        private MetroFramework.Controls.MetroTextBox metroTextBoxID;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCustomerName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProductName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProductQuantity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProductPrice;
        private MetroFramework.Controls.MetroLabel metroLabelID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButtonOrderAdd;
        private MetroFramework.Controls.MetroButton metroButtonOrderModify;
        private MetroFramework.Controls.MetroButton metroButtonOrderDelete;
    }
}

