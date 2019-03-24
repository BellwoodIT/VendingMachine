namespace VendingMachine.UILevel
{
    partial class CtrlCashPayment
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnProceed = new System.Windows.Forms.Button();
            this.pnlCash = new System.Windows.Forms.Panel();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotalAmtValue = new System.Windows.Forms.Label();
            this.lstCash = new System.Windows.Forms.ListBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn500 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.pnlCash.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::VendingMachine.Properties.Resources.arrow_left_36;
            this.btnBack.Location = new System.Drawing.Point(3, 552);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 55);
            this.btnBack.TabIndex = 1;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(113, 562);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(337, 41);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Invalid";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Visible = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnProceed.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(580, 551);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(200, 55);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // pnlCash
            // 
            this.pnlCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCash.Controls.Add(this.lblChange);
            this.pnlCash.Controls.Add(this.lblTotalAmtValue);
            this.pnlCash.Controls.Add(this.lstCash);
            this.pnlCash.Controls.Add(this.lblTotalAmount);
            this.pnlCash.Location = new System.Drawing.Point(456, 4);
            this.pnlCash.Name = "pnlCash";
            this.pnlCash.Size = new System.Drawing.Size(324, 495);
            this.pnlCash.TabIndex = 5;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(19, 143);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(121, 32);
            this.lblChange.TabIndex = 2;
            this.lblChange.Text = "Change";
            // 
            // lblTotalAmtValue
            // 
            this.lblTotalAmtValue.AutoSize = true;
            this.lblTotalAmtValue.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmtValue.Location = new System.Drawing.Point(19, 59);
            this.lblTotalAmtValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmtValue.Name = "lblTotalAmtValue";
            this.lblTotalAmtValue.Size = new System.Drawing.Size(102, 36);
            this.lblTotalAmtValue.TabIndex = 1;
            this.lblTotalAmtValue.Text = "$00.00";
            // 
            // lstCash
            // 
            this.lstCash.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCash.FormattingEnabled = true;
            this.lstCash.ItemHeight = 33;
            this.lstCash.Location = new System.Drawing.Point(21, 195);
            this.lstCash.Name = "lstCash";
            this.lstCash.Size = new System.Drawing.Size(280, 268);
            this.lstCash.TabIndex = 3;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(19, 16);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(234, 32);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "You need to pay";
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(10, 13);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(440, 87);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Please click the deno button to add on";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::VendingMachine.Properties.Resources.delete_36;
            this.btnCancel.Location = new System.Drawing.Point(470, 551);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 55);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn500
            // 
            this.btn500.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn500.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500.ForeColor = System.Drawing.Color.White;
            this.btn500.Location = new System.Drawing.Point(16, 173);
            this.btn500.Name = "btn500";
            this.btn500.Size = new System.Drawing.Size(104, 55);
            this.btn500.TabIndex = 6;
            this.btn500.Text = "$5";
            this.btn500.UseVisualStyleBackColor = false;
            this.btn500.Click += new System.EventHandler(this.btnDeno_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn100.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.Color.White;
            this.btn100.Location = new System.Drawing.Point(153, 173);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(104, 55);
            this.btn100.TabIndex = 7;
            this.btn100.Text = "$1";
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.btnDeno_Click);
            // 
            // btn25
            // 
            this.btn25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn25.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.ForeColor = System.Drawing.Color.White;
            this.btn25.Location = new System.Drawing.Point(290, 173);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(104, 55);
            this.btn25.TabIndex = 8;
            this.btn25.Text = "25¢";
            this.btn25.UseVisualStyleBackColor = false;
            this.btn25.Click += new System.EventHandler(this.btnDeno_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(153, 259);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(104, 55);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5¢";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnDeno_Click);
            // 
            // btn10
            // 
            this.btn10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn10.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.ForeColor = System.Drawing.Color.White;
            this.btn10.Location = new System.Drawing.Point(16, 259);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(104, 55);
            this.btn10.TabIndex = 9;
            this.btn10.Text = "10¢";
            this.btn10.UseVisualStyleBackColor = false;
            this.btn10.Click += new System.EventHandler(this.btnDeno_Click);
            // 
            // CtrlCashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn25);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.pnlCash);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnBack);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CtrlCashPayment";
            this.Size = new System.Drawing.Size(790, 610);
            this.Load += new System.EventHandler(this.CtrlCashPayment_Load);
            this.pnlCash.ResumeLayout(false);
            this.pnlCash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Panel pnlCash;
        private System.Windows.Forms.ListBox lstCash;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblTotalAmtValue;
        private System.Windows.Forms.Button btn500;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
    }
}
