namespace NDDD.WinForm.Views
{
    partial class UserLoginView
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.PassWordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(56, 267);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(380, 61);
            this.SearchButton.TabIndex = 13;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PassWordTextBox
            // 
            this.PassWordTextBox.Location = new System.Drawing.Point(184, 183);
            this.PassWordTextBox.Name = "PassWordTextBox";
            this.PassWordTextBox.ReadOnly = true;
            this.PassWordTextBox.Size = new System.Drawing.Size(252, 31);
            this.PassWordTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "PASSWORD";
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(184, 106);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.ReadOnly = true;
            this.UserNameTextBox.Size = new System.Drawing.Size(252, 31);
            this.UserNameTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "USERNAME";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(184, 36);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.ReadOnly = true;
            this.UserIdTextBox.Size = new System.Drawing.Size(252, 31);
            this.UserIdTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "USERID";
            // 
            // UserLoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 385);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PassWordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UserLoginView";
            this.Text = "UserLoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox PassWordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.Label label1;
    }
}