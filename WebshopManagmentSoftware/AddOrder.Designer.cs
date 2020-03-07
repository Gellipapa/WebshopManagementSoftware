namespace WebshopManagmentSoftware
{
    partial class AddOrder
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
            this.metroButtonOk = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelID = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxProductPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProductQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxProductName = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCustomerName1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxID = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroButtonOk
            // 
            this.metroButtonOk.Location = new System.Drawing.Point(36, 296);
            this.metroButtonOk.Name = "metroButtonOk";
            this.metroButtonOk.Size = new System.Drawing.Size(255, 21);
            this.metroButtonOk.TabIndex = 0;
            this.metroButtonOk.Text = "OK";
            this.metroButtonOk.Click += new System.EventHandler(this.metroButtonOk_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(36, 232);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 26;
            this.metroLabel4.Text = "Termék Ára";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(36, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 19);
            this.metroLabel3.TabIndex = 25;
            this.metroLabel3.Text = "Termék mennyisége";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 174);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(85, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Termék Neve";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 145);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Vásárló neve";
            // 
            // metroLabelID
            // 
            this.metroLabelID.AutoSize = true;
            this.metroLabelID.Location = new System.Drawing.Point(36, 112);
            this.metroLabelID.Name = "metroLabelID";
            this.metroLabelID.Size = new System.Drawing.Size(21, 19);
            this.metroLabelID.TabIndex = 22;
            this.metroLabelID.Text = "ID";
            // 
            // metroTextBoxProductPrice
            // 
            this.metroTextBoxProductPrice.Location = new System.Drawing.Point(181, 228);
            this.metroTextBoxProductPrice.Name = "metroTextBoxProductPrice";
            this.metroTextBoxProductPrice.Size = new System.Drawing.Size(110, 23);
            this.metroTextBoxProductPrice.TabIndex = 21;
            // 
            // metroTextBoxProductQuantity
            // 
            this.metroTextBoxProductQuantity.Location = new System.Drawing.Point(181, 199);
            this.metroTextBoxProductQuantity.Name = "metroTextBoxProductQuantity";
            this.metroTextBoxProductQuantity.Size = new System.Drawing.Size(108, 23);
            this.metroTextBoxProductQuantity.TabIndex = 20;
            // 
            // metroTextBoxProductName
            // 
            this.metroTextBoxProductName.Location = new System.Drawing.Point(181, 170);
            this.metroTextBoxProductName.Name = "metroTextBoxProductName";
            this.metroTextBoxProductName.Size = new System.Drawing.Size(108, 23);
            this.metroTextBoxProductName.TabIndex = 19;
            // 
            // metroTextBoxCustomerName1
            // 
            this.metroTextBoxCustomerName1.Location = new System.Drawing.Point(181, 141);
            this.metroTextBoxCustomerName1.Name = "metroTextBoxCustomerName1";
            this.metroTextBoxCustomerName1.Size = new System.Drawing.Size(108, 23);
            this.metroTextBoxCustomerName1.TabIndex = 18;
            // 
            // metroTextBoxID
            // 
            this.metroTextBoxID.Location = new System.Drawing.Point(181, 112);
            this.metroTextBoxID.Name = "metroTextBoxID";
            this.metroTextBoxID.ReadOnly = true;
            this.metroTextBoxID.Size = new System.Drawing.Size(50, 23);
            this.metroTextBoxID.TabIndex = 17;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroLabelID);
            this.Controls.Add(this.metroTextBoxProductPrice);
            this.Controls.Add(this.metroTextBoxProductQuantity);
            this.Controls.Add(this.metroTextBoxProductName);
            this.Controls.Add(this.metroTextBoxCustomerName1);
            this.Controls.Add(this.metroTextBoxID);
            this.Controls.Add(this.metroButtonOk);
            this.Name = "AddOrder";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "AddOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonOk;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabelID;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProductPrice;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProductQuantity;
        private MetroFramework.Controls.MetroTextBox metroTextBoxProductName;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCustomerName1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxID;
    }
}