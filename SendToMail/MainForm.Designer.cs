namespace SendToMail
{
    partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbPorts = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.lstSerialMonitor = new System.Windows.Forms.ListBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmbPorts);
			this.groupBox1.Controls.Add(this.btnConnect);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(949, 195);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Avaliable Ports";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Ports :";
			// 
			// cmbPorts
			// 
			this.cmbPorts.FormattingEnabled = true;
			this.cmbPorts.Location = new System.Drawing.Point(108, 84);
			this.cmbPorts.Margin = new System.Windows.Forms.Padding(4);
			this.cmbPorts.Name = "cmbPorts";
			this.cmbPorts.Size = new System.Drawing.Size(165, 28);
			this.cmbPorts.TabIndex = 1;
			// 
			// btnConnect
			// 
			this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
			this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnConnect.Location = new System.Drawing.Point(119, 120);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(138, 46);
			this.btnConnect.TabIndex = 0;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btnSend);
			this.groupBox2.Controls.Add(this.txtStatus);
			this.groupBox2.Controls.Add(this.lstSerialMonitor);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Location = new System.Drawing.Point(0, 200);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(949, 360);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Serail Monitör";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(479, 126);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Trash Status :";
			// 
			// btnSend
			// 
			this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
			this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSend.Location = new System.Drawing.Point(686, 157);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(148, 35);
			this.btnSend.TabIndex = 7;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// txtStatus
			// 
			this.txtStatus.Enabled = false;
			this.txtStatus.Location = new System.Drawing.Point(615, 123);
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.Size = new System.Drawing.Size(281, 28);
			this.txtStatus.TabIndex = 6;
			// 
			// lstSerialMonitor
			// 
			this.lstSerialMonitor.FormattingEnabled = true;
			this.lstSerialMonitor.ItemHeight = 20;
			this.lstSerialMonitor.Location = new System.Drawing.Point(7, 24);
			this.lstSerialMonitor.Name = "lstSerialMonitor";
			this.lstSerialMonitor.Size = new System.Drawing.Size(456, 324);
			this.lstSerialMonitor.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(949, 560);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPorts;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstSerialMonitor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

