namespace SeznamAVyber;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Kód generovaný Návrhářem formulářů (needit ručně)

    private void InitializeComponent()
    {
        this.languageListBox = new System.Windows.Forms.ListBox();
        this.selectionLabel = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // languageListBox
        //
        this.languageListBox.Location = new System.Drawing.Point(20, 20);
        this.languageListBox.Name = "languageListBox";
        this.languageListBox.Size = new System.Drawing.Size(150, 94);
        this.languageListBox.TabIndex = 0;
        this.languageListBox.SelectedIndexChanged += new System.EventHandler(this.languageListBox_SelectedIndexChanged);
        //
        // selectionLabel
        //
        this.selectionLabel.AutoSize = true;
        this.selectionLabel.Location = new System.Drawing.Point(20, 130);
        this.selectionLabel.Name = "selectionLabel";
        this.selectionLabel.Size = new System.Drawing.Size(112, 15);
        this.selectionLabel.TabIndex = 1;
        this.selectionLabel.Text = "Zatím nic nevybráno";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(220, 180);
        this.Controls.Add(this.selectionLabel);
        this.Controls.Add(this.languageListBox);
        this.Name = "Form1";
        this.Text = "Seznam a výběr";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ListBox languageListBox;
    private System.Windows.Forms.Label selectionLabel;
}
