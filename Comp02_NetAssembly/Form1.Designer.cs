namespace Comp02_NetAssembly
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
            this.tbStockInput = new System.Windows.Forms.TextBox();
            this.btnStockQuoteSync = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockOutput = new System.Windows.Forms.TextBox();
            this.btnStockQuoteAsync = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIpGeoOutput = new System.Windows.Forms.TextBox();
            this.btnIpgeoAsync = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIpgeoSync = new System.Windows.Forms.Button();
            this.tbIpGeoInput = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTimeOutput = new System.Windows.Forms.TextBox();
            this.btnTimeAsync = new System.Windows.Forms.Button();
            this.btnTimeSync = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEchoOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEchoSync = new System.Windows.Forms.Button();
            this.tbEchoInput = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOrderOutput = new System.Windows.Forms.TextBox();
            this.btnOrderAsync = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnOrderSync = new System.Windows.Forms.Button();
            this.tbOrderer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbVoivodeship = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStockInput
            // 
            this.tbStockInput.Location = new System.Drawing.Point(59, 19);
            this.tbStockInput.Name = "tbStockInput";
            this.tbStockInput.Size = new System.Drawing.Size(113, 20);
            this.tbStockInput.TabIndex = 0;
            this.tbStockInput.Text = "GOOG";
            // 
            // btnStockQuoteSync
            // 
            this.btnStockQuoteSync.Location = new System.Drawing.Point(59, 45);
            this.btnStockQuoteSync.Name = "btnStockQuoteSync";
            this.btnStockQuoteSync.Size = new System.Drawing.Size(50, 23);
            this.btnStockQuoteSync.TabIndex = 1;
            this.btnStockQuoteSync.Text = "Sync";
            this.btnStockQuoteSync.UseVisualStyleBackColor = true;
            this.btnStockQuoteSync.Click += new System.EventHandler(this.btnStockQuoteSync_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbStockOutput);
            this.groupBox1.Controls.Add(this.btnStockQuoteAsync);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnStockQuoteSync);
            this.groupBox1.Controls.Add(this.tbStockInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Quote";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output:";
            // 
            // tbStockOutput
            // 
            this.tbStockOutput.Location = new System.Drawing.Point(59, 74);
            this.tbStockOutput.Name = "tbStockOutput";
            this.tbStockOutput.Size = new System.Drawing.Size(113, 20);
            this.tbStockOutput.TabIndex = 3;
            // 
            // btnStockQuoteAsync
            // 
            this.btnStockQuoteAsync.Location = new System.Drawing.Point(122, 45);
            this.btnStockQuoteAsync.Name = "btnStockQuoteAsync";
            this.btnStockQuoteAsync.Size = new System.Drawing.Size(50, 23);
            this.btnStockQuoteAsync.TabIndex = 2;
            this.btnStockQuoteAsync.Text = "Async";
            this.btnStockQuoteAsync.UseVisualStyleBackColor = true;
            this.btnStockQuoteAsync.Click += new System.EventHandler(this.btnStockQuoteAsync_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbIpGeoOutput);
            this.groupBox2.Controls.Add(this.btnIpgeoAsync);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnIpgeoSync);
            this.groupBox2.Controls.Add(this.tbIpGeoInput);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ip2geo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output:";
            // 
            // tbIpGeoOutput
            // 
            this.tbIpGeoOutput.Location = new System.Drawing.Point(59, 74);
            this.tbIpGeoOutput.Multiline = true;
            this.tbIpGeoOutput.Name = "tbIpGeoOutput";
            this.tbIpGeoOutput.Size = new System.Drawing.Size(113, 103);
            this.tbIpGeoOutput.TabIndex = 3;
            // 
            // btnIpgeoAsync
            // 
            this.btnIpgeoAsync.Location = new System.Drawing.Point(122, 45);
            this.btnIpgeoAsync.Name = "btnIpgeoAsync";
            this.btnIpgeoAsync.Size = new System.Drawing.Size(50, 23);
            this.btnIpgeoAsync.TabIndex = 2;
            this.btnIpgeoAsync.Text = "Async";
            this.btnIpgeoAsync.UseVisualStyleBackColor = true;
            this.btnIpgeoAsync.Click += new System.EventHandler(this.btnIpgeoAsync_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Input:";
            // 
            // btnIpgeoSync
            // 
            this.btnIpgeoSync.Location = new System.Drawing.Point(59, 45);
            this.btnIpgeoSync.Name = "btnIpgeoSync";
            this.btnIpgeoSync.Size = new System.Drawing.Size(50, 23);
            this.btnIpgeoSync.TabIndex = 1;
            this.btnIpgeoSync.Text = "Sync";
            this.btnIpgeoSync.UseVisualStyleBackColor = true;
            this.btnIpgeoSync.Click += new System.EventHandler(this.btnIpgeoSync_Click);
            // 
            // tbIpGeoInput
            // 
            this.tbIpGeoInput.Location = new System.Drawing.Point(59, 19);
            this.tbIpGeoInput.Name = "tbIpGeoInput";
            this.tbIpGeoInput.Size = new System.Drawing.Size(113, 20);
            this.tbIpGeoInput.TabIndex = 0;
            this.tbIpGeoInput.Text = "213.180.141.140";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbTimeOutput);
            this.groupBox3.Controls.Add(this.btnTimeAsync);
            this.groupBox3.Controls.Add(this.btnTimeSync);
            this.groupBox3.Location = new System.Drawing.Point(12, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Output:";
            // 
            // tbTimeOutput
            // 
            this.tbTimeOutput.Location = new System.Drawing.Point(59, 48);
            this.tbTimeOutput.Name = "tbTimeOutput";
            this.tbTimeOutput.Size = new System.Drawing.Size(113, 20);
            this.tbTimeOutput.TabIndex = 3;
            // 
            // btnTimeAsync
            // 
            this.btnTimeAsync.Location = new System.Drawing.Point(123, 19);
            this.btnTimeAsync.Name = "btnTimeAsync";
            this.btnTimeAsync.Size = new System.Drawing.Size(50, 23);
            this.btnTimeAsync.TabIndex = 2;
            this.btnTimeAsync.Text = "Async";
            this.btnTimeAsync.UseVisualStyleBackColor = true;
            this.btnTimeAsync.Click += new System.EventHandler(this.btnTimeAsync_Click);
            // 
            // btnTimeSync
            // 
            this.btnTimeSync.Location = new System.Drawing.Point(60, 19);
            this.btnTimeSync.Name = "btnTimeSync";
            this.btnTimeSync.Size = new System.Drawing.Size(50, 23);
            this.btnTimeSync.TabIndex = 1;
            this.btnTimeSync.Text = "Sync";
            this.btnTimeSync.UseVisualStyleBackColor = true;
            this.btnTimeSync.Click += new System.EventHandler(this.btnTimeSync_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.tbEchoOutput);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.btnEchoSync);
            this.groupBox4.Controls.Add(this.tbEchoInput);
            this.groupBox4.Location = new System.Drawing.Point(205, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 195);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Echo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Output:";
            // 
            // tbEchoOutput
            // 
            this.tbEchoOutput.Location = new System.Drawing.Point(59, 74);
            this.tbEchoOutput.Multiline = true;
            this.tbEchoOutput.Name = "tbEchoOutput";
            this.tbEchoOutput.Size = new System.Drawing.Size(113, 110);
            this.tbEchoOutput.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Async";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnEchoAsync_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Input:";
            // 
            // btnEchoSync
            // 
            this.btnEchoSync.Location = new System.Drawing.Point(59, 45);
            this.btnEchoSync.Name = "btnEchoSync";
            this.btnEchoSync.Size = new System.Drawing.Size(50, 23);
            this.btnEchoSync.TabIndex = 1;
            this.btnEchoSync.Text = "Sync";
            this.btnEchoSync.UseVisualStyleBackColor = true;
            this.btnEchoSync.Click += new System.EventHandler(this.btnEchoSync_Click);
            // 
            // tbEchoInput
            // 
            this.tbEchoInput.Location = new System.Drawing.Point(59, 19);
            this.tbEchoInput.Name = "tbEchoInput";
            this.tbEchoInput.Size = new System.Drawing.Size(113, 20);
            this.tbEchoInput.TabIndex = 0;
            this.tbEchoInput.Text = "reply after me";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tbVoivodeship);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tbOrder);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.tbOrderOutput);
            this.groupBox5.Controls.Add(this.btnOrderAsync);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.btnOrderSync);
            this.groupBox5.Controls.Add(this.tbOrderer);
            this.groupBox5.Location = new System.Drawing.Point(398, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(365, 245);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Public orders";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Output:";
            // 
            // tbOrderOutput
            // 
            this.tbOrderOutput.Location = new System.Drawing.Point(59, 74);
            this.tbOrderOutput.Multiline = true;
            this.tbOrderOutput.Name = "tbOrderOutput";
            this.tbOrderOutput.Size = new System.Drawing.Size(288, 156);
            this.tbOrderOutput.TabIndex = 3;
            // 
            // btnOrderAsync
            // 
            this.btnOrderAsync.Location = new System.Drawing.Point(297, 43);
            this.btnOrderAsync.Name = "btnOrderAsync";
            this.btnOrderAsync.Size = new System.Drawing.Size(50, 23);
            this.btnOrderAsync.TabIndex = 2;
            this.btnOrderAsync.Text = "Async";
            this.btnOrderAsync.UseVisualStyleBackColor = true;
            this.btnOrderAsync.Click += new System.EventHandler(this.btnOrderAsync_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Orderer:";
            // 
            // btnOrderSync
            // 
            this.btnOrderSync.Location = new System.Drawing.Point(234, 43);
            this.btnOrderSync.Name = "btnOrderSync";
            this.btnOrderSync.Size = new System.Drawing.Size(50, 23);
            this.btnOrderSync.TabIndex = 1;
            this.btnOrderSync.Text = "Sync";
            this.btnOrderSync.UseVisualStyleBackColor = true;
            this.btnOrderSync.Click += new System.EventHandler(this.btnOrderSync_Click);
            // 
            // tbOrderer
            // 
            this.tbOrderer.Location = new System.Drawing.Point(59, 19);
            this.tbOrderer.Name = "tbOrderer";
            this.tbOrderer.Size = new System.Drawing.Size(113, 20);
            this.tbOrderer.TabIndex = 0;
            this.tbOrderer.Text = "99";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Order:";
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(234, 19);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(113, 20);
            this.tbOrder.TabIndex = 5;
            this.tbOrder.Text = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Voivode.:";
            // 
            // tbVoivodeship
            // 
            this.tbVoivodeship.Location = new System.Drawing.Point(59, 45);
            this.tbVoivodeship.Name = "tbVoivodeship";
            this.tbVoivodeship.Size = new System.Drawing.Size(113, 20);
            this.tbVoivodeship.TabIndex = 7;
            this.tbVoivodeship.Text = "Zachodniopomorskie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbStockInput;
        private System.Windows.Forms.Button btnStockQuoteSync;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStockQuoteAsync;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStockOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbIpGeoOutput;
        private System.Windows.Forms.Button btnIpgeoAsync;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnIpgeoSync;
        private System.Windows.Forms.TextBox tbIpGeoInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTimeOutput;
        private System.Windows.Forms.Button btnTimeAsync;
        private System.Windows.Forms.Button btnTimeSync;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEchoOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEchoSync;
        private System.Windows.Forms.TextBox tbEchoInput;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbVoivodeship;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOrderOutput;
        private System.Windows.Forms.Button btnOrderAsync;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnOrderSync;
        private System.Windows.Forms.TextBox tbOrderer;
    }
}

