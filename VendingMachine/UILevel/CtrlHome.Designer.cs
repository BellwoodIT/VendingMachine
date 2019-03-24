namespace VendingMachine.UILevel
{
    partial class CtrlHome
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblShoppingCart = new System.Windows.Forms.Label();
            this.btnGoToCart = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.keypadCart = new VendingMachine.UILevel.Keypad();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlCart.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(13, 14);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(440, 120);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Please enter the item number and click Enter button to add item into shopping car" +
    "t";
            // 
            // pnlCart
            // 
            this.pnlCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCart.Controls.Add(this.lstCart);
            this.pnlCart.Controls.Add(this.lblShoppingCart);
            this.pnlCart.Location = new System.Drawing.Point(473, 5);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Size = new System.Drawing.Size(310, 495);
            this.pnlCart.TabIndex = 3;
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 33;
            this.lstCart.Location = new System.Drawing.Point(24, 63);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(260, 400);
            this.lstCart.TabIndex = 1;
            // 
            // lblShoppingCart
            // 
            this.lblShoppingCart.AutoSize = true;
            this.lblShoppingCart.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoppingCart.Location = new System.Drawing.Point(19, 16);
            this.lblShoppingCart.Name = "lblShoppingCart";
            this.lblShoppingCart.Size = new System.Drawing.Size(202, 32);
            this.lblShoppingCart.TabIndex = 0;
            this.lblShoppingCart.Text = "Shopping Cart";
            // 
            // btnGoToCart
            // 
            this.btnGoToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGoToCart.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToCart.ForeColor = System.Drawing.Color.White;
            this.btnGoToCart.Location = new System.Drawing.Point(583, 552);
            this.btnGoToCart.Name = "btnGoToCart";
            this.btnGoToCart.Size = new System.Drawing.Size(200, 55);
            this.btnGoToCart.TabIndex = 5;
            this.btnGoToCart.Text = "Go to Cart";
            this.btnGoToCart.UseVisualStyleBackColor = false;
            this.btnGoToCart.Click += new System.EventHandler(this.btnGoToCart_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(19, 546);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(434, 41);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Invalid";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatus.Visible = false;
            // 
            // keypadCart
            // 
            this.keypadCart.BackColor = System.Drawing.Color.Transparent;
            this.keypadCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keypadCart.Location = new System.Drawing.Point(25, 140);
            this.keypadCart.Margin = new System.Windows.Forms.Padding(6);
            this.keypadCart.Name = "keypadCart";
            this.keypadCart.Num = "";
            this.keypadCart.OkButtonName = "Enter";
            this.keypadCart.Size = new System.Drawing.Size(380, 400);
            this.keypadCart.TabIndex = 1;
            this.keypadCart.OkClicked += new VendingMachine.UILevel.Keypad.OkClickedHandler(this.keypadCart_OkClicked);
            this.keypadCart.NumberClicked += new VendingMachine.UILevel.Keypad.NumberClickedHandler(this.keypadCart_NumberClicked);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = global::VendingMachine.Properties.Resources.delete_36;
            this.btnRemove.Location = new System.Drawing.Point(473, 552);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 55);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // CtrlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnGoToCart);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.keypadCart);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CtrlHome";
            this.Size = new System.Drawing.Size(790, 610);
            this.Load += new System.EventHandler(this.CtrlHome_Load);
            this.pnlCart.ResumeLayout(false);
            this.pnlCart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Keypad keypadCart;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblShoppingCart;
        private System.Windows.Forms.Button btnGoToCart;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnRemove;
    }
}
