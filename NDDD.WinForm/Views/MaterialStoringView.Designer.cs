namespace NDDD.WinForm.Views
{
    partial class MaterialStoringView
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
            this.BarcodeReadTextBox = new System.Windows.Forms.TextBox();
            this.MaterialCodeTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DeliveryRecordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BarcodeReadTextBox
            // 
            this.BarcodeReadTextBox.Location = new System.Drawing.Point(25, 31);
            this.BarcodeReadTextBox.Name = "BarcodeReadTextBox";
            this.BarcodeReadTextBox.Size = new System.Drawing.Size(461, 31);
            this.BarcodeReadTextBox.TabIndex = 6;
            // 
            // MaterialCodeTextBox
            // 
            this.MaterialCodeTextBox.Location = new System.Drawing.Point(25, 90);
            this.MaterialCodeTextBox.Name = "MaterialCodeTextBox";
            this.MaterialCodeTextBox.ReadOnly = true;
            this.MaterialCodeTextBox.Size = new System.Drawing.Size(461, 31);
            this.MaterialCodeTextBox.TabIndex = 9;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(25, 160);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(252, 92);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 92);
            this.button1.TabIndex = 11;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeliveryRecordTextBox
            // 
            this.DeliveryRecordTextBox.Location = new System.Drawing.Point(25, 294);
            this.DeliveryRecordTextBox.Name = "DeliveryRecordTextBox";
            this.DeliveryRecordTextBox.Size = new System.Drawing.Size(461, 31);
            this.DeliveryRecordTextBox.TabIndex = 12;
            // 
            // MaterialStoringView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 510);
            this.Controls.Add(this.DeliveryRecordTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MaterialCodeTextBox);
            this.Controls.Add(this.BarcodeReadTextBox);
            this.Name = "MaterialStoringView";
            this.Text = "";
            this.Controls.SetChildIndex(this.BarcodeReadTextBox, 0);
            this.Controls.SetChildIndex(this.MaterialCodeTextBox, 0);
            this.Controls.SetChildIndex(this.SearchButton, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.DeliveryRecordTextBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BarcodeReadTextBox;
        private System.Windows.Forms.TextBox MaterialCodeTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DeliveryRecordTextBox;
    }
}