namespace AutoComposingMailer
{
    partial class FormLog
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
            this.tableLayoutLabelConfig = new System.Windows.Forms.TableLayoutPanel();
            this.labelConfig = new System.Windows.Forms.Label();
            this.tableLayoutMenu = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSmtpForm = new System.Windows.Forms.Button();
            this.buttonFoldersForm = new System.Windows.Forms.Button();
            this.buttonFormImages = new System.Windows.Forms.Button();
            this.buttonLogsForm = new System.Windows.Forms.Button();
            this.tableLayoutFoldersConfig = new System.Windows.Forms.TableLayoutPanel();
            this.listViewLog = new System.Windows.Forms.ListView();
            this.tableLayoutConfirm = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.tableLayoutLabelConfig.SuspendLayout();
            this.tableLayoutMenu.SuspendLayout();
            this.tableLayoutFoldersConfig.SuspendLayout();
            this.tableLayoutConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutLabelConfig
            // 
            this.tableLayoutLabelConfig.ColumnCount = 1;
            this.tableLayoutLabelConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLabelConfig.Controls.Add(this.labelConfig, 0, 0);
            this.tableLayoutLabelConfig.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutLabelConfig.Name = "tableLayoutLabelConfig";
            this.tableLayoutLabelConfig.RowCount = 1;
            this.tableLayoutLabelConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLabelConfig.Size = new System.Drawing.Size(775, 44);
            this.tableLayoutLabelConfig.TabIndex = 0;
            // 
            // labelConfig
            // 
            this.labelConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConfig.AutoSize = true;
            this.labelConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfig.Location = new System.Drawing.Point(3, 0);
            this.labelConfig.Name = "labelConfig";
            this.labelConfig.Size = new System.Drawing.Size(769, 44);
            this.labelConfig.TabIndex = 0;
            this.labelConfig.Text = "Config";
            this.labelConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutMenu
            // 
            this.tableLayoutMenu.ColumnCount = 6;
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutMenu.Controls.Add(this.buttonSmtpForm, 3, 0);
            this.tableLayoutMenu.Controls.Add(this.buttonFoldersForm, 2, 0);
            this.tableLayoutMenu.Controls.Add(this.buttonFormImages, 1, 0);
            this.tableLayoutMenu.Controls.Add(this.buttonLogsForm, 4, 0);
            this.tableLayoutMenu.Location = new System.Drawing.Point(13, 64);
            this.tableLayoutMenu.Name = "tableLayoutMenu";
            this.tableLayoutMenu.RowCount = 1;
            this.tableLayoutMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMenu.Size = new System.Drawing.Size(775, 52);
            this.tableLayoutMenu.TabIndex = 1;
            // 
            // buttonSmtpForm
            // 
            this.buttonSmtpForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSmtpForm.Location = new System.Drawing.Point(397, 10);
            this.buttonSmtpForm.Margin = new System.Windows.Forms.Padding(10);
            this.buttonSmtpForm.Name = "buttonSmtpForm";
            this.buttonSmtpForm.Size = new System.Drawing.Size(109, 32);
            this.buttonSmtpForm.TabIndex = 0;
            this.buttonSmtpForm.Text = "SMTP";
            this.buttonSmtpForm.UseVisualStyleBackColor = true;
            this.buttonSmtpForm.Click += new System.EventHandler(this.ButtonSmtpForm_Click);
            // 
            // buttonFoldersForm
            // 
            this.buttonFoldersForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFoldersForm.Location = new System.Drawing.Point(268, 10);
            this.buttonFoldersForm.Margin = new System.Windows.Forms.Padding(10);
            this.buttonFoldersForm.Name = "buttonFoldersForm";
            this.buttonFoldersForm.Size = new System.Drawing.Size(109, 32);
            this.buttonFoldersForm.TabIndex = 1;
            this.buttonFoldersForm.Text = "Folders";
            this.buttonFoldersForm.UseVisualStyleBackColor = true;
            this.buttonFoldersForm.Click += new System.EventHandler(this.ButtonFoldersForm_Click);
            // 
            // buttonFormImages
            // 
            this.buttonFormImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormImages.Location = new System.Drawing.Point(139, 10);
            this.buttonFormImages.Margin = new System.Windows.Forms.Padding(10);
            this.buttonFormImages.Name = "buttonFormImages";
            this.buttonFormImages.Size = new System.Drawing.Size(109, 32);
            this.buttonFormImages.TabIndex = 2;
            this.buttonFormImages.Text = "Images";
            this.buttonFormImages.UseVisualStyleBackColor = true;
            this.buttonFormImages.Click += new System.EventHandler(this.ButtonFormImages_Click);
            // 
            // buttonLogsForm
            // 
            this.buttonLogsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogsForm.Enabled = false;
            this.buttonLogsForm.Location = new System.Drawing.Point(526, 10);
            this.buttonLogsForm.Margin = new System.Windows.Forms.Padding(10);
            this.buttonLogsForm.Name = "buttonLogsForm";
            this.buttonLogsForm.Size = new System.Drawing.Size(109, 32);
            this.buttonLogsForm.TabIndex = 3;
            this.buttonLogsForm.Text = "Logs";
            this.buttonLogsForm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutFoldersConfig
            // 
            this.tableLayoutFoldersConfig.ColumnCount = 1;
            this.tableLayoutFoldersConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFoldersConfig.Controls.Add(this.listViewLog, 0, 0);
            this.tableLayoutFoldersConfig.Location = new System.Drawing.Point(13, 119);
            this.tableLayoutFoldersConfig.Name = "tableLayoutFoldersConfig";
            this.tableLayoutFoldersConfig.RowCount = 1;
            this.tableLayoutFoldersConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutFoldersConfig.Size = new System.Drawing.Size(775, 258);
            this.tableLayoutFoldersConfig.TabIndex = 2;
            // 
            // listViewLog
            // 
            this.listViewLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewLog.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewLog.HideSelection = false;
            this.listViewLog.Location = new System.Drawing.Point(3, 3);
            this.listViewLog.Name = "listViewLog";
            this.listViewLog.ShowGroups = false;
            this.listViewLog.Size = new System.Drawing.Size(769, 252);
            this.listViewLog.TabIndex = 0;
            this.listViewLog.TileSize = new System.Drawing.Size(2000, 20);
            this.listViewLog.UseCompatibleStateImageBehavior = false;
            this.listViewLog.View = System.Windows.Forms.View.Tile;
            this.listViewLog.SelectedIndexChanged += new System.EventHandler(this.listViewLog_SelectedIndexChanged);
            // 
            // tableLayoutConfirm
            // 
            this.tableLayoutConfirm.ColumnCount = 3;
            this.tableLayoutConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutConfirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutConfirm.Controls.Add(this.buttonCancel, 1, 0);
            this.tableLayoutConfirm.Controls.Add(this.buttonRefresh, 2, 0);
            this.tableLayoutConfirm.Location = new System.Drawing.Point(13, 393);
            this.tableLayoutConfirm.Name = "tableLayoutConfirm";
            this.tableLayoutConfirm.RowCount = 1;
            this.tableLayoutConfirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutConfirm.Size = new System.Drawing.Size(775, 45);
            this.tableLayoutConfirm.TabIndex = 3;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(475, 10);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 25);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(630, 10);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(10);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(135, 25);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Location = new System.Drawing.Point(750, 10);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(130, 0, 130, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 36);
            this.buttonMenu.TabIndex = 12;
            this.buttonMenu.Text = "🚪";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.tableLayoutConfirm);
            this.Controls.Add(this.tableLayoutFoldersConfig);
            this.Controls.Add(this.tableLayoutMenu);
            this.Controls.Add(this.tableLayoutLabelConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLog";
            this.ShowIcon = false;
            this.Text = "Logs";
            this.tableLayoutLabelConfig.ResumeLayout(false);
            this.tableLayoutLabelConfig.PerformLayout();
            this.tableLayoutMenu.ResumeLayout(false);
            this.tableLayoutFoldersConfig.ResumeLayout(false);
            this.tableLayoutConfirm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutLabelConfig;
        private System.Windows.Forms.Label labelConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMenu;
        private System.Windows.Forms.Button buttonSmtpForm;
        private System.Windows.Forms.Button buttonFoldersForm;
        private System.Windows.Forms.Button buttonFormImages;
        private System.Windows.Forms.Button buttonLogsForm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutFoldersConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.ListView listViewLog;
    }
}