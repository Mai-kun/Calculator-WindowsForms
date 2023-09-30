namespace Calculator
{
    partial class HistoryForm
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
            txtHistory = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // txtHistory
            // 
            txtHistory.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtHistory.Location = new System.Drawing.Point(12, 9);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.ReadOnly = true;
            txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtHistory.Size = new System.Drawing.Size(275, 267);
            txtHistory.TabIndex = 0;
            // 
            // HistoryForm
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(298, 287);
            Controls.Add(txtHistory);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "HistoryForm";
            Text = "History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtHistory;
    }
}