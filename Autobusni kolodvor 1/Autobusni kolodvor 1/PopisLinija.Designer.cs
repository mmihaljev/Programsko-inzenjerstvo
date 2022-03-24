namespace Autobusni_kolodvor_1
{
    partial class PopisLinija
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
            this.label1 = new System.Windows.Forms.Label();
            this.LinijeDataGridView = new System.Windows.Forms.DataGridView();
            this.OdustaniBtn = new System.Windows.Forms.Button();
            this.OdaberiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LinijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autobusne linije:";
            // 
            // LinijeDataGridView
            // 
            this.LinijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinijeDataGridView.Location = new System.Drawing.Point(15, 25);
            this.LinijeDataGridView.Name = "LinijeDataGridView";
            this.LinijeDataGridView.Size = new System.Drawing.Size(641, 196);
            this.LinijeDataGridView.TabIndex = 1;
            // 
            // OdustaniBtn
            // 
            this.OdustaniBtn.Location = new System.Drawing.Point(579, 227);
            this.OdustaniBtn.Name = "OdustaniBtn";
            this.OdustaniBtn.Size = new System.Drawing.Size(77, 26);
            this.OdustaniBtn.TabIndex = 2;
            this.OdustaniBtn.Text = "Odustani";
            this.OdustaniBtn.UseVisualStyleBackColor = true;
            this.OdustaniBtn.Click += new System.EventHandler(this.OdustaniBtn_Click);
            // 
            // OdaberiBtn
            // 
            this.OdaberiBtn.Location = new System.Drawing.Point(496, 227);
            this.OdaberiBtn.Name = "OdaberiBtn";
            this.OdaberiBtn.Size = new System.Drawing.Size(77, 26);
            this.OdaberiBtn.TabIndex = 3;
            this.OdaberiBtn.Text = "Odaberi";
            this.OdaberiBtn.UseVisualStyleBackColor = true;
            this.OdaberiBtn.Click += new System.EventHandler(this.OdaberiBtn_Click);
            // 
            // PopisLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 258);
            this.Controls.Add(this.OdaberiBtn);
            this.Controls.Add(this.OdustaniBtn);
            this.Controls.Add(this.LinijeDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "PopisLinija";
            this.Text = "PopisLinija";
            this.Load += new System.EventHandler(this.PopisLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LinijeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LinijeDataGridView;
        private System.Windows.Forms.Button OdustaniBtn;
        private System.Windows.Forms.Button OdaberiBtn;
    }
}