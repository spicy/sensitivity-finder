
namespace SensitivityFinder
{
    partial class FormTraining
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
            this.targetBtn = new System.Windows.Forms.Button();
            this.mousePanel = new System.Windows.Forms.Panel();
            this.missTypeLbl = new System.Windows.Forms.Label();
            this.countLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // targetBtn
            // 
            this.targetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.targetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.targetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.targetBtn.Location = new System.Drawing.Point(12, 76);
            this.targetBtn.Name = "targetBtn";
            this.targetBtn.Size = new System.Drawing.Size(40, 40);
            this.targetBtn.TabIndex = 2;
            this.targetBtn.UseVisualStyleBackColor = false;
            // 
            // mousePanel
            // 
            this.mousePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mousePanel.Location = new System.Drawing.Point(502, 366);
            this.mousePanel.Name = "mousePanel";
            this.mousePanel.Size = new System.Drawing.Size(10, 10);
            this.mousePanel.TabIndex = 4;
            // 
            // missTypeLbl
            // 
            this.missTypeLbl.AutoSize = true;
            this.missTypeLbl.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missTypeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.missTypeLbl.Location = new System.Drawing.Point(8, 9);
            this.missTypeLbl.Name = "missTypeLbl";
            this.missTypeLbl.Size = new System.Drawing.Size(99, 20);
            this.missTypeLbl.TabIndex = 5;
            this.missTypeLbl.Text = "Miss Type";
            // 
            // countLbl
            // 
            this.countLbl.AutoSize = true;
            this.countLbl.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.countLbl.Location = new System.Drawing.Point(8, 33);
            this.countLbl.Name = "countLbl";
            this.countLbl.Size = new System.Drawing.Size(59, 20);
            this.countLbl.TabIndex = 6;
            this.countLbl.Text = "Count";
            // 
            // FormTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.countLbl);
            this.Controls.Add(this.missTypeLbl);
            this.Controls.Add(this.mousePanel);
            this.Controls.Add(this.targetBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormTraining";
            this.Text = "FormTraining";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTraining_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTraining_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button targetBtn;
        private System.Windows.Forms.Panel mousePanel;
        private System.Windows.Forms.Label missTypeLbl;
        private System.Windows.Forms.Label countLbl;
    }
}