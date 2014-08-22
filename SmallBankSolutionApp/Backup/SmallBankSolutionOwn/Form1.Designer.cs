namespace SmallBankSolutionOwn
{
    partial class Form1
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
            this.customerEntryGroupBox = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.openingDateTextBoxEntry = new System.Windows.Forms.TextBox();
            this.accountNumberTextBoxEntry = new System.Windows.Forms.TextBox();
            this.emailTextBoxEntry = new System.Windows.Forms.TextBox();
            this.customerNameTextBoxEntry = new System.Windows.Forms.TextBox();
            this.openingDateLabelEntry = new System.Windows.Forms.Label();
            this.accountNumberLabelEntry = new System.Windows.Forms.Label();
            this.emailLabelEntry = new System.Windows.Forms.Label();
            this.customerNameLabelEntry = new System.Windows.Forms.Label();
            this.customerAccountDisplayGroupBox = new System.Windows.Forms.GroupBox();
            this.balanceTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.openingDateTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.accountNumberTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.emailTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.customerNameTextBoxDisplay = new System.Windows.Forms.TextBox();
            this.balanceLabelDisplay = new System.Windows.Forms.Label();
            this.openingDateLabelDisplay = new System.Windows.Forms.Label();
            this.accountNumberLabelDisplay = new System.Windows.Forms.Label();
            this.emailLabelDisplay = new System.Windows.Forms.Label();
            this.customerNameLabelDisplay = new System.Windows.Forms.Label();
            this.transactionGroupBox = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.customerEntryGroupBox.SuspendLayout();
            this.customerAccountDisplayGroupBox.SuspendLayout();
            this.transactionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerEntryGroupBox
            // 
            this.customerEntryGroupBox.Controls.Add(this.saveButton);
            this.customerEntryGroupBox.Controls.Add(this.openingDateTextBoxEntry);
            this.customerEntryGroupBox.Controls.Add(this.accountNumberTextBoxEntry);
            this.customerEntryGroupBox.Controls.Add(this.emailTextBoxEntry);
            this.customerEntryGroupBox.Controls.Add(this.customerNameTextBoxEntry);
            this.customerEntryGroupBox.Controls.Add(this.openingDateLabelEntry);
            this.customerEntryGroupBox.Controls.Add(this.accountNumberLabelEntry);
            this.customerEntryGroupBox.Controls.Add(this.emailLabelEntry);
            this.customerEntryGroupBox.Controls.Add(this.customerNameLabelEntry);
            this.customerEntryGroupBox.Location = new System.Drawing.Point(9, 9);
            this.customerEntryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerEntryGroupBox.Name = "customerEntryGroupBox";
            this.customerEntryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.customerEntryGroupBox.Size = new System.Drawing.Size(303, 204);
            this.customerEntryGroupBox.TabIndex = 0;
            this.customerEntryGroupBox.TabStop = false;
            this.customerEntryGroupBox.Text = "Customer && Account Info Entry";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(212, 170);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openingDateTextBoxEntry
            // 
            this.openingDateTextBoxEntry.Location = new System.Drawing.Point(105, 137);
            this.openingDateTextBoxEntry.Name = "openingDateTextBoxEntry";
            this.openingDateTextBoxEntry.Size = new System.Drawing.Size(182, 21);
            this.openingDateTextBoxEntry.TabIndex = 7;
            // 
            // accountNumberTextBoxEntry
            // 
            this.accountNumberTextBoxEntry.Location = new System.Drawing.Point(105, 94);
            this.accountNumberTextBoxEntry.Name = "accountNumberTextBoxEntry";
            this.accountNumberTextBoxEntry.Size = new System.Drawing.Size(182, 21);
            this.accountNumberTextBoxEntry.TabIndex = 6;
            // 
            // emailTextBoxEntry
            // 
            this.emailTextBoxEntry.Location = new System.Drawing.Point(105, 61);
            this.emailTextBoxEntry.Name = "emailTextBoxEntry";
            this.emailTextBoxEntry.Size = new System.Drawing.Size(182, 21);
            this.emailTextBoxEntry.TabIndex = 5;
            // 
            // customerNameTextBoxEntry
            // 
            this.customerNameTextBoxEntry.Location = new System.Drawing.Point(105, 29);
            this.customerNameTextBoxEntry.Name = "customerNameTextBoxEntry";
            this.customerNameTextBoxEntry.Size = new System.Drawing.Size(182, 21);
            this.customerNameTextBoxEntry.TabIndex = 4;
            // 
            // openingDateLabelEntry
            // 
            this.openingDateLabelEntry.AutoSize = true;
            this.openingDateLabelEntry.Location = new System.Drawing.Point(16, 140);
            this.openingDateLabelEntry.Name = "openingDateLabelEntry";
            this.openingDateLabelEntry.Size = new System.Drawing.Size(83, 15);
            this.openingDateLabelEntry.TabIndex = 3;
            this.openingDateLabelEntry.Text = "Opening Date";
            // 
            // accountNumberLabelEntry
            // 
            this.accountNumberLabelEntry.AutoSize = true;
            this.accountNumberLabelEntry.Location = new System.Drawing.Point(5, 100);
            this.accountNumberLabelEntry.Name = "accountNumberLabelEntry";
            this.accountNumberLabelEntry.Size = new System.Drawing.Size(98, 15);
            this.accountNumberLabelEntry.TabIndex = 2;
            this.accountNumberLabelEntry.Text = "Account Number";
            // 
            // emailLabelEntry
            // 
            this.emailLabelEntry.AutoSize = true;
            this.emailLabelEntry.Location = new System.Drawing.Point(60, 67);
            this.emailLabelEntry.Name = "emailLabelEntry";
            this.emailLabelEntry.Size = new System.Drawing.Size(39, 15);
            this.emailLabelEntry.TabIndex = 1;
            this.emailLabelEntry.Text = "Email";
            // 
            // customerNameLabelEntry
            // 
            this.customerNameLabelEntry.AutoSize = true;
            this.customerNameLabelEntry.Location = new System.Drawing.Point(6, 32);
            this.customerNameLabelEntry.Name = "customerNameLabelEntry";
            this.customerNameLabelEntry.Size = new System.Drawing.Size(97, 15);
            this.customerNameLabelEntry.TabIndex = 0;
            this.customerNameLabelEntry.Text = "Customer Name";
            // 
            // customerAccountDisplayGroupBox
            // 
            this.customerAccountDisplayGroupBox.Controls.Add(this.showButton);
            this.customerAccountDisplayGroupBox.Controls.Add(this.balanceTextBoxDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.openingDateTextBoxDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.accountNumberTextBoxDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.emailTextBoxDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.customerNameTextBoxDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.balanceLabelDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.openingDateLabelDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.accountNumberLabelDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.emailLabelDisplay);
            this.customerAccountDisplayGroupBox.Controls.Add(this.customerNameLabelDisplay);
            this.customerAccountDisplayGroupBox.Location = new System.Drawing.Point(340, 9);
            this.customerAccountDisplayGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerAccountDisplayGroupBox.Name = "customerAccountDisplayGroupBox";
            this.customerAccountDisplayGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.customerAccountDisplayGroupBox.Size = new System.Drawing.Size(284, 246);
            this.customerAccountDisplayGroupBox.TabIndex = 1;
            this.customerAccountDisplayGroupBox.TabStop = false;
            this.customerAccountDisplayGroupBox.Text = "Customer && Account Info";
            // 
            // balanceTextBoxDisplay
            // 
            this.balanceTextBoxDisplay.Location = new System.Drawing.Point(125, 207);
            this.balanceTextBoxDisplay.Name = "balanceTextBoxDisplay";
            this.balanceTextBoxDisplay.Size = new System.Drawing.Size(158, 21);
            this.balanceTextBoxDisplay.TabIndex = 9;
            // 
            // openingDateTextBoxDisplay
            // 
            this.openingDateTextBoxDisplay.Location = new System.Drawing.Point(125, 172);
            this.openingDateTextBoxDisplay.Name = "openingDateTextBoxDisplay";
            this.openingDateTextBoxDisplay.Size = new System.Drawing.Size(158, 21);
            this.openingDateTextBoxDisplay.TabIndex = 8;
            // 
            // accountNumberTextBoxDisplay
            // 
            this.accountNumberTextBoxDisplay.Location = new System.Drawing.Point(126, 137);
            this.accountNumberTextBoxDisplay.Name = "accountNumberTextBoxDisplay";
            this.accountNumberTextBoxDisplay.Size = new System.Drawing.Size(158, 21);
            this.accountNumberTextBoxDisplay.TabIndex = 7;
            // 
            // emailTextBoxDisplay
            // 
            this.emailTextBoxDisplay.Location = new System.Drawing.Point(125, 100);
            this.emailTextBoxDisplay.Name = "emailTextBoxDisplay";
            this.emailTextBoxDisplay.Size = new System.Drawing.Size(158, 21);
            this.emailTextBoxDisplay.TabIndex = 6;
            // 
            // customerNameTextBoxDisplay
            // 
            this.customerNameTextBoxDisplay.Location = new System.Drawing.Point(126, 67);
            this.customerNameTextBoxDisplay.Name = "customerNameTextBoxDisplay";
            this.customerNameTextBoxDisplay.Size = new System.Drawing.Size(158, 21);
            this.customerNameTextBoxDisplay.TabIndex = 5;
            // 
            // balanceLabelDisplay
            // 
            this.balanceLabelDisplay.AutoSize = true;
            this.balanceLabelDisplay.Location = new System.Drawing.Point(64, 207);
            this.balanceLabelDisplay.Name = "balanceLabelDisplay";
            this.balanceLabelDisplay.Size = new System.Drawing.Size(52, 15);
            this.balanceLabelDisplay.TabIndex = 4;
            this.balanceLabelDisplay.Text = "Balance";
            // 
            // openingDateLabelDisplay
            // 
            this.openingDateLabelDisplay.AutoSize = true;
            this.openingDateLabelDisplay.Location = new System.Drawing.Point(33, 175);
            this.openingDateLabelDisplay.Name = "openingDateLabelDisplay";
            this.openingDateLabelDisplay.Size = new System.Drawing.Size(83, 15);
            this.openingDateLabelDisplay.TabIndex = 3;
            this.openingDateLabelDisplay.Text = "Opening Date";
            // 
            // accountNumberLabelDisplay
            // 
            this.accountNumberLabelDisplay.AutoSize = true;
            this.accountNumberLabelDisplay.Location = new System.Drawing.Point(18, 143);
            this.accountNumberLabelDisplay.Name = "accountNumberLabelDisplay";
            this.accountNumberLabelDisplay.Size = new System.Drawing.Size(98, 15);
            this.accountNumberLabelDisplay.TabIndex = 2;
            this.accountNumberLabelDisplay.Text = "Account Number";
            // 
            // emailLabelDisplay
            // 
            this.emailLabelDisplay.AutoSize = true;
            this.emailLabelDisplay.Location = new System.Drawing.Point(64, 103);
            this.emailLabelDisplay.Name = "emailLabelDisplay";
            this.emailLabelDisplay.Size = new System.Drawing.Size(39, 15);
            this.emailLabelDisplay.TabIndex = 1;
            this.emailLabelDisplay.Text = "Email";
            // 
            // customerNameLabelDisplay
            // 
            this.customerNameLabelDisplay.AutoSize = true;
            this.customerNameLabelDisplay.Location = new System.Drawing.Point(19, 70);
            this.customerNameLabelDisplay.Name = "customerNameLabelDisplay";
            this.customerNameLabelDisplay.Size = new System.Drawing.Size(97, 15);
            this.customerNameLabelDisplay.TabIndex = 0;
            this.customerNameLabelDisplay.Text = "Customer Name";
            // 
            // transactionGroupBox
            // 
            this.transactionGroupBox.Controls.Add(this.withdrawButton);
            this.transactionGroupBox.Controls.Add(this.depositButton);
            this.transactionGroupBox.Controls.Add(this.amountTextBox);
            this.transactionGroupBox.Controls.Add(this.amountLabel);
            this.transactionGroupBox.Location = new System.Drawing.Point(9, 233);
            this.transactionGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.transactionGroupBox.Name = "transactionGroupBox";
            this.transactionGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.transactionGroupBox.Size = new System.Drawing.Size(303, 86);
            this.transactionGroupBox.TabIndex = 2;
            this.transactionGroupBox.TabStop = false;
            this.transactionGroupBox.Text = "Transaction";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(212, 56);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(212, 26);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(61, 35);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(126, 21);
            this.amountTextBox.TabIndex = 1;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(6, 38);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(49, 15);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Small Bank Solution";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(137, 24);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(130, 31);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Customer Details";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionGroupBox);
            this.Controls.Add(this.customerAccountDisplayGroupBox);
            this.Controls.Add(this.customerEntryGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Customer & Account";
            this.customerEntryGroupBox.ResumeLayout(false);
            this.customerEntryGroupBox.PerformLayout();
            this.customerAccountDisplayGroupBox.ResumeLayout(false);
            this.customerAccountDisplayGroupBox.PerformLayout();
            this.transactionGroupBox.ResumeLayout(false);
            this.transactionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox customerEntryGroupBox;
        private System.Windows.Forms.GroupBox customerAccountDisplayGroupBox;
        private System.Windows.Forms.GroupBox transactionGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox openingDateTextBoxEntry;
        private System.Windows.Forms.TextBox accountNumberTextBoxEntry;
        private System.Windows.Forms.TextBox emailTextBoxEntry;
        private System.Windows.Forms.TextBox customerNameTextBoxEntry;
        private System.Windows.Forms.Label openingDateLabelEntry;
        private System.Windows.Forms.Label accountNumberLabelEntry;
        private System.Windows.Forms.Label emailLabelEntry;
        private System.Windows.Forms.Label customerNameLabelEntry;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox balanceTextBoxDisplay;
        private System.Windows.Forms.TextBox openingDateTextBoxDisplay;
        private System.Windows.Forms.TextBox accountNumberTextBoxDisplay;
        private System.Windows.Forms.TextBox emailTextBoxDisplay;
        private System.Windows.Forms.TextBox customerNameTextBoxDisplay;
        private System.Windows.Forms.Label balanceLabelDisplay;
        private System.Windows.Forms.Label openingDateLabelDisplay;
        private System.Windows.Forms.Label accountNumberLabelDisplay;
        private System.Windows.Forms.Label emailLabelDisplay;
        private System.Windows.Forms.Label customerNameLabelDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
    }
}

