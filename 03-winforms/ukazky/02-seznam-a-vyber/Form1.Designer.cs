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
        this.seznamJazyku = new System.Windows.Forms.ListBox();
        this.popisekVyber = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // seznamJazyku
        //
        this.seznamJazyku.Location = new System.Drawing.Point(20, 20);
        this.seznamJazyku.Name = "seznamJazyku";
        this.seznamJazyku.Size = new System.Drawing.Size(150, 94);
        this.seznamJazyku.TabIndex = 0;
        this.seznamJazyku.SelectedIndexChanged += new System.EventHandler(this.seznamJazyku_SelectedIndexChanged);
        //
        // popisekVyber
        //
        this.popisekVyber.AutoSize = true;
        this.popisekVyber.Location = new System.Drawing.Point(20, 130);
        this.popisekVyber.Name = "popisekVyber";
        this.popisekVyber.Size = new System.Drawing.Size(112, 15);
        this.popisekVyber.TabIndex = 1;
        this.popisekVyber.Text = "Zatím nic nevybráno";
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(220, 180);
        this.Controls.Add(this.popisekVyber);
        this.Controls.Add(this.seznamJazyku);
        this.Name = "Form1";
        this.Text = "Seznam a výběr";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.ListBox seznamJazyku;
    private System.Windows.Forms.Label popisekVyber;
}
