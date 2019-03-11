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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnWeatherAsync = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnWeatherSync = new System.Windows.Forms.Button();
            this.tbWeatherInput = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.l_asynctotal = new System.Windows.Forms.Label();
            this.l_synctotal = new System.Windows.Forms.Label();
            this.l_poasync = new System.Windows.Forms.Label();
            this.l_owasync = new System.Windows.Forms.Label();
            this.l_posync = new System.Windows.Forms.Label();
            this.l_owsync = new System.Windows.Forms.Label();
            this.l_echoasync = new System.Windows.Forms.Label();
            this.l_echosync = new System.Windows.Forms.Label();
            this.l_timeasync = new System.Windows.Forms.Label();
            this.l_timesync = new System.Windows.Forms.Label();
            this.l_i2gasync = new System.Windows.Forms.Label();
            this.l_i2gsync = new System.Windows.Forms.Label();
            this.l_sqasync = new System.Windows.Forms.Label();
            this.l_sqsync = new System.Windows.Forms.Label();
            this.btnRunAllAsync = new System.Windows.Forms.Button();
            this.btnRunAllSync = new System.Windows.Forms.Button();
            this.tbWeatherOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
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
            this.tbIpGeoOutput.Size = new System.Drawing.Size(113, 96);
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
            this.groupBox3.Size = new System.Drawing.Size(187, 77);
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbWeatherOutput);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.btnWeatherAsync);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.btnWeatherSync);
            this.groupBox6.Controls.Add(this.tbWeatherInput);
            this.groupBox6.Location = new System.Drawing.Point(205, 213);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 181);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "OpenWeather";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Output:";
            // 
            // btnWeatherAsync
            // 
            this.btnWeatherAsync.Location = new System.Drawing.Point(122, 45);
            this.btnWeatherAsync.Name = "btnWeatherAsync";
            this.btnWeatherAsync.Size = new System.Drawing.Size(50, 23);
            this.btnWeatherAsync.TabIndex = 2;
            this.btnWeatherAsync.Text = "Async";
            this.btnWeatherAsync.UseVisualStyleBackColor = true;
            this.btnWeatherAsync.Click += new System.EventHandler(this.btnWeatherAsync_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Input:";
            // 
            // btnWeatherSync
            // 
            this.btnWeatherSync.Location = new System.Drawing.Point(59, 45);
            this.btnWeatherSync.Name = "btnWeatherSync";
            this.btnWeatherSync.Size = new System.Drawing.Size(50, 23);
            this.btnWeatherSync.TabIndex = 1;
            this.btnWeatherSync.Text = "Sync";
            this.btnWeatherSync.UseVisualStyleBackColor = true;
            this.btnWeatherSync.Click += new System.EventHandler(this.btnWeatherSync_Click);
            // 
            // tbWeatherInput
            // 
            this.tbWeatherInput.Location = new System.Drawing.Point(59, 19);
            this.tbWeatherInput.Name = "tbWeatherInput";
            this.tbWeatherInput.Size = new System.Drawing.Size(113, 20);
            this.tbWeatherInput.TabIndex = 0;
            this.tbWeatherInput.Text = "Szczecin";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.l_poasync);
            this.groupBox7.Controls.Add(this.l_owasync);
            this.groupBox7.Controls.Add(this.l_posync);
            this.groupBox7.Controls.Add(this.l_owsync);
            this.groupBox7.Controls.Add(this.l_echoasync);
            this.groupBox7.Controls.Add(this.l_echosync);
            this.groupBox7.Controls.Add(this.l_timeasync);
            this.groupBox7.Controls.Add(this.l_timesync);
            this.groupBox7.Controls.Add(this.l_i2gasync);
            this.groupBox7.Controls.Add(this.l_i2gsync);
            this.groupBox7.Controls.Add(this.l_sqasync);
            this.groupBox7.Controls.Add(this.l_sqsync);
            this.groupBox7.Controls.Add(this.label27);
            this.groupBox7.Controls.Add(this.label26);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Location = new System.Drawing.Point(398, 263);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(241, 131);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Time stats [ms]";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "SQ sync:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(127, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "SQ async:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "i2g sync:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(127, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "i2g async:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 48);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "time sync:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(127, 48);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "time async:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "echo sync:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(120, 61);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 13);
            this.label23.TabIndex = 10;
            this.label23.Text = "echo async:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(6, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 13);
            this.label24.TabIndex = 11;
            this.label24.Text = "OW sync:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 87);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "PO sync:";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(127, 74);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 13;
            this.label26.Text = "OW async:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(127, 87);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 13);
            this.label27.TabIndex = 14;
            this.label27.Text = "PO async:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(4, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "TOTAL A:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(4, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 15;
            this.label22.Text = "TOTAL S:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // l_asynctotal
            // 
            this.l_asynctotal.Location = new System.Drawing.Point(67, 74);
            this.l_asynctotal.Name = "l_asynctotal";
            this.l_asynctotal.Size = new System.Drawing.Size(46, 13);
            this.l_asynctotal.TabIndex = 30;
            this.l_asynctotal.Text = "-";
            // 
            // l_synctotal
            // 
            this.l_synctotal.Location = new System.Drawing.Point(67, 61);
            this.l_synctotal.Name = "l_synctotal";
            this.l_synctotal.Size = new System.Drawing.Size(46, 13);
            this.l_synctotal.TabIndex = 29;
            this.l_synctotal.Text = "-";
            // 
            // l_poasync
            // 
            this.l_poasync.Location = new System.Drawing.Point(190, 87);
            this.l_poasync.Name = "l_poasync";
            this.l_poasync.Size = new System.Drawing.Size(46, 13);
            this.l_poasync.TabIndex = 28;
            this.l_poasync.Text = "-";
            // 
            // l_owasync
            // 
            this.l_owasync.Location = new System.Drawing.Point(190, 74);
            this.l_owasync.Name = "l_owasync";
            this.l_owasync.Size = new System.Drawing.Size(46, 13);
            this.l_owasync.TabIndex = 27;
            this.l_owasync.Text = "-";
            // 
            // l_posync
            // 
            this.l_posync.Location = new System.Drawing.Point(69, 87);
            this.l_posync.Name = "l_posync";
            this.l_posync.Size = new System.Drawing.Size(46, 13);
            this.l_posync.TabIndex = 26;
            this.l_posync.Text = "-";
            // 
            // l_owsync
            // 
            this.l_owsync.Location = new System.Drawing.Point(69, 74);
            this.l_owsync.Name = "l_owsync";
            this.l_owsync.Size = new System.Drawing.Size(46, 13);
            this.l_owsync.TabIndex = 25;
            this.l_owsync.Text = "-";
            // 
            // l_echoasync
            // 
            this.l_echoasync.Location = new System.Drawing.Point(190, 61);
            this.l_echoasync.Name = "l_echoasync";
            this.l_echoasync.Size = new System.Drawing.Size(46, 13);
            this.l_echoasync.TabIndex = 24;
            this.l_echoasync.Text = "-";
            // 
            // l_echosync
            // 
            this.l_echosync.Location = new System.Drawing.Point(69, 61);
            this.l_echosync.Name = "l_echosync";
            this.l_echosync.Size = new System.Drawing.Size(46, 13);
            this.l_echosync.TabIndex = 23;
            this.l_echosync.Text = "-";
            // 
            // l_timeasync
            // 
            this.l_timeasync.Location = new System.Drawing.Point(190, 48);
            this.l_timeasync.Name = "l_timeasync";
            this.l_timeasync.Size = new System.Drawing.Size(46, 13);
            this.l_timeasync.TabIndex = 22;
            this.l_timeasync.Text = "-";
            // 
            // l_timesync
            // 
            this.l_timesync.Location = new System.Drawing.Point(69, 48);
            this.l_timesync.Name = "l_timesync";
            this.l_timesync.Size = new System.Drawing.Size(46, 13);
            this.l_timesync.TabIndex = 21;
            this.l_timesync.Text = "-";
            // 
            // l_i2gasync
            // 
            this.l_i2gasync.Location = new System.Drawing.Point(190, 35);
            this.l_i2gasync.Name = "l_i2gasync";
            this.l_i2gasync.Size = new System.Drawing.Size(46, 13);
            this.l_i2gasync.TabIndex = 20;
            this.l_i2gasync.Text = "-";
            // 
            // l_i2gsync
            // 
            this.l_i2gsync.Location = new System.Drawing.Point(69, 35);
            this.l_i2gsync.Name = "l_i2gsync";
            this.l_i2gsync.Size = new System.Drawing.Size(46, 13);
            this.l_i2gsync.TabIndex = 19;
            this.l_i2gsync.Text = "-";
            // 
            // l_sqasync
            // 
            this.l_sqasync.Location = new System.Drawing.Point(190, 22);
            this.l_sqasync.Name = "l_sqasync";
            this.l_sqasync.Size = new System.Drawing.Size(46, 13);
            this.l_sqasync.TabIndex = 18;
            this.l_sqasync.Text = "-";
            // 
            // l_sqsync
            // 
            this.l_sqsync.Location = new System.Drawing.Point(69, 22);
            this.l_sqsync.Name = "l_sqsync";
            this.l_sqsync.Size = new System.Drawing.Size(46, 13);
            this.l_sqsync.TabIndex = 17;
            this.l_sqsync.Text = "-";
            // 
            // btnRunAllAsync
            // 
            this.btnRunAllAsync.Location = new System.Drawing.Point(61, 15);
            this.btnRunAllAsync.Name = "btnRunAllAsync";
            this.btnRunAllAsync.Size = new System.Drawing.Size(49, 34);
            this.btnRunAllAsync.TabIndex = 6;
            this.btnRunAllAsync.Text = "All Async";
            this.btnRunAllAsync.UseVisualStyleBackColor = true;
            this.btnRunAllAsync.Click += new System.EventHandler(this.btnRunAllAsync_Click);
            // 
            // btnRunAllSync
            // 
            this.btnRunAllSync.Location = new System.Drawing.Point(6, 15);
            this.btnRunAllSync.Name = "btnRunAllSync";
            this.btnRunAllSync.Size = new System.Drawing.Size(49, 34);
            this.btnRunAllSync.TabIndex = 5;
            this.btnRunAllSync.Text = "All Sync";
            this.btnRunAllSync.UseVisualStyleBackColor = true;
            this.btnRunAllSync.Click += new System.EventHandler(this.btnRunAllSync_Click);
            // 
            // tbWeatherOutput
            // 
            this.tbWeatherOutput.Location = new System.Drawing.Point(59, 72);
            this.tbWeatherOutput.Name = "tbWeatherOutput";
            this.tbWeatherOutput.Size = new System.Drawing.Size(113, 100);
            this.tbWeatherOutput.TabIndex = 5;
            this.tbWeatherOutput.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnRunAllAsync);
            this.groupBox8.Controls.Add(this.btnRunAllSync);
            this.groupBox8.Controls.Add(this.l_asynctotal);
            this.groupBox8.Controls.Add(this.label22);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Controls.Add(this.l_synctotal);
            this.groupBox8.Location = new System.Drawing.Point(645, 263);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(118, 131);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Batch time stats [ms]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 412);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnWeatherAsync;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnWeatherSync;
        private System.Windows.Forms.TextBox tbWeatherInput;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnRunAllAsync;
        private System.Windows.Forms.Label l_asynctotal;
        private System.Windows.Forms.Button btnRunAllSync;
        private System.Windows.Forms.Label l_synctotal;
        private System.Windows.Forms.Label l_poasync;
        private System.Windows.Forms.Label l_owasync;
        private System.Windows.Forms.Label l_posync;
        private System.Windows.Forms.Label l_owsync;
        private System.Windows.Forms.Label l_echoasync;
        private System.Windows.Forms.Label l_echosync;
        private System.Windows.Forms.Label l_timeasync;
        private System.Windows.Forms.Label l_timesync;
        private System.Windows.Forms.Label l_i2gasync;
        private System.Windows.Forms.Label l_i2gsync;
        private System.Windows.Forms.Label l_sqasync;
        private System.Windows.Forms.Label l_sqsync;
        private System.Windows.Forms.RichTextBox tbWeatherOutput;
        private System.Windows.Forms.GroupBox groupBox8;
    }
}

