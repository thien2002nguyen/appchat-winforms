namespace AppChat
{
    partial class ChatServer
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.MenuIcon = new System.Windows.Forms.ToolStrip();
            this.btnAddImage = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMessage = new System.Windows.Forms.ToolStripButton();
            this.listClient = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.listViewMessage = new System.Windows.Forms.RichTextBox();
            this.MenuIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSend.Location = new System.Drawing.Point(659, 392);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSend.Location = new System.Drawing.Point(12, 392);
            this.txtSend.Multiline = true;
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(585, 50);
            this.txtSend.TabIndex = 2;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            // 
            // MenuIcon
            // 
            this.MenuIcon.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.MenuIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddImage,
            this.btnDeleteMessage});
            this.MenuIcon.Location = new System.Drawing.Point(0, 0);
            this.MenuIcon.Name = "MenuIcon";
            this.MenuIcon.Size = new System.Drawing.Size(746, 35);
            this.MenuIcon.TabIndex = 5;
            this.MenuIcon.Text = "toolStrip1";
            // 
            // btnAddImage
            // 
            this.btnAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddImage.Image = global::AppChat.Properties.Resources.image;
            this.btnAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(32, 32);
            this.btnAddImage.Text = "Chọn ảnh";
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteMessage.Image = global::AppChat.Properties.Resources.email;
            this.btnDeleteMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMessage.Margin = new System.Windows.Forms.Padding(2, 1, 8, 2);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteMessage.Text = "toolStripButton1";
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // listClient
            // 
            this.listClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listClient.FormattingEnabled = true;
            this.listClient.Location = new System.Drawing.Point(12, 45);
            this.listClient.Name = "listClient";
            this.listClient.ScrollAlwaysVisible = true;
            this.listClient.Size = new System.Drawing.Size(181, 298);
            this.listClient.TabIndex = 8;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelectAll.Location = new System.Drawing.Point(13, 350);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(98, 36);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(117, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 36);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEmoji
            // 
            this.btnEmoji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmoji.BackgroundImage = global::AppChat.Properties.Resources.happy;
            this.btnEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmoji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmoji.Location = new System.Drawing.Point(603, 392);
            this.btnEmoji.Name = "btnEmoji";
            this.btnEmoji.Size = new System.Drawing.Size(50, 50);
            this.btnEmoji.TabIndex = 9;
            this.btnEmoji.UseVisualStyleBackColor = true;
            this.btnEmoji.Click += new System.EventHandler(this.btnEmoji_Click);
            // 
            // listViewMessage
            // 
            this.listViewMessage.Enabled = false;
            this.listViewMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listViewMessage.Location = new System.Drawing.Point(213, 45);
            this.listViewMessage.Name = "listViewMessage";
            this.listViewMessage.Size = new System.Drawing.Size(521, 341);
            this.listViewMessage.TabIndex = 12;
            this.listViewMessage.Text = "";
            // 
            // ChatServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.listViewMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.listClient);
            this.Controls.Add(this.MenuIcon);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.btnSend);
            this.Name = "ChatServer";
            this.Text = "Chat Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatServer_FormClosed);
            this.MenuIcon.ResumeLayout(false);
            this.MenuIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.ToolStrip MenuIcon;
        private System.Windows.Forms.ToolStripButton btnDeleteMessage;
        private System.Windows.Forms.ToolStripButton btnAddImage;
        private System.Windows.Forms.CheckedListBox listClient;
        private System.Windows.Forms.Button btnEmoji;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox listViewMessage;
    }
}

