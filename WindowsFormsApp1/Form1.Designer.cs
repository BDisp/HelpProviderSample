
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.helpLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // addressTextBox
            // 
            this.helpProvider1.SetHelpKeyword(this.addressTextBox, "Contents\\Address.htm");
            this.helpProvider1.SetHelpNavigator(this.addressTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.addressTextBox, "Enter the street address in this text box.");
            this.addressTextBox.Location = new System.Drawing.Point(16, 24);
            this.addressTextBox.Name = "addressTextBox";
            this.helpProvider1.SetShowHelp(this.addressTextBox, true);
            this.addressTextBox.Size = new System.Drawing.Size(264, 27);
            this.addressTextBox.TabIndex = 0;
            this.addressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTextBox_KeyDown);
            // 
            // helpLabel
            // 
            this.helpLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.helpProvider1.SetHelpKeyword(this.helpLabel, "");
            this.helpProvider1.SetHelpString(this.helpLabel, "");
            this.helpLabel.Location = new System.Drawing.Point(8, 80);
            this.helpLabel.Name = "helpLabel";
            this.helpProvider1.SetShowHelp(this.helpLabel, false);
            this.helpLabel.Size = new System.Drawing.Size(272, 105);
            this.helpLabel.TabIndex = 9;
            this.helpLabel.Text = "Click the Help button in the title bar, then click a control to see a Help toolti" +
    "p for the control.  Click on a control and press F1 to invoke the Help system wi" +
    "th a sample Help file.";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address:";
            // 
            // cityTextBox
            // 
            this.helpProvider1.SetHelpKeyword(this.cityTextBox, "Contents\\City.htm");
            this.helpProvider1.SetHelpNavigator(this.cityTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.cityTextBox, "Enter the city here.");
            this.cityTextBox.Location = new System.Drawing.Point(16, 50);
            this.cityTextBox.Name = "cityTextBox";
            this.helpProvider1.SetShowHelp(this.cityTextBox, true);
            this.cityTextBox.Size = new System.Drawing.Size(120, 27);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cityTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(136, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = ",";
            // 
            // stateTextBox
            // 
            this.helpProvider1.SetHelpKeyword(this.stateTextBox, "Contents\\State.htm");
            this.helpProvider1.SetHelpNavigator(this.stateTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.stateTextBox, "Enter the state in this text box.");
            this.stateTextBox.Location = new System.Drawing.Point(152, 50);
            this.stateTextBox.MaxLength = 2;
            this.stateTextBox.Name = "stateTextBox";
            this.helpProvider1.SetShowHelp(this.stateTextBox, true);
            this.stateTextBox.Size = new System.Drawing.Size(32, 27);
            this.stateTextBox.TabIndex = 5;
            this.stateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.stateTextBox_KeyDown);
            // 
            // zipTextBox
            // 
            this.helpProvider1.SetHelpKeyword(this.zipTextBox, "Contents\\Zip.htm");
            this.helpProvider1.SetHelpNavigator(this.zipTextBox, System.Windows.Forms.HelpNavigator.Topic);
            this.helpProvider1.SetHelpString(this.zipTextBox, "Enter the zip code here.");
            this.zipTextBox.Location = new System.Drawing.Point(192, 50);
            this.zipTextBox.Name = "zipTextBox";
            this.helpProvider1.SetShowHelp(this.zipTextBox, true);
            this.zipTextBox.Size = new System.Drawing.Size(88, 27);
            this.zipTextBox.TabIndex = 6;
            this.zipTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.zipTextBox_KeyDown);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "HelpProviderChmSample.chm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 202);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.addressTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, false);
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Label helpLabel;
    }
}

