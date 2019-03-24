namespace VendingMachine.UILevel
{
    partial class CtrlCheckout
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
            this.btnProceed = new System.Windows.Forms.Button();
            this.lblTotalAmtValue = new System.Windows.Forms.Label();
            this.lblTotalAmt = new System.Windows.Forms.Label();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.grpPaymentMethod = new System.Windows.Forms.GroupBox();
            this.lblTransactionFee = new System.Windows.Forms.Label();
            this.lblTransactionAmtValue = new System.Windows.Forms.Label();
            this.grpPaymentMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnProceed.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.White;
            this.btnProceed.Location = new System.Drawing.Point(514, 395);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(200, 55);
            this.btnProceed.TabIndex = 5;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // lblTotalAmtValue
            // 
            this.lblTotalAmtValue.AutoSize = true;
            this.lblTotalAmtValue.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmtValue.Location = new System.Drawing.Point(508, 332);
            this.lblTotalAmtValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmtValue.Name = "lblTotalAmtValue";
            this.lblTotalAmtValue.Size = new System.Drawing.Size(103, 36);
            this.lblTotalAmtValue.TabIndex = 4;
            this.lblTotalAmtValue.Text = "$00.00";
            // 
            // lblTotalAmt
            // 
            this.lblTotalAmt.AutoSize = true;
            this.lblTotalAmt.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmt.Location = new System.Drawing.Point(509, 275);
            this.lblTotalAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAmt.Name = "lblTotalAmt";
            this.lblTotalAmt.Size = new System.Drawing.Size(77, 30);
            this.lblTotalAmt.TabIndex = 3;
            this.lblTotalAmt.Text = "Total:";
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(6, 67);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(416, 34);
            this.radCreditCard.TabIndex = 0;
            this.radCreditCard.Text = "Credit Card (5% Transaction fee)";
            this.radCreditCard.UseVisualStyleBackColor = true;
            this.radCreditCard.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Checked = true;
            this.radCash.Location = new System.Drawing.Point(6, 154);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(92, 34);
            this.radCash.TabIndex = 1;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            this.radCash.CheckedChanged += new System.EventHandler(this.radCreditCard_CheckedChanged);
            // 
            // grpPaymentMethod
            // 
            this.grpPaymentMethod.Controls.Add(this.radCreditCard);
            this.grpPaymentMethod.Controls.Add(this.radCash);
            this.grpPaymentMethod.Location = new System.Drawing.Point(31, 178);
            this.grpPaymentMethod.Name = "grpPaymentMethod";
            this.grpPaymentMethod.Size = new System.Drawing.Size(445, 255);
            this.grpPaymentMethod.TabIndex = 0;
            this.grpPaymentMethod.TabStop = false;
            this.grpPaymentMethod.Text = "Payment Method";
            // 
            // lblTransactionFee
            // 
            this.lblTransactionFee.AutoSize = true;
            this.lblTransactionFee.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionFee.Location = new System.Drawing.Point(509, 161);
            this.lblTransactionFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionFee.Name = "lblTransactionFee";
            this.lblTransactionFee.Size = new System.Drawing.Size(261, 30);
            this.lblTransactionFee.TabIndex = 1;
            this.lblTransactionFee.Text = "+ 5% Transaction Fee";
            this.lblTransactionFee.Visible = false;
            // 
            // lblTransactionAmtValue
            // 
            this.lblTransactionAmtValue.AutoSize = true;
            this.lblTransactionAmtValue.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionAmtValue.Location = new System.Drawing.Point(509, 218);
            this.lblTransactionAmtValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransactionAmtValue.Name = "lblTransactionAmtValue";
            this.lblTransactionAmtValue.Size = new System.Drawing.Size(71, 30);
            this.lblTransactionAmtValue.TabIndex = 2;
            this.lblTransactionAmtValue.Text = "S0.00";
            this.lblTransactionAmtValue.Visible = false;
            // 
            // CtrlCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTransactionAmtValue);
            this.Controls.Add(this.lblTransactionFee);
            this.Controls.Add(this.grpPaymentMethod);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.lblTotalAmtValue);
            this.Controls.Add(this.lblTotalAmt);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CtrlCheckout";
            this.Size = new System.Drawing.Size(790, 610);
            this.Load += new System.EventHandler(this.CtrlCheckout_Load);
            this.grpPaymentMethod.ResumeLayout(false);
            this.grpPaymentMethod.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Label lblTotalAmtValue;
        private System.Windows.Forms.Label lblTotalAmt;
        private System.Windows.Forms.RadioButton radCreditCard;
        private System.Windows.Forms.RadioButton radCash;
        private System.Windows.Forms.GroupBox grpPaymentMethod;
        private System.Windows.Forms.Label lblTransactionFee;
        private System.Windows.Forms.Label lblTransactionAmtValue;
    }
}
