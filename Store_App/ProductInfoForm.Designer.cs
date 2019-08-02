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
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 381);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoBackButton);
            this.Controls.Add(this.ProductInfoCancelButton);
            this.Controls.Add(this.ProductInfoNextButton);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductInfoForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ProductInfoNextButton;
        private System.Windows.Forms.Button ProductInfoCancelButton;
        private System.Windows.Forms.Button ProductInfoBackButton;
    }
}