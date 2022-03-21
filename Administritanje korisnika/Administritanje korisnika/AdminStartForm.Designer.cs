namespace Administritanje_korisnika
{
    partial class AdminStartForm
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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.ActivateUserBtn = new System.Windows.Forms.Button();
            this.DeactivateUserBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users:";
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Location = new System.Drawing.Point(15, 39);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(728, 136);
            this.usersDataGridView.TabIndex = 1;
            this.usersDataGridView.SelectionChanged += new System.EventHandler(this.usersDataGridView_SelectionChanged);
            // 
            // ActivateUserBtn
            // 
            this.ActivateUserBtn.Location = new System.Drawing.Point(35, 195);
            this.ActivateUserBtn.Name = "ActivateUserBtn";
            this.ActivateUserBtn.Size = new System.Drawing.Size(73, 38);
            this.ActivateUserBtn.TabIndex = 2;
            this.ActivateUserBtn.Text = "Activate User";
            this.ActivateUserBtn.UseVisualStyleBackColor = true;
            this.ActivateUserBtn.Click += new System.EventHandler(this.ActivateUserBtn_Click);
            // 
            // DeactivateUserBtn
            // 
            this.DeactivateUserBtn.Location = new System.Drawing.Point(114, 195);
            this.DeactivateUserBtn.Name = "DeactivateUserBtn";
            this.DeactivateUserBtn.Size = new System.Drawing.Size(73, 38);
            this.DeactivateUserBtn.TabIndex = 3;
            this.DeactivateUserBtn.Text = "Deactivate User";
            this.DeactivateUserBtn.UseVisualStyleBackColor = true;
            this.DeactivateUserBtn.Click += new System.EventHandler(this.DeactivateUserBtn_Click);
            // 
            // AdminStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 247);
            this.Controls.Add(this.DeactivateUserBtn);
            this.Controls.Add(this.ActivateUserBtn);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "AdminStartForm";
            this.Text = "Administrators Start Form";
            this.Load += new System.EventHandler(this.AdminStartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.Button ActivateUserBtn;
        private System.Windows.Forms.Button DeactivateUserBtn;
    }
}