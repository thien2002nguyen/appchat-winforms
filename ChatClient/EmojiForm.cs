using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppChat
{
    public partial class EmojiForm : Form
    {
        private Panel panel1;
        private TextBox targetTextBox;
        private List<string> emojiList;

        public EmojiForm(TextBox textBox)
        {
            InitializeComponent();
            targetTextBox = textBox;
            InitializeEmojiButtons();
        }

        private void InitializeEmojiButtons()
        {
            emojiList = new List<string>
            {
                "😊", "😂", "😍", "🥰", "😎", "🤩", "😜", "😇", "🤗", "😏",
                "😐", "😑", "😒", "🙄", "😬", "😌", "😔", "😪", "😢", "😓",
                "😕", "😖", "😷", "🤒", "🤕", "🤢", "🤮", "🤧", "🥵", "🥶",
                "😵", "🤯", "🤠", "🥳", "😎", "🤓", "🧐", "😕", "😟", "🙁",
                "☹️", "😮", "😯", "😲", "😳", "🥺", "😦", "😧", "😨", "😰"
            };

            UpdateEmojiLayout();
            this.SizeChanged += (sender, e) => UpdateEmojiLayout();
        }

        private void UpdateEmojiLayout()
        {
            int buttonSize = 40;
            int spacing = 5;

            int colCount = Math.Max(1, panel1.Width / (buttonSize + spacing));
            int rowCount = (int)Math.Ceiling((double)emojiList.Count / colCount);

            panel1.Controls.Clear();

            for (int i = 0; i < emojiList.Count; i++)
            {
                int col = i % colCount;
                int row = i / colCount;

                AddEmojiButton(emojiList[i], col, row, buttonSize);
            }

            int totalHeight = rowCount * (buttonSize + spacing);
            panel1.Size = new Size(panel1.Width, totalHeight);
        }

        public void Emoji_Click(object sender, EventArgs e)
        {
            Button emojiButton = (Button)sender;
            targetTextBox.AppendText(emojiButton.Text);
        }

        private void AddEmojiButton(string emoji, int col, int row, int buttonSize)
        {
            Button emojiButton = new Button();
            emojiButton.Text = emoji;
            emojiButton.Font = new Font("Segoe UI Emoji", 18);
            emojiButton.Size = new Size(buttonSize, buttonSize);
            emojiButton.Location = new Point(col * (buttonSize + 5), row * (buttonSize + 5));
            emojiButton.Click += new EventHandler(Emoji_Click);
            panel1.Controls.Add(emojiButton);
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 232);
            this.panel1.TabIndex = 0;
            // 
            // EmojiForm
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(250, 256);
            this.Controls.Add(this.panel1);
            this.Name = "EmojiForm";
            this.Text = "Emoji";
            this.ResumeLayout(false);

        }

    }
}

