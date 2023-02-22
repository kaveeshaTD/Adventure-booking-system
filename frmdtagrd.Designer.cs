
namespace adventuresport
{
    partial class frmdtagrd
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
            this.dtagrd = new System.Windows.Forms.DataGridView();
            this.btnview = new System.Windows.Forms.Button();
            this.btndexti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtagrd)).BeginInit();
            this.SuspendLayout();
            // 
            // dtagrd
            // 
            this.dtagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtagrd.Location = new System.Drawing.Point(31, 39);
            this.dtagrd.Name = "dtagrd";
            this.dtagrd.RowHeadersWidth = 51;
            this.dtagrd.RowTemplate.Height = 24;
            this.dtagrd.Size = new System.Drawing.Size(963, 314);
            this.dtagrd.TabIndex = 0;
            // 
            // btnview
            // 
            this.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnview.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(31, 394);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(80, 32);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "view";
            this.btnview.UseVisualStyleBackColor = true;
            this.btnview.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndexti
            // 
            this.btndexti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndexti.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndexti.ForeColor = System.Drawing.Color.White;
            this.btndexti.Location = new System.Drawing.Point(130, 394);
            this.btndexti.Name = "btndexti";
            this.btndexti.Size = new System.Drawing.Size(80, 32);
            this.btndexti.TabIndex = 2;
            this.btndexti.Text = "Exit";
            this.btndexti.UseVisualStyleBackColor = true;
            this.btndexti.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmdtagrd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.btndexti);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dtagrd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmdtagrd";
            this.Text = "frmdtagrd";
            ((System.ComponentModel.ISupportInitialize)(this.dtagrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtagrd;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btndexti;
    }
}