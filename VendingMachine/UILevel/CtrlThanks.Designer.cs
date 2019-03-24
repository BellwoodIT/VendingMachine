namespace VendingMachine.UILevel
{
    partial class CtrlThanks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDone = new System.Windows.Forms.Button();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblTips = new System.Windows.Forms.Label();
            this.lblRefNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnDone.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(295, 547);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(200, 55);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblThanks
            // 
            this.lblThanks.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(80, 9);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(630, 60);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "Thank you for your payment";
            this.lblThanks.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(86, 89);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(624, 60);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Thank You";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTips
            // 
            this.lblTips.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTips.Location = new System.Drawing.Point(83, 249);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(624, 250);
            this.lblTips.TabIndex = 3;
            this.lblTips.Text = "Thank You";
            this.lblTips.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRefNo
            // 
            this.lblRefNo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefNo.Location = new System.Drawing.Point(86, 169);
            this.lblRefNo.Name = "lblRefNo";
            this.lblRefNo.Size = new System.Drawing.Size(624, 60);
            this.lblRefNo.TabIndex = 2;
            this.lblRefNo.Text = "Thank You";
            this.lblRefNo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CtrlThanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblRefNo);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblThanks);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CtrlThanks";
            this.Size = new System.Drawing.Size(790, 610);
            this.Load += new System.EventHandler(this.CtrlThanks_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblRefNo;
    }
}
