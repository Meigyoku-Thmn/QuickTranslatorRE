

namespace ExtendedWebBrowser2
{
    internal partial class BrowserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserControl));
            this.containerPanel = new System.Windows.Forms.Panel();
            this.browser = new ExtendedWebBrowser2.ExtendedWebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addressDropDown = new System.Windows.Forms.ComboBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.containerPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.browser);
            resources.ApplyResources(this.containerPanel, "containerPanel");
            this.containerPanel.Name = "containerPanel";
            // 
            // browser
            // 
            resources.ApplyResources(this.browser, "browser");
            this.browser.Name = "browser";
            this.browser.ScriptErrorsSuppressed = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addressDropDown);
            this.panel2.Controls.Add(this.goButton);
            this.panel2.Controls.Add(this.label1);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // addressDropDown
            // 
            resources.ApplyResources(this.addressDropDown, "addressDropDown");
            this.addressDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.addressDropDown.FormattingEnabled = true;
            this.addressDropDown.Name = "addressDropDown";
            // 
            // goButton
            // 
            resources.ApplyResources(this.goButton, "goButton");
            this.goButton.FlatAppearance.BorderSize = 0;
            this.goButton.Name = "goButton";
            this.goButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // BrowserControl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.panel2);
            this.Name = "BrowserControl";
            this.containerPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox addressDropDown;

        private ExtendedWebBrowser browser;

        private System.Windows.Forms.Panel containerPanel;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Button goButton;

        private System.Windows.Forms.Label label1;
    }
}
