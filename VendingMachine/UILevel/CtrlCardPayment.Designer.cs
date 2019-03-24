namespace VendingMachine.UILevel
{
    partial class CtrlCardPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlCardPayment));
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.keypadCard = new VendingMachine.UILevel.Keypad();
            this.btnBack = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(178, 88);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(434, 41);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Invalid";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Visible = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(175, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(440, 79);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Please enter your card number";
            this.lblInstruction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // keypadCard
            // 
            this.keypadCard.BackColor = System.Drawing.Color.Transparent;
            this.keypadCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keypadCard.Location = new System.Drawing.Point(205, 135);
            this.keypadCard.Margin = new System.Windows.Forms.Padding(6);
            this.keypadCard.Name = "keypadCard";
            this.keypadCard.Num = "";
            this.keypadCard.OkButtonName = "Enter";
            this.keypadCard.Size = new System.Drawing.Size(380, 400);
            this.keypadCard.TabIndex = 2;
            this.keypadCard.OkClicked += new VendingMachine.UILevel.Keypad.OkClickedHandler(this.keypadCard_OkClicked);
            this.keypadCard.NumberClicked += new VendingMachine.UILevel.Keypad.NumberClickedHandler(this.keypadCard_NumberClicked);
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
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picLoading
            // 
            this.picLoading.BackColor = System.Drawing.Color.Transparent;
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(195, 155);
            this.picLoading.Margin = new System.Windows.Forms.Padding(7);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(400, 300);
            this.picLoading.TabIndex = 4;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // CtrlCardPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.keypadCard);
            this.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "CtrlCardPayment";
            this.Size = new System.Drawing.Size(790, 610);
            this.Load += new System.EventHandler(this.CtrlCardPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblInstruction;
        private Keypad keypadCard;
        private System.Windows.Forms.PictureBox picLoading;
    }
}
