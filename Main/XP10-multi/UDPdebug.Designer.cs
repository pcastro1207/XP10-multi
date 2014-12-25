namespace XP10_multi
{
    partial class UDPdebug
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
            this.BT_console = new System.Windows.Forms.Button();
            this.BT_close = new System.Windows.Forms.Button();
            this.TB_destIP = new System.Windows.Forms.TextBox();
            this.TB_destPort = new System.Windows.Forms.TextBox();
            this.TB_listPort = new System.Windows.Forms.TextBox();
            this.TB_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lab_destIP = new System.Windows.Forms.Label();
            this.Lab_destPort = new System.Windows.Forms.Label();
            this.Lab_listPort = new System.Windows.Forms.Label();
            this.Lab_Title = new System.Windows.Forms.Label();
            this.Lab_message = new System.Windows.Forms.Label();
            this.Lab_status = new System.Windows.Forms.Label();
            this.TB_status = new System.Windows.Forms.TextBox();
            this.BT_reset = new System.Windows.Forms.Button();
            this.BT_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_console
            // 
            this.BT_console.Location = new System.Drawing.Point(26, 268);
            this.BT_console.Name = "BT_console";
            this.BT_console.Size = new System.Drawing.Size(111, 23);
            this.BT_console.TabIndex = 0;
            this.BT_console.Text = "Switch to Console";
            this.BT_console.UseVisualStyleBackColor = true;
            // 
            // BT_close
            // 
            this.BT_close.Location = new System.Drawing.Point(314, 268);
            this.BT_close.Name = "BT_close";
            this.BT_close.Size = new System.Drawing.Size(75, 23);
            this.BT_close.TabIndex = 1;
            this.BT_close.Text = "Close";
            this.BT_close.UseVisualStyleBackColor = true;
            this.BT_close.Click += new System.EventHandler(this.button2_Click);
            // 
            // TB_destIP
            // 
            this.TB_destIP.Location = new System.Drawing.Point(26, 48);
            this.TB_destIP.Name = "TB_destIP";
            this.TB_destIP.Size = new System.Drawing.Size(171, 20);
            this.TB_destIP.TabIndex = 2;
            // 
            // TB_destPort
            // 
            this.TB_destPort.Location = new System.Drawing.Point(303, 48);
            this.TB_destPort.Name = "TB_destPort";
            this.TB_destPort.Size = new System.Drawing.Size(69, 20);
            this.TB_destPort.TabIndex = 4;
            // 
            // TB_listPort
            // 
            this.TB_listPort.Location = new System.Drawing.Point(303, 74);
            this.TB_listPort.Name = "TB_listPort";
            this.TB_listPort.Size = new System.Drawing.Size(69, 20);
            this.TB_listPort.TabIndex = 5;
            // 
            // TB_message
            // 
            this.TB_message.Location = new System.Drawing.Point(26, 122);
            this.TB_message.Name = "TB_message";
            this.TB_message.Size = new System.Drawing.Size(346, 20);
            this.TB_message.TabIndex = 6;
            this.TB_message.TextChanged += new System.EventHandler(this.TB_message_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Lab_destIP
            // 
            this.Lab_destIP.AutoSize = true;
            this.Lab_destIP.Location = new System.Drawing.Point(23, 32);
            this.Lab_destIP.Name = "Lab_destIP";
            this.Lab_destIP.Size = new System.Drawing.Size(73, 13);
            this.Lab_destIP.TabIndex = 7;
            this.Lab_destIP.Text = "Destination IP";
            // 
            // Lab_destPort
            // 
            this.Lab_destPort.AutoSize = true;
            this.Lab_destPort.Location = new System.Drawing.Point(212, 51);
            this.Lab_destPort.Name = "Lab_destPort";
            this.Lab_destPort.Size = new System.Drawing.Size(85, 13);
            this.Lab_destPort.TabIndex = 8;
            this.Lab_destPort.Text = "Destination Port:";
            this.Lab_destPort.Click += new System.EventHandler(this.label3_Click);
            // 
            // Lab_listPort
            // 
            this.Lab_listPort.AutoSize = true;
            this.Lab_listPort.Location = new System.Drawing.Point(212, 77);
            this.Lab_listPort.Name = "Lab_listPort";
            this.Lab_listPort.Size = new System.Drawing.Size(74, 13);
            this.Lab_listPort.TabIndex = 10;
            this.Lab_listPort.Text = "Listening Port:";
            // 
            // Lab_Title
            // 
            this.Lab_Title.AutoSize = true;
            this.Lab_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab_Title.Location = new System.Drawing.Point(22, 9);
            this.Lab_Title.Name = "Lab_Title";
            this.Lab_Title.Size = new System.Drawing.Size(104, 20);
            this.Lab_Title.TabIndex = 11;
            this.Lab_Title.Text = "UDP Debug";
            // 
            // Lab_message
            // 
            this.Lab_message.AutoSize = true;
            this.Lab_message.Location = new System.Drawing.Point(23, 103);
            this.Lab_message.Name = "Lab_message";
            this.Lab_message.Size = new System.Drawing.Size(53, 13);
            this.Lab_message.TabIndex = 12;
            this.Lab_message.Text = "Message:";
            // 
            // Lab_status
            // 
            this.Lab_status.AutoSize = true;
            this.Lab_status.Location = new System.Drawing.Point(23, 154);
            this.Lab_status.Name = "Lab_status";
            this.Lab_status.Size = new System.Drawing.Size(40, 13);
            this.Lab_status.TabIndex = 14;
            this.Lab_status.Text = "Status:";
            // 
            // TB_status
            // 
            this.TB_status.Location = new System.Drawing.Point(26, 173);
            this.TB_status.Multiline = true;
            this.TB_status.Name = "TB_status";
            this.TB_status.Size = new System.Drawing.Size(346, 89);
            this.TB_status.TabIndex = 13;
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(233, 268);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(75, 23);
            this.BT_reset.TabIndex = 15;
            this.BT_reset.Text = "Reset";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // BT_clear
            // 
            this.BT_clear.Location = new System.Drawing.Point(152, 268);
            this.BT_clear.Name = "BT_clear";
            this.BT_clear.Size = new System.Drawing.Size(75, 23);
            this.BT_clear.TabIndex = 16;
            this.BT_clear.Text = "Clear";
            this.BT_clear.UseVisualStyleBackColor = true;
            this.BT_clear.Click += new System.EventHandler(this.BT_clear_Click);
            // 
            // UDPdebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 299);
            this.Controls.Add(this.BT_clear);
            this.Controls.Add(this.BT_reset);
            this.Controls.Add(this.Lab_status);
            this.Controls.Add(this.TB_status);
            this.Controls.Add(this.Lab_message);
            this.Controls.Add(this.Lab_Title);
            this.Controls.Add(this.Lab_listPort);
            this.Controls.Add(this.Lab_destPort);
            this.Controls.Add(this.Lab_destIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_message);
            this.Controls.Add(this.TB_listPort);
            this.Controls.Add(this.TB_destPort);
            this.Controls.Add(this.TB_destIP);
            this.Controls.Add(this.BT_close);
            this.Controls.Add(this.BT_console);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(417, 338);
            this.MinimumSize = new System.Drawing.Size(417, 338);
            this.Name = "UDPdebug";
            this.Text = "XP10-multi: UDPdebug";
            this.Load += new System.EventHandler(this.UDPdebug_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_console;
        private System.Windows.Forms.Button BT_close;
        private System.Windows.Forms.TextBox TB_destIP;
        private System.Windows.Forms.TextBox TB_destPort;
        private System.Windows.Forms.TextBox TB_listPort;
        private System.Windows.Forms.TextBox TB_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lab_destIP;
        private System.Windows.Forms.Label Lab_destPort;
        private System.Windows.Forms.Label Lab_listPort;
        private System.Windows.Forms.Label Lab_Title;
        private System.Windows.Forms.Label Lab_message;
        private System.Windows.Forms.Label Lab_status;
        private System.Windows.Forms.TextBox TB_status;
        private System.Windows.Forms.Button BT_reset;
        private System.Windows.Forms.Button BT_clear;
    }
}