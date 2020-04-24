namespace frmClient
{
    partial class Client
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
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.rtb_history = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(221, 359);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(74, 38);
            this.btn_Send.TabIndex = 8;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click_1);
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(5, 359);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(201, 38);
            this.txt_Message.TabIndex = 7;
            // 
            // rtb_history
            // 
            this.rtb_history.Location = new System.Drawing.Point(5, 7);
            this.rtb_history.Name = "rtb_history";
            this.rtb_history.ReadOnly = true;
            this.rtb_history.Size = new System.Drawing.Size(290, 346);
            this.rtb_history.TabIndex = 6;
            this.rtb_history.Text = "";
            // 
            // Client
            // 
            this.AcceptButton = this.btn_Send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 402);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.rtb_history);
            this.Name = "Client";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.RichTextBox rtb_history;
    }
}

