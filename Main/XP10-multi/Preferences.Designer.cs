namespace XP10_multi
{
    partial class Preferences
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
            this.Tab_Preferences = new System.Windows.Forms.TabControl();
            this.Tab_GenSettings = new System.Windows.Forms.TabPage();
            this.Tab_IOsettings = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Tab_NetSettings = new System.Windows.Forms.TabPage();
            this.BT_configInput = new System.Windows.Forms.Button();
            this.BT_configOutput = new System.Windows.Forms.Button();
            this.BT_debugCOM = new System.Windows.Forms.Button();
            this.TB_debugCOM = new System.Windows.Forms.TextBox();
            this.TB_configOutput = new System.Windows.Forms.TextBox();
            this.TB_configInput = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.Tab_Preferences.SuspendLayout();
            this.Tab_IOsettings.SuspendLayout();
            this.Tab_NetSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Preferences
            // 
            this.Tab_Preferences.Controls.Add(this.Tab_GenSettings);
            this.Tab_Preferences.Controls.Add(this.Tab_IOsettings);
            this.Tab_Preferences.Controls.Add(this.Tab_NetSettings);
            this.Tab_Preferences.Location = new System.Drawing.Point(12, 12);
            this.Tab_Preferences.Name = "Tab_Preferences";
            this.Tab_Preferences.SelectedIndex = 0;
            this.Tab_Preferences.Size = new System.Drawing.Size(377, 343);
            this.Tab_Preferences.TabIndex = 0;
            // 
            // Tab_GenSettings
            // 
            this.Tab_GenSettings.Location = new System.Drawing.Point(4, 22);
            this.Tab_GenSettings.Name = "Tab_GenSettings";
            this.Tab_GenSettings.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_GenSettings.Size = new System.Drawing.Size(369, 317);
            this.Tab_GenSettings.TabIndex = 0;
            this.Tab_GenSettings.Text = "General";
            this.Tab_GenSettings.UseVisualStyleBackColor = true;
            // 
            // Tab_IOsettings
            // 
            this.Tab_IOsettings.Controls.Add(this.TB_configInput);
            this.Tab_IOsettings.Controls.Add(this.TB_configOutput);
            this.Tab_IOsettings.Controls.Add(this.TB_debugCOM);
            this.Tab_IOsettings.Controls.Add(this.BT_debugCOM);
            this.Tab_IOsettings.Controls.Add(this.BT_configOutput);
            this.Tab_IOsettings.Controls.Add(this.BT_configInput);
            this.Tab_IOsettings.Location = new System.Drawing.Point(4, 22);
            this.Tab_IOsettings.Name = "Tab_IOsettings";
            this.Tab_IOsettings.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_IOsettings.Size = new System.Drawing.Size(369, 317);
            this.Tab_IOsettings.TabIndex = 1;
            this.Tab_IOsettings.Text = "I/O Settings";
            this.Tab_IOsettings.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(152, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Tab_NetSettings
            // 
            this.Tab_NetSettings.Controls.Add(this.textBox5);
            this.Tab_NetSettings.Controls.Add(this.button8);
            this.Tab_NetSettings.Controls.Add(this.textBox4);
            this.Tab_NetSettings.Controls.Add(this.button7);
            this.Tab_NetSettings.Location = new System.Drawing.Point(4, 22);
            this.Tab_NetSettings.Name = "Tab_NetSettings";
            this.Tab_NetSettings.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_NetSettings.Size = new System.Drawing.Size(369, 317);
            this.Tab_NetSettings.TabIndex = 2;
            this.Tab_NetSettings.Text = "Network";
            this.Tab_NetSettings.UseVisualStyleBackColor = true;
            // 
            // BT_configInput
            // 
            this.BT_configInput.Location = new System.Drawing.Point(184, 92);
            this.BT_configInput.Name = "BT_configInput";
            this.BT_configInput.Size = new System.Drawing.Size(179, 23);
            this.BT_configInput.TabIndex = 0;
            this.BT_configInput.Text = "Configure Input Settings";
            this.BT_configInput.UseVisualStyleBackColor = true;
            // 
            // BT_configOutput
            // 
            this.BT_configOutput.Location = new System.Drawing.Point(184, 190);
            this.BT_configOutput.Name = "BT_configOutput";
            this.BT_configOutput.Size = new System.Drawing.Size(179, 23);
            this.BT_configOutput.TabIndex = 1;
            this.BT_configOutput.Text = "Configure Output Settings";
            this.BT_configOutput.UseVisualStyleBackColor = true;
            // 
            // BT_debugCOM
            // 
            this.BT_debugCOM.Location = new System.Drawing.Point(184, 288);
            this.BT_debugCOM.Name = "BT_debugCOM";
            this.BT_debugCOM.Size = new System.Drawing.Size(179, 23);
            this.BT_debugCOM.TabIndex = 2;
            this.BT_debugCOM.Text = "COM Port Debug";
            this.BT_debugCOM.UseVisualStyleBackColor = true;
            // 
            // TB_debugCOM
            // 
            this.TB_debugCOM.Location = new System.Drawing.Point(6, 219);
            this.TB_debugCOM.Multiline = true;
            this.TB_debugCOM.Name = "TB_debugCOM";
            this.TB_debugCOM.ReadOnly = true;
            this.TB_debugCOM.Size = new System.Drawing.Size(357, 63);
            this.TB_debugCOM.TabIndex = 3;
            this.TB_debugCOM.Text = "Debug:\r\n\r\nUse this tool to test COM port connection settings.";
            // 
            // TB_configOutput
            // 
            this.TB_configOutput.Location = new System.Drawing.Point(6, 121);
            this.TB_configOutput.Multiline = true;
            this.TB_configOutput.Name = "TB_configOutput";
            this.TB_configOutput.ReadOnly = true;
            this.TB_configOutput.Size = new System.Drawing.Size(357, 63);
            this.TB_configOutput.TabIndex = 4;
            this.TB_configOutput.Text = "Output Settings:\r\n\r\nUse this tool to configure output settings.";
            // 
            // TB_configInput
            // 
            this.TB_configInput.Location = new System.Drawing.Point(6, 23);
            this.TB_configInput.Multiline = true;
            this.TB_configInput.Name = "TB_configInput";
            this.TB_configInput.ReadOnly = true;
            this.TB_configInput.Size = new System.Drawing.Size(357, 63);
            this.TB_configInput.TabIndex = 5;
            this.TB_configInput.Text = "Input Settings:\r\n\r\nUse this tool to configure input devices.";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 219);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(357, 63);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Debug:\r\n\r\nUse this tool to test communication settings with flight simulator.";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(184, 288);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(179, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "UDP Debug";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 121);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(357, 63);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Network Settings:\r\n\r\nUse this tool to configure UDP connection settings.";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(184, 190);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(179, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Configure Net Settings";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 396);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tab_Preferences);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Text = "XP10-multi: Preferences";
            this.Tab_Preferences.ResumeLayout(false);
            this.Tab_IOsettings.ResumeLayout(false);
            this.Tab_IOsettings.PerformLayout();
            this.Tab_NetSettings.ResumeLayout(false);
            this.Tab_NetSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Preferences;
        private System.Windows.Forms.TabPage Tab_GenSettings;
        private System.Windows.Forms.TabPage Tab_IOsettings;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TB_configInput;
        private System.Windows.Forms.TextBox TB_configOutput;
        private System.Windows.Forms.TextBox TB_debugCOM;
        private System.Windows.Forms.Button BT_debugCOM;
        private System.Windows.Forms.Button BT_configOutput;
        private System.Windows.Forms.Button BT_configInput;
        private System.Windows.Forms.TabPage Tab_NetSettings;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button8;
    }
}