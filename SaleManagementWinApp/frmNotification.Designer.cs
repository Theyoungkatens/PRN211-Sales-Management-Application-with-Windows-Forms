namespace SaleManagementWinApp
{
    partial class frmNotification
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
            lblMessage = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(30, 34);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(59, 25);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label1";
            // 
            // frmNotification
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(414, 92);
            Controls.Add(lblMessage);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmNotification";
            Text = "Notification";
            Load += frmNotification_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMessage;
    }
}