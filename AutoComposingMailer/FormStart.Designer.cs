namespace AutoComposingMailer
{
    partial class FormStart
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
            this.tableLayoutDir = new System.Windows.Forms.TableLayoutPanel();
            this.buttonShowClients = new System.Windows.Forms.Button();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelClientMail = new System.Windows.Forms.Label();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.textBoxClientMail = new System.Windows.Forms.TextBox();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBarScan = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.tableLayoutDir.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutDir
            // 
            this.tableLayoutDir.ColumnCount = 3;
            this.tableLayoutDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.31183F));
            this.tableLayoutDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.68817F));
            this.tableLayoutDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutDir.Controls.Add(this.buttonShowClients, 2, 0);
            this.tableLayoutDir.Controls.Add(this.labelClientName, 0, 0);
            this.tableLayoutDir.Controls.Add(this.labelClientMail, 1, 0);
            this.tableLayoutDir.Controls.Add(this.buttonCreateClient, 2, 1);
            this.tableLayoutDir.Controls.Add(this.textBoxClientMail, 1, 1);
            this.tableLayoutDir.Controls.Add(this.textBoxClientName, 0, 1);
            this.tableLayoutDir.Location = new System.Drawing.Point(12, 63);
            this.tableLayoutDir.Name = "tableLayoutDir";
            this.tableLayoutDir.RowCount = 2;
            this.tableLayoutDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutDir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutDir.Size = new System.Drawing.Size(498, 95);
            this.tableLayoutDir.TabIndex = 5;
            // 
            // buttonShowClients
            // 
            this.buttonShowClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShowClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonShowClients.Location = new System.Drawing.Point(278, 16);
            this.buttonShowClients.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShowClients.Name = "buttonShowClients";
            this.buttonShowClients.Size = new System.Drawing.Size(220, 25);
            this.buttonShowClients.TabIndex = 17;
            this.buttonShowClients.Text = "Show List";
            this.buttonShowClients.UseVisualStyleBackColor = true;
            this.buttonShowClients.Click += new System.EventHandler(this.ButtonShowClients_Click);
            // 
            // labelClientName
            // 
            this.labelClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelClientName.Location = new System.Drawing.Point(3, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(126, 57);
            this.labelClientName.TabIndex = 12;
            this.labelClientName.Text = "Client Name";
            this.labelClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClientMail
            // 
            this.labelClientMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClientMail.AutoSize = true;
            this.labelClientMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelClientMail.Location = new System.Drawing.Point(135, 0);
            this.labelClientMail.Name = "labelClientMail";
            this.labelClientMail.Size = new System.Drawing.Size(140, 57);
            this.labelClientMail.TabIndex = 13;
            this.labelClientMail.Text = "Client Mail";
            this.labelClientMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.buttonCreateClient.Location = new System.Drawing.Point(278, 57);
            this.buttonCreateClient.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(220, 25);
            this.buttonCreateClient.TabIndex = 14;
            this.buttonCreateClient.Text = "Create Client";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.ButtonCreateClient_Click);
            // 
            // textBoxClientMail
            // 
            this.textBoxClientMail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientMail.Location = new System.Drawing.Point(135, 60);
            this.textBoxClientMail.Name = "textBoxClientMail";
            this.textBoxClientMail.Size = new System.Drawing.Size(140, 22);
            this.textBoxClientMail.TabIndex = 16;
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClientName.Location = new System.Drawing.Point(3, 60);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(126, 22);
            this.textBoxClientName.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.progressBarScan, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 164);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 33);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // progressBarScan
            // 
            this.progressBarScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarScan.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarScan.Location = new System.Drawing.Point(3, 3);
            this.progressBarScan.MarqueeAnimationSpeed = 1000;
            this.progressBarScan.Name = "progressBarScan";
            this.progressBarScan.Size = new System.Drawing.Size(492, 27);
            this.progressBarScan.Step = 1;
            this.progressBarScan.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(142, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(238, 57);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.buttonScan, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 200);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(498, 40);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScan.Location = new System.Drawing.Point(130, 0);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(130, 0, 130, 0);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(238, 40);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfig.Location = new System.Drawing.Point(447, 12);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(63, 33);
            this.buttonConfig.TabIndex = 9;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.ButtonConfig_Click);
            // 
            // FormStart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(522, 243);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormStart";
            this.ShowIcon = false;
            this.Text = "AutoComposingMailer";
            this.tableLayoutDir.ResumeLayout(false);
            this.tableLayoutDir.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutDir;
        private System.Windows.Forms.Button buttonShowClients;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClientMail;
        private System.Windows.Forms.Button buttonCreateClient;
        public System.Windows.Forms.TextBox textBoxClientMail;
        public System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.ProgressBar progressBarScan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonConfig;
    }
}