namespace ProtocolAnalyzer
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._device = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.linPage = new System.Windows.Forms.TabPage();
            this.canPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.lin_raw_Page = new System.Windows.Forms.TabPage();
            this._connect = new System.Windows.Forms.Button();
            this._disconnect = new System.Windows.Forms.Button();
            this._statusInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._lin_raw_attachtodevice = new System.Windows.Forms.CheckBox();
            this._lin_dataGridView = new System.Windows.Forms.DataGridView();
            this.lin_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lin_Identifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lin_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lin_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._lin_raw_clear_log = new System.Windows.Forms.Button();
            this._lin_raw_save_log = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._lin_raw_send_data = new System.Windows.Forms.Button();
            this._lin_raw_repeat = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this._lin_raw_baudrate = new System.Windows.Forms.NumericUpDown();
            this._lin_raw_repeat_value = new System.Windows.Forms.NumericUpDown();
            this._lin_raw_data = new System.Windows.Forms.TextBox();
            this._lin_raw_identifier = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.linPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.lin_raw_Page.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lin_dataGridView)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lin_raw_baudrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lin_raw_repeat_value)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 840);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1163, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1163, 840);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._disconnect);
            this.groupBox1.Controls.Add(this._connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._device);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1155, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Device";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Device";
            // 
            // _device
            // 
            this._device.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._device.FormattingEnabled = true;
            this._device.Location = new System.Drawing.Point(75, 23);
            this._device.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._device.Name = "_device";
            this._device.Size = new System.Drawing.Size(160, 24);
            this._device.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1155, 759);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Protocols";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.linPage);
            this.tabControl1.Controls.Add(this.canPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 736);
            this.tabControl1.TabIndex = 0;
            // 
            // linPage
            // 
            this.linPage.Controls.Add(this.tabControl2);
            this.linPage.Location = new System.Drawing.Point(4, 25);
            this.linPage.Name = "linPage";
            this.linPage.Padding = new System.Windows.Forms.Padding(3);
            this.linPage.Size = new System.Drawing.Size(1139, 707);
            this.linPage.TabIndex = 0;
            this.linPage.Text = "LIN";
            this.linPage.UseVisualStyleBackColor = true;
            // 
            // canPage
            // 
            this.canPage.Location = new System.Drawing.Point(4, 25);
            this.canPage.Name = "canPage";
            this.canPage.Padding = new System.Windows.Forms.Padding(3);
            this.canPage.Size = new System.Drawing.Size(1139, 707);
            this.canPage.TabIndex = 1;
            this.canPage.Text = "CAN";
            this.canPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.lin_raw_Page);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1133, 701);
            this.tabControl2.TabIndex = 0;
            // 
            // lin_raw_Page
            // 
            this.lin_raw_Page.Controls.Add(this.tableLayoutPanel2);
            this.lin_raw_Page.Location = new System.Drawing.Point(4, 25);
            this.lin_raw_Page.Name = "lin_raw_Page";
            this.lin_raw_Page.Padding = new System.Windows.Forms.Padding(3);
            this.lin_raw_Page.Size = new System.Drawing.Size(1125, 672);
            this.lin_raw_Page.TabIndex = 0;
            this.lin_raw_Page.Text = "RAW";
            this.lin_raw_Page.UseVisualStyleBackColor = true;
            // 
            // _connect
            // 
            this._connect.Location = new System.Drawing.Point(242, 24);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(133, 23);
            this._connect.TabIndex = 2;
            this._connect.Text = "Connect";
            this._connect.UseVisualStyleBackColor = true;
            this._connect.Click += new System.EventHandler(this._connect_Click);
            // 
            // _disconnect
            // 
            this._disconnect.Location = new System.Drawing.Point(381, 24);
            this._disconnect.Name = "_disconnect";
            this._disconnect.Size = new System.Drawing.Size(133, 23);
            this._disconnect.TabIndex = 3;
            this._disconnect.Text = "Disconnect";
            this._disconnect.UseVisualStyleBackColor = true;
            this._disconnect.Click += new System.EventHandler(this._disconnect_Click);
            // 
            // _statusInfo
            // 
            this._statusInfo.Name = "_statusInfo";
            this._statusInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1119, 666);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._lin_raw_save_log);
            this.groupBox3.Controls.Add(this._lin_raw_clear_log);
            this.groupBox3.Controls.Add(this._lin_raw_attachtodevice);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this._lin_raw_baudrate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1113, 64);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._lin_dataGridView);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 142);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1113, 521);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Receive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Baud rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "b/sec";
            // 
            // _lin_raw_attachtodevice
            // 
            this._lin_raw_attachtodevice.AutoSize = true;
            this._lin_raw_attachtodevice.Location = new System.Drawing.Point(220, 22);
            this._lin_raw_attachtodevice.Name = "_lin_raw_attachtodevice";
            this._lin_raw_attachtodevice.Size = new System.Drawing.Size(131, 21);
            this._lin_raw_attachtodevice.TabIndex = 3;
            this._lin_raw_attachtodevice.Text = "Attach to device";
            this._lin_raw_attachtodevice.UseVisualStyleBackColor = true;
            this._lin_raw_attachtodevice.CheckedChanged += new System.EventHandler(this._lin_raw_attachtodevice_CheckedChanged);
            // 
            // _lin_dataGridView
            // 
            this._lin_dataGridView.AllowUserToAddRows = false;
            this._lin_dataGridView.AllowUserToDeleteRows = false;
            this._lin_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._lin_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lin_Time,
            this.lin_Identifier,
            this.lin_data,
            this.lin_count});
            this._lin_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lin_dataGridView.Location = new System.Drawing.Point(3, 18);
            this._lin_dataGridView.Name = "_lin_dataGridView";
            this._lin_dataGridView.ReadOnly = true;
            this._lin_dataGridView.RowTemplate.Height = 24;
            this._lin_dataGridView.Size = new System.Drawing.Size(1107, 500);
            this._lin_dataGridView.TabIndex = 0;
            // 
            // lin_Time
            // 
            this.lin_Time.HeaderText = "Time";
            this.lin_Time.Name = "lin_Time";
            this.lin_Time.ReadOnly = true;
            // 
            // lin_Identifier
            // 
            this.lin_Identifier.HeaderText = "Identifier";
            this.lin_Identifier.Name = "lin_Identifier";
            this.lin_Identifier.ReadOnly = true;
            // 
            // lin_data
            // 
            this.lin_data.HeaderText = "Data";
            this.lin_data.Name = "lin_data";
            this.lin_data.ReadOnly = true;
            // 
            // lin_count
            // 
            this.lin_count.HeaderText = "Count";
            this.lin_count.Name = "lin_count";
            this.lin_count.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this._lin_raw_repeat_value);
            this.groupBox5.Controls.Add(this._lin_raw_repeat);
            this.groupBox5.Controls.Add(this._lin_raw_send_data);
            this.groupBox5.Controls.Add(this._lin_raw_data);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this._lin_raw_identifier);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 73);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1113, 63);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Transmit";
            // 
            // _lin_raw_clear_log
            // 
            this._lin_raw_clear_log.Location = new System.Drawing.Point(360, 20);
            this._lin_raw_clear_log.Name = "_lin_raw_clear_log";
            this._lin_raw_clear_log.Size = new System.Drawing.Size(105, 23);
            this._lin_raw_clear_log.TabIndex = 4;
            this._lin_raw_clear_log.Text = "Clear log";
            this._lin_raw_clear_log.UseVisualStyleBackColor = true;
            // 
            // _lin_raw_save_log
            // 
            this._lin_raw_save_log.Location = new System.Drawing.Point(471, 21);
            this._lin_raw_save_log.Name = "_lin_raw_save_log";
            this._lin_raw_save_log.Size = new System.Drawing.Size(105, 23);
            this._lin_raw_save_log.TabIndex = 5;
            this._lin_raw_save_log.Text = "Save log";
            this._lin_raw_save_log.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Identifier 0x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data 0x";
            // 
            // _lin_raw_send_data
            // 
            this._lin_raw_send_data.Location = new System.Drawing.Point(235, 21);
            this._lin_raw_send_data.Name = "_lin_raw_send_data";
            this._lin_raw_send_data.Size = new System.Drawing.Size(119, 23);
            this._lin_raw_send_data.TabIndex = 4;
            this._lin_raw_send_data.Text = "Send data";
            this._lin_raw_send_data.UseVisualStyleBackColor = true;
            // 
            // _lin_raw_repeat
            // 
            this._lin_raw_repeat.AutoSize = true;
            this._lin_raw_repeat.Location = new System.Drawing.Point(367, 23);
            this._lin_raw_repeat.Name = "_lin_raw_repeat";
            this._lin_raw_repeat.Size = new System.Drawing.Size(119, 21);
            this._lin_raw_repeat.TabIndex = 5;
            this._lin_raw_repeat.Text = "Repeat every ";
            this._lin_raw_repeat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "ms";
            // 
            // _lin_raw_baudrate
            // 
            this._lin_raw_baudrate.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ProtocolAnalyzer.Properties.Settings.Default, "lin_raw_baudrate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._lin_raw_baudrate.Location = new System.Drawing.Point(82, 21);
            this._lin_raw_baudrate.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this._lin_raw_baudrate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._lin_raw_baudrate.Name = "_lin_raw_baudrate";
            this._lin_raw_baudrate.Size = new System.Drawing.Size(84, 22);
            this._lin_raw_baudrate.TabIndex = 1;
            this._lin_raw_baudrate.Value = global::ProtocolAnalyzer.Properties.Settings.Default.lin_raw_baudrate;
            // 
            // _lin_raw_repeat_value
            // 
            this._lin_raw_repeat_value.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::ProtocolAnalyzer.Properties.Settings.Default, "lin_raw_repeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._lin_raw_repeat_value.Location = new System.Drawing.Point(481, 21);
            this._lin_raw_repeat_value.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._lin_raw_repeat_value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this._lin_raw_repeat_value.Name = "_lin_raw_repeat_value";
            this._lin_raw_repeat_value.Size = new System.Drawing.Size(64, 22);
            this._lin_raw_repeat_value.TabIndex = 6;
            this._lin_raw_repeat_value.Value = global::ProtocolAnalyzer.Properties.Settings.Default.lin_raw_repeat;
            // 
            // _lin_raw_data
            // 
            this._lin_raw_data.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProtocolAnalyzer.Properties.Settings.Default, "lin_raw_data", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._lin_raw_data.Location = new System.Drawing.Point(187, 21);
            this._lin_raw_data.MaxLength = 2;
            this._lin_raw_data.Name = "_lin_raw_data";
            this._lin_raw_data.Size = new System.Drawing.Size(27, 22);
            this._lin_raw_data.TabIndex = 3;
            this._lin_raw_data.Text = global::ProtocolAnalyzer.Properties.Settings.Default.lin_raw_data;
            // 
            // _lin_raw_identifier
            // 
            this._lin_raw_identifier.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProtocolAnalyzer.Properties.Settings.Default, "lin_raw_identifier", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this._lin_raw_identifier.Location = new System.Drawing.Point(82, 21);
            this._lin_raw_identifier.MaxLength = 2;
            this._lin_raw_identifier.Name = "_lin_raw_identifier";
            this._lin_raw_identifier.Size = new System.Drawing.Size(27, 22);
            this._lin_raw_identifier.TabIndex = 1;
            this._lin_raw_identifier.Text = global::ProtocolAnalyzer.Properties.Settings.Default.lin_raw_identifier;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 862);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Protocol analyzer (powered by Azarenko S.A.)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.linPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.lin_raw_Page.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._lin_dataGridView)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._lin_raw_baudrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lin_raw_repeat_value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _device;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage linPage;
        private System.Windows.Forms.TabPage canPage;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage lin_raw_Page;
        private System.Windows.Forms.Button _disconnect;
        private System.Windows.Forms.Button _connect;
        private System.Windows.Forms.ToolStripStatusLabel _statusInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _lin_raw_baudrate;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox _lin_raw_attachtodevice;
        private System.Windows.Forms.DataGridView _lin_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn lin_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn lin_Identifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn lin_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn lin_count;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button _lin_raw_clear_log;
        private System.Windows.Forms.Button _lin_raw_save_log;
        private System.Windows.Forms.TextBox _lin_raw_data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _lin_raw_identifier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _lin_raw_send_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _lin_raw_repeat_value;
        private System.Windows.Forms.CheckBox _lin_raw_repeat;
    }
}

