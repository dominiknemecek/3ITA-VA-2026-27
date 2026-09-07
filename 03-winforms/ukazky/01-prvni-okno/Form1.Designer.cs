namespace PrvniOkno;

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
        this.popisekJmeno = new System.Windows.Forms.Label();
        this.textJmeno = new System.Windows.Forms.TextBox();
        this.tlacitkoPozdrav = new System.Windows.Forms.Button();
        this.popisekVysledek = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // popisekJmeno
        //
        this.popisekJmeno.AutoSize = true;
        this.popisekJmeno.Location = new System.Drawing.Point(20, 20);
        this.popisekJmeno.Name = "popisekJmeno";
        this.popisekJmeno.Size = new System.Drawing.Size(83, 15);
        this.popisekJmeno.TabIndex = 0;
        this.popisekJmeno.Text = "Tvoje jméno:";
        //
        // textJmeno
        //
        this.textJmeno.Location = new System.Drawing.Point(120, 17);
        this.textJmeno.Name = "textJmeno";
        this.textJmeno.Size = new System.Drawing.Size(150, 23);
        this.textJmeno.TabIndex = 1;
        //
        // tlacitkoPozdrav
        //
        this.tlacitkoPozdrav.Location = new System.Drawing.Point(20, 55);
        this.tlacitkoPozdrav.Name = "tlacitkoPozdrav";
        this.tlacitkoPozdrav.Size = new System.Drawing.Size(120, 30);
        this.tlacitkoPozdrav.TabIndex = 2;
        this.tlacitkoPozdrav.Text = "Pozdravit";
        this.tlacitkoPozdrav.UseVisualStyleBackColor = true;
        this.tlacitkoPozdrav.Click += new System.EventHandler(this.tlacitkoPozdrav_Click);
        //
        // popisekVysledek
        //
        this.popisekVysledek.AutoSize = true;
        this.popisekVysledek.Location = new System.Drawing.Point(20, 100);
        this.popisekVysledek.Name = "popisekVysledek";
        this.popisekVysledek.Size = new System.Drawing.Size(0, 15);
        this.popisekVysledek.TabIndex = 3;
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300, 150);
        this.Controls.Add(this.popisekVysledek);
        this.Controls.Add(this.tlacitkoPozdrav);
        this.Controls.Add(this.textJmeno);
        this.Controls.Add(this.popisekJmeno);
        this.Name = "Form1";
        this.Text = "První okno";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label popisekJmeno;
    private System.Windows.Forms.TextBox textJmeno;
    private System.Windows.Forms.Button tlacitkoPozdrav;
    private System.Windows.Forms.Label popisekVysledek;
}
