namespace Anilibria
{
    partial class RUSure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RUSure));
            this.label1 = new System.Windows.Forms.Label();
            this.Download_btn = new System.Windows.Forms.Button();
            this.Play_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите действие!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Download_btn
            // 
            this.Download_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Download_btn.Location = new System.Drawing.Point(18, 77);
            this.Download_btn.Name = "Download_btn";
            this.Download_btn.Size = new System.Drawing.Size(103, 39);
            this.Download_btn.TabIndex = 1;
            this.Download_btn.Text = "Download";
            this.Download_btn.UseVisualStyleBackColor = true;
            this.Download_btn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Play_btn
            // 
            this.Play_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play_btn.Location = new System.Drawing.Point(196, 77);
            this.Play_btn.Name = "Play_btn";
            this.Play_btn.Size = new System.Drawing.Size(103, 39);
            this.Play_btn.TabIndex = 2;
            this.Play_btn.Text = "Play";
            this.Play_btn.UseVisualStyleBackColor = true;
            this.Play_btn.Click += new System.EventHandler(this.Play_btn_Click);
            // 
            // RUSure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 154);
            this.Controls.Add(this.Play_btn);
            this.Controls.Add(this.Download_btn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(330, 193);
            this.MinimumSize = new System.Drawing.Size(330, 193);
            this.Name = "RUSure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выберите действие!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Download_btn;
        private System.Windows.Forms.Button Play_btn;
    }
}