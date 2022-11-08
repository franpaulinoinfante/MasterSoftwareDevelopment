namespace Mastermind.WinFormApp.Views
{
    partial class WinFormView
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
            this.txtProposedCombination = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddProposedCombination = new System.Windows.Forms.Button();
            this.lblSecrectCombination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtProposedCombination
            // 
            this.txtProposedCombination.Location = new System.Drawing.Point(165, 89);
            this.txtProposedCombination.Name = "txtProposedCombination";
            this.txtProposedCombination.Size = new System.Drawing.Size(100, 23);
            this.txtProposedCombination.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Location = new System.Drawing.Point(142, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(17, 15);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "--";
            // 
            // btnAddProposedCombination
            // 
            this.btnAddProposedCombination.Location = new System.Drawing.Point(165, 131);
            this.btnAddProposedCombination.Name = "btnAddProposedCombination";
            this.btnAddProposedCombination.Size = new System.Drawing.Size(75, 23);
            this.btnAddProposedCombination.TabIndex = 2;
            this.btnAddProposedCombination.Text = "Add";
            this.btnAddProposedCombination.UseVisualStyleBackColor = true;
            // 
            // lblSecrectCombination
            // 
            this.lblSecrectCombination.AutoSize = true;
            this.lblSecrectCombination.Location = new System.Drawing.Point(23, 53);
            this.lblSecrectCombination.Name = "lblSecrectCombination";
            this.lblSecrectCombination.Size = new System.Drawing.Size(22, 15);
            this.lblSecrectCombination.TabIndex = 3;
            this.lblSecrectCombination.Text = "---";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proposed Combination :";
            // 
            // listResults
            // 
            this.listResults.FormattingEnabled = true;
            this.listResults.ItemHeight = 15;
            this.listResults.Location = new System.Drawing.Point(12, 178);
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(381, 154);
            this.listResults.TabIndex = 5;
            // 
            // WinFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 337);
            this.Controls.Add(this.listResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSecrectCombination);
            this.Controls.Add(this.btnAddProposedCombination);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtProposedCombination);
            this.Name = "WinFormView";
            this.Text = "WinFormView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtProposedCombination;
        private Label lblTitle;
        private Button btnAddProposedCombination;
        private Label lblSecrectCombination;
        private Label label1;
        private ListBox listResults;
    }
}