namespace Store_App
{
    partial class OrderForm
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
            this.OrderFormFinishButton = new System.Windows.Forms.Button();
            this.OrderFormCancelButton = new System.Windows.Forms.Button();
            this.OrderFormBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OrderFormFinishButton
            // 
            this.OrderFormFinishButton.Location = new System.Drawing.Point(707, 346);
            this.OrderFormFinishButton.Name = "OrderFormFinishButton";
            this.OrderFormFinishButton.Size = new System.Drawing.Size(75, 23);
            this.OrderFormFinishButton.TabIndex = 0;
            this.OrderFormFinishButton.Text = "Finish";
            this.OrderFormFinishButton.UseVisualStyleBackColor = true;
            // 
            // OrderFormCancelButton
            // 
            this.OrderFormCancelButton.Location = new System.Drawing.Point(610, 346);
            this.OrderFormCancelButton.Name = "OrderFormCancelButton";
            this.OrderFormCancelButton.Size = new System.Drawing.Size(75, 23);
            this.OrderFormCancelButton.TabIndex = 0;
            this.OrderFormCancelButton.Text = "Cancel";
            this.OrderFormCancelButton.UseVisualStyleBackColor = true;
            this.OrderFormCancelButton.Click += new System.EventHandler(this.OrderFormCancelButton_Click);
            // 
            // OrderFormBackButton
            // 
            this.OrderFormBackButton.Location = new System.Drawing.Point(497, 346);
            this.OrderFormBackButton.Name = "OrderFormBackButton";
            this.OrderFormBackButton.Size = new System.Drawing.Size(75, 23);
            this.OrderFormBackButton.TabIndex = 0;
            this.OrderFormBackButton.Text = "Back";
            this.OrderFormBackButton.UseVisualStyleBackColor = true;
            this.OrderFormBackButton.Click += new System.EventHandler(this.OrderFormBackButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 381);
            this.ControlBox = false;
            this.Controls.Add(this.OrderFormBackButton);
            this.Controls.Add(this.OrderFormCancelButton);
            this.Controls.Add(this.OrderFormFinishButton);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OrderFormFinishButton;
        private System.Windows.Forms.Button OrderFormCancelButton;
        private System.Windows.Forms.Button OrderFormBackButton;
    }
}