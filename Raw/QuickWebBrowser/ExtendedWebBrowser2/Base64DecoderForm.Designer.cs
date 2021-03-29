namespace ExtendedWebBrowser2
{
    public partial class Base64DecoderForm
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base64DecoderForm));
            this.label1 = new System.Windows.Forms.Label();
            this.encodedStringTextBox = new System.Windows.Forms.TextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.decodedTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyAndCloseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encoded String:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // encodedStringTextBox
            // 
            this.encodedStringTextBox.Location = new System.Drawing.Point(139, 10);
            this.encodedStringTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encodedStringTextBox.Multiline = true;
            this.encodedStringTextBox.Name = "encodedStringTextBox";
            this.encodedStringTextBox.Size = new System.Drawing.Size(553, 88);
            this.encodedStringTextBox.TabIndex = 1;
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(299, 108);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(160, 30);
            this.decodeButton.TabIndex = 2;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.DecodeButtonClick);
            // 
            // decodedTextBox
            // 
            this.decodedTextBox.Location = new System.Drawing.Point(139, 148);
            this.decodedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decodedTextBox.Multiline = true;
            this.decodedTextBox.Name = "decodedTextBox";
            this.decodedTextBox.ReadOnly = true;
            this.decodedTextBox.Size = new System.Drawing.Size(553, 88);
            this.decodedTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(11, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 89);
            this.label2.TabIndex = 3;
            this.label2.Text = "Decoded String:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copyAndCloseButton
            // 
            this.copyAndCloseButton.Location = new System.Drawing.Point(224, 246);
            this.copyAndCloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyAndCloseButton.Name = "copyAndCloseButton";
            this.copyAndCloseButton.Size = new System.Drawing.Size(160, 28);
            this.copyAndCloseButton.TabIndex = 5;
            this.copyAndCloseButton.Text = "Copy and Close";
            this.copyAndCloseButton.UseVisualStyleBackColor = true;
            this.copyAndCloseButton.Click += new System.EventHandler(this.CopyAndCloseButtonClick);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(395, 246);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(149, 30);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // Base64DecoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 287);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.copyAndCloseButton);
            this.Controls.Add(this.decodedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.encodedStringTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Base64DecoderForm";
            this.Text = "Base64 Decoder (Giải mã link Flashget, Thunderbird)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.ComponentModel.IContainer components;

        private System.Windows.Forms.TextBox decodedTextBox;

        private System.Windows.Forms.Button closeButton;

        private System.Windows.Forms.Button copyAndCloseButton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button decodeButton;

        private System.Windows.Forms.TextBox encodedStringTextBox;

        private System.Windows.Forms.Label label1;
    }
}
