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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStockQuoteAsync = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStockOutput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbIpGeoOutput = new System.Windows.Forms.TextBox();
            this.btnIpgeoAsync = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIpgeoSync = new System.Windows.Forms.Button();
            this.tbIpGeoInput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

