namespace Store_App
{
    partial class ProductInfoForm
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
            this.ProductInfoNextButton = new System.Windows.Forms.Button();
            this.ProductInfoCancelButton = new System.Windows.Forms.Button();
            this.ProductInfoBackButton = new System.Windows.Forms.Button();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDDataLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostDataLabel = new System.Windows.Forms.Label();
            this.ProductInfoUpperGroupBox = new System.Windows.Forms.GroupBox();
            this.ProductInfoLowerGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ProductInfoNextButton
            // 
            this.ProductInfoNextButton.Location = new System.Drawing.Point(726, 342);
            this.ProductInfoNextButton.Name = "ProductInfoNextButton";
            this.ProductInfoNextButton.Size = new System.Drawing.Size(75, 23);
            this.ProductInfoNextButton.TabIndex = 0;
            this.ProductInfoNextButton.Text = "Next";
            this.ProductInfoNextButton.UseVisualStyleBackColor = true;
            this.ProductInfoNextButton.Click += new System.EventHandler(this.ProductInfoNextButton_Click);
            // 
            // ProductInfoCancelButton
            // 
            this.ProductInfoCancelButton.Location = new System.Drawing.Point(632, 342);
            this.ProductInfoCancelButton.Name = "ProductInfoCancelButton";
            this.ProductInfoCancelButton.Size = new System.Drawing.Size(75, 23);
            this.ProductInfoCancelButton.TabIndex = 0;
            this.ProductInfoCancelButton.Text = "Cancel";
            this.ProductInfoCancelButton.UseVisualStyleBackColor = true;
            this.ProductInfoCancelButton.Click += new System.EventHandler(this.ProductInfoCancelButton_Click);
            // 
            // ProductInfoBackButton
            // 
            this.ProductInfoBackButton.Location = new System.Drawing.Point(470, 342);
            this.ProductInfoBackButton.Name = "ProductInfoBackButton";
            this.ProductInfoBackButton.Size = new System.Drawing.Size(143, 23);
            this.ProductInfoBackButton.TabIndex = 0;
            this.ProductInfoBackButton.Text = "Select Another Product";
            this.ProductInfoBackButton.UseVisualStyleBackColor = true;
            this.ProductInfoBackButton.Click += new System.EventHandler(this.ProductInfoBackButton_Click);
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.Location = new System.Drawing.Point(25, 9);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(123, 40);
            this.ProductIDLabel.TabIndex = 1;
            this.ProductIDLabel.Text = "Product ID";
            this.ProductIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDDataLabel
            // 
            this.ProductIDDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProductIDDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIDDataLabel.Location = new System.Drawing.Point(134, 9);
            this.ProductIDDataLabel.Name = "ProductIDDataLabel";
            this.ProductIDDataLabel.Size = new System.Drawing.Size(123, 40);
            this.ProductIDDataLabel.TabIndex = 1;
            this.ProductIDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Location = new System.Drawing.Point(269, 9);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(123, 40);
            this.ConditionLabel.TabIndex = 1;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConditionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionDataLabel.Location = new System.Drawing.Point(378, 9);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(123, 40);
            this.ConditionDataLabel.TabIndex = 1;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostLabel
            // 
            this.CostLabel.Location = new System.Drawing.Point(523, 9);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(123, 40);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            this.CostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CostDataLabel
            // 
            this.CostDataLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CostDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostDataLabel.Location = new System.Drawing.Point(632, 9);
            this.CostDataLabel.Name = "CostDataLabel";
            this.CostDataLabel.Size = new System.Drawing.Size(123, 40);
            this.CostDataLabel.TabIndex = 1;
            this.CostDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductInfoUpperGroupBox
            // 
            this.ProductInfoUpperGroupBox.Location = new System.Drawing.Point(28, 52);
            this.ProductInfoUpperGroupBox.Name = "ProductInfoUpperGroupBox";
            this.ProductInfoUpperGroupBox.Size = new System.Drawing.Size(747, 117);
            this.ProductInfoUpperGroupBox.TabIndex = 2;
            this.ProductInfoUpperGroupBox.TabStop = false;
            this.ProductInfoUpperGroupBox.Text = "Product Info";
            // 
            // ProductInfoLowerGroupBox
            // 
            this.ProductInfoLowerGroupBox.Location = new System.Drawing.Point(28, 215);
            this.ProductInfoLowerGroupBox.Name = "ProductInfoLowerGroupBox";
            this.ProductInfoLowerGroupBox.Size = new System.Drawing.Size(747, 111);
            this.ProductInfoLowerGroupBox.TabIndex = 2;
            this.ProductInfoLowerGroupBox.TabStop = false;
            this.ProductInfoLowerGroupBox.Text = "Product Info";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 381);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoLowerGroupBox);
            this.Controls.Add(this.ProductInfoUpperGroupBox);
            this.Controls.Add(this.CostDataLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionDataLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDDataLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoBackButton);
            this.Controls.Add(this.ProductInfoCancelButton);
            this.Controls.Add(this.ProductInfoNextButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductInfoNextButton;
        private System.Windows.Forms.Button ProductInfoCancelButton;
        private System.Windows.Forms.Button ProductInfoBackButton;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label ProductIDDataLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label CostDataLabel;
        private System.Windows.Forms.GroupBox ProductInfoUpperGroupBox;
        private System.Windows.Forms.GroupBox ProductInfoLowerGroupBox;
    }
}