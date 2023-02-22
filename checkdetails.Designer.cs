
namespace adventuresport
{
    partial class frmcheckdetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcheckdetails));
            this.lbldetls = new System.Windows.Forms.Label();
            this.btnccancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldetls
            // 
            this.lbldetls.AutoSize = true;
            this.lbldetls.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetls.ForeColor = System.Drawing.Color.White;
            this.lbldetls.Location = new System.Drawing.Point(22, 9);
            this.lbldetls.Name = "lbldetls";
            this.lbldetls.Size = new System.Drawing.Size(367, 459);
            this.lbldetls.TabIndex = 0;
            this.lbldetls.Text = resources.GetString("lbldetls.Text");
            // 
            // btnccancel
            // 
            this.btnccancel.FlatAppearance.BorderSize = 0;
            this.btnccancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnccancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnccancel.ForeColor = System.Drawing.Color.White;
            this.btnccancel.Location = new System.Drawing.Point(391, -3);
            this.btnccancel.Name = "btnccancel";
            this.btnccancel.Size = new System.Drawing.Size(59, 36);
            this.btnccancel.TabIndex = 1;
            this.btnccancel.Text = "X";
            this.btnccancel.UseVisualStyleBackColor = true;
            this.btnccancel.Click += new System.EventHandler(this.btnccancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(36, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "* The maximum number of participants per sport is 12 *";
            // 
            // frmcheckdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(438, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnccancel);
            this.Controls.Add(this.lbldetls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcheckdetails";
            this.Text = "check details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldetls;
        private System.Windows.Forms.Button btnccancel;
        private System.Windows.Forms.Label label1;
    }
}