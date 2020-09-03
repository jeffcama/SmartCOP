namespace SmartCOP
{
    partial class Form1
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
            this.cboDrinkType = new System.Windows.Forms.ComboBox();
            this.chkCarbonated = new System.Windows.Forms.CheckBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lstDrinkList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDrinkType = new System.Windows.Forms.Label();
            this.lblDrinkName = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnMode = new System.Windows.Forms.Button();
            this.txtMainDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboDrinkType
            // 
            this.cboDrinkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrinkType.FormattingEnabled = true;
            this.cboDrinkType.Items.AddRange(new object[] {
            "Beer",
            "Juice",
            "Soda"});
            this.cboDrinkType.Location = new System.Drawing.Point(12, 228);
            this.cboDrinkType.Name = "cboDrinkType";
            this.cboDrinkType.Size = new System.Drawing.Size(121, 21);
            this.cboDrinkType.TabIndex = 0;
            this.cboDrinkType.Visible = false;
            this.cboDrinkType.SelectedIndexChanged += new System.EventHandler(this.cbDrinkType_SelectedIndexChanged);
            // 
            // chkCarbonated
            // 
            this.chkCarbonated.AutoSize = true;
            this.chkCarbonated.Enabled = false;
            this.chkCarbonated.Location = new System.Drawing.Point(262, 230);
            this.chkCarbonated.Name = "chkCarbonated";
            this.chkCarbonated.Size = new System.Drawing.Size(81, 17);
            this.chkCarbonated.TabIndex = 2;
            this.chkCarbonated.Text = "Carbonated";
            this.chkCarbonated.UseVisualStyleBackColor = true;
            this.chkCarbonated.Visible = false;
            // 
            // txtDetails
            // 
            this.txtDetails.Enabled = false;
            this.txtDetails.Location = new System.Drawing.Point(349, 228);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(219, 20);
            this.txtDetails.TabIndex = 3;
            this.txtDetails.Visible = false;
            // 
            // lstDrinkList
            // 
            this.lstDrinkList.FormattingEnabled = true;
            this.lstDrinkList.Location = new System.Drawing.Point(12, 12);
            this.lstDrinkList.Name = "lstDrinkList";
            this.lstDrinkList.Size = new System.Drawing.Size(638, 147);
            this.lstDrinkList.TabIndex = 5;
            this.lstDrinkList.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(575, 226);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Drink";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(139, 229);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(115, 166);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDrinkType
            // 
            this.lblDrinkType.AutoSize = true;
            this.lblDrinkType.Location = new System.Drawing.Point(12, 209);
            this.lblDrinkType.Name = "lblDrinkType";
            this.lblDrinkType.Size = new System.Drawing.Size(62, 13);
            this.lblDrinkType.TabIndex = 7;
            this.lblDrinkType.Text = "Drink Type:";
            this.lblDrinkType.Visible = false;
            // 
            // lblDrinkName
            // 
            this.lblDrinkName.AutoSize = true;
            this.lblDrinkName.Location = new System.Drawing.Point(139, 209);
            this.lblDrinkName.Name = "lblDrinkName";
            this.lblDrinkName.Size = new System.Drawing.Size(66, 13);
            this.lblDrinkName.TabIndex = 8;
            this.lblDrinkName.Text = "Drink Name:";
            this.lblDrinkName.Visible = false;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(349, 208);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(42, 13);
            this.lblDetails.TabIndex = 9;
            this.lblDetails.Text = "Details:";
            this.lblDetails.Visible = false;
            // 
            // btnMode
            // 
            this.btnMode.Location = new System.Drawing.Point(15, 166);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(94, 23);
            this.btnMode.TabIndex = 10;
            this.btnMode.Text = "Edit List";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // txtMainDisplay
            // 
            this.txtMainDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtMainDisplay.Multiline = true;
            this.txtMainDisplay.Name = "txtMainDisplay";
            this.txtMainDisplay.ReadOnly = true;
            this.txtMainDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMainDisplay.Size = new System.Drawing.Size(638, 148);
            this.txtMainDisplay.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 196);
            this.Controls.Add(this.txtMainDisplay);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDrinkName);
            this.Controls.Add(this.lblDrinkType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstDrinkList);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.chkCarbonated);
            this.Controls.Add(this.cboDrinkType);
            this.Name = "Form1";
            this.Text = "SmartCOP Drink List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDrinkType;
        private System.Windows.Forms.CheckBox chkCarbonated;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.ListBox lstDrinkList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDrinkType;
        private System.Windows.Forms.Label lblDrinkName;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnMode;
        private System.Windows.Forms.TextBox txtMainDisplay;
    }
}

