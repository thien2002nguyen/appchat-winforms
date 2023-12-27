namespace ChatClient
{
    partial class ChatClient
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
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.MenuIcon = new System.Windows.Forms.ToolStrip();
            this.btnAddImage = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMessage = new System.Windows.Forms.ToolStripButton();
            this.btnEmoji = new System.Windows.Forms.Button();
            this.listViewMessage = new System.Windows.Forms.RichTextBox();
            this.MenuIcon.SuspendLayout();
            this.SuspendLayout();
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
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSend.Location = new System.Drawing.Point(659, 393);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 49);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
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
            this.MenuIcon.TabIndex = 7;
            this.MenuIcon.Text = "toolStrip1";
            // 
            // btnAddImage
            // 
            this.btnAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddImage.Image = global::ChatClient.Properties.Resources.image;
            this.btnAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(0, 1, 8, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(32, 32);
            this.btnAddImage.Text = "Chọn ảnh";
            // 
            // btnDeleteMessage
            // 
            this.btnDeleteMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteMessage.Image = global::ChatClient.Properties.Resources.email;
            this.btnDeleteMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMessage.Margin = new System.Windows.Forms.Padding(2, 1, 8, 2);
            this.btnDeleteMessage.Name = "btnDeleteMessage";
            this.btnDeleteMessage.Size = new System.Drawing.Size(32, 32);
            this.btnDeleteMessage.Text = "Xóa đoạn chat";
            this.btnDeleteMessage.Click += new System.EventHandler(this.btnDeleteMessage_Click);
            // 
            // btnEmoji
            // 
            this.btnEmoji.BackgroundImage = global::ChatClient.Properties.Resources.happy;
            this.btnEmoji.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmoji.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmoji.FlatAppearance.BorderSize = 0;
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
            this.listViewMessage.Location = new System.Drawing.Point(12, 45);
            this.listViewMessage.Name = "listViewMessage";
            this.listViewMessage.Size = new System.Drawing.Size(722, 341);
            this.listViewMessage.TabIndex = 10;
            this.listViewMessage.Text = "";
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.listViewMessage);
            this.Controls.Add(this.btnEmoji);
            this.Controls.Add(this.MenuIcon);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Name = "ChatClient";
            this.Text = "Chat Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatClient_FormClosed);
            this.MenuIcon.ResumeLayout(false);
            this.MenuIcon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ToolStrip MenuIcon;
        private System.Windows.Forms.ToolStripButton btnDeleteMessage;
        private System.Windows.Forms.ToolStripButton btnAddImage;
        private System.Windows.Forms.Button btnEmoji;
        private System.Windows.Forms.RichTextBox listViewMessage;
    }
}

