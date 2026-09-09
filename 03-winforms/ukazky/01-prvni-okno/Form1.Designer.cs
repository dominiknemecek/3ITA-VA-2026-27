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
        this.nameLabel = new System.Windows.Forms.Label();
        this.nameTextBox = new System.Windows.Forms.TextBox();
        this.greetButton = new System.Windows.Forms.Button();
        this.resultLabel = new System.Windows.Forms.Label();
        this.SuspendLayout();
        //
        // nameLabel
        //
        this.nameLabel.AutoSize = true;
        this.nameLabel.Location = new System.Drawing.Point(20, 20);
        this.nameLabel.Name = "nameLabel";
        this.nameLabel.Size = new System.Drawing.Size(83, 15);
        this.nameLabel.TabIndex = 0;
        this.nameLabel.Text = "Tvoje jméno:";
        //
        // nameTextBox
        //
        this.nameTextBox.Location = new System.Drawing.Point(120, 17);
        this.nameTextBox.Name = "nameTextBox";
        this.nameTextBox.Size = new System.Drawing.Size(150, 23);
        this.nameTextBox.TabIndex = 1;
        //
        // greetButton
        //
        this.greetButton.Location = new System.Drawing.Point(20, 55);
        this.greetButton.Name = "greetButton";
        this.greetButton.Size = new System.Drawing.Size(120, 30);
        this.greetButton.TabIndex = 2;
        this.greetButton.Text = "Pozdravit";
        this.greetButton.UseVisualStyleBackColor = true;
        this.greetButton.Click += new System.EventHandler(this.greetButton_Click);
        //
        // resultLabel
        //
        this.resultLabel.AutoSize = true;
        this.resultLabel.Location = new System.Drawing.Point(20, 100);
        this.resultLabel.Name = "resultLabel";
        this.resultLabel.Size = new System.Drawing.Size(0, 15);
        this.resultLabel.TabIndex = 3;
        //
        // Form1
        //
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(300, 150);
        this.Controls.Add(this.resultLabel);
        this.Controls.Add(this.greetButton);
        this.Controls.Add(this.nameTextBox);
        this.Controls.Add(this.nameLabel);
        this.Name = "Form1";
        this.Text = "První okno";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.Button greetButton;
    private System.Windows.Forms.Label resultLabel;
}
