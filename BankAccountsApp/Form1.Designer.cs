namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DepositBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BanksAccountsGrid = new DataGridView();
            CreateButtonBtn = new Button();
            WithdrawBtn = new Button();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BanksAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(504, 399);
            DepositBtn.Margin = new Padding(5, 6, 5, 6);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(304, 81);
            DepositBtn.TabIndex = 1;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 88);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 3;
            label1.Text = "Owner:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 427);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 4;
            label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(137, 88);
            OwnerTxt.Margin = new Padding(5, 6, 5, 6);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(317, 35);
            OwnerTxt.TabIndex = 5;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(137, 422);
            AmountNum.Margin = new Padding(5, 6, 5, 6);
            AmountNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 9999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(317, 35);
            AmountNum.TabIndex = 6;
            // 
            // BanksAccountsGrid
            // 
            BanksAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BanksAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BanksAccountsGrid.Location = new Point(504, 88);
            BanksAccountsGrid.Name = "BanksAccountsGrid";
            BanksAccountsGrid.Size = new Size(635, 251);
            BanksAccountsGrid.TabIndex = 7;
            // 
            // CreateButtonBtn
            // 
            CreateButtonBtn.Location = new Point(137, 222);
            CreateButtonBtn.Margin = new Padding(5, 6, 5, 6);
            CreateButtonBtn.Name = "CreateButtonBtn";
            CreateButtonBtn.Size = new Size(317, 64);
            CreateButtonBtn.TabIndex = 9;
            CreateButtonBtn.Text = "Create Account";
            CreateButtonBtn.UseVisualStyleBackColor = true;
            CreateButtonBtn.Click += CreateButtonBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(835, 399);
            WithdrawBtn.Margin = new Padding(5, 6, 5, 6);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(304, 81);
            WithdrawBtn.TabIndex = 10;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(137, 162);
            label3.Name = "label3";
            label3.Size = new Size(171, 30);
            label3.TabIndex = 11;
            label3.Tag = "%";
            label3.Text = "Interest Rate (%):";
            label3.Click += label3_Click;
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(334, 157);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(120, 35);
            InterestRateNum.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 531);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(WithdrawBtn);
            Controls.Add(CreateButtonBtn);
            Controls.Add(BanksAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DepositBtn);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BanksAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button DepositBtn;
        private Button button3;
        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BanksAccountsGrid;
        private Button CreateButtonBtn;
        private Button WithdrawBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
