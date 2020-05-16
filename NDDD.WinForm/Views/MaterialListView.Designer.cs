namespace NDDD.WinForm.Views
{
    partial class MaterialListView
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
            this.MaterialDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialDataGrid
            // 
            this.MaterialDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MaterialDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialDataGrid.Location = new System.Drawing.Point(0, 0);
            this.MaterialDataGrid.Name = "MaterialDataGrid";
            this.MaterialDataGrid.RowHeadersWidth = 82;
            this.MaterialDataGrid.RowTemplate.Height = 33;
            this.MaterialDataGrid.Size = new System.Drawing.Size(1216, 794);
            this.MaterialDataGrid.TabIndex = 0;
            // 
            // MaterialListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 794);
            this.Controls.Add(this.MaterialDataGrid);
            this.Name = "MaterialListView";
            this.Text = "MaterialListView";
            ((System.ComponentModel.ISupportInitialize)(this.MaterialDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MaterialDataGrid;
    }
}