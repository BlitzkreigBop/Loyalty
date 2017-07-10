namespace Loyalty
{
  partial class Loyalty
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
      if (disposing && (components != null)) {
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
      this.startGameButton = new System.Windows.Forms.Button();
      this.numberPlayers = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numberPlayers)).BeginInit();
      this.SuspendLayout();
      // 
      // startGameButton
      // 
      this.startGameButton.Location = new System.Drawing.Point(116, 145);
      this.startGameButton.Name = "startGameButton";
      this.startGameButton.Size = new System.Drawing.Size(75, 23);
      this.startGameButton.TabIndex = 50;
      this.startGameButton.Text = "Start Game";
      this.startGameButton.UseVisualStyleBackColor = true;
      this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
      // 
      // numberPlayers
      // 
      this.numberPlayers.Location = new System.Drawing.Point(97, 82);
      this.numberPlayers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
      this.numberPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numberPlayers.Name = "numberPlayers";
      this.numberPlayers.Size = new System.Drawing.Size(120, 22);
      this.numberPlayers.TabIndex = 71;
      this.numberPlayers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numberPlayers.ValueChanged += new System.EventHandler(this.numberPlayers_ValueChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(94, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(128, 17);
      this.label1.TabIndex = 72;
      this.label1.Text = "Number Of Players";
      // 
      // Loyalty
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(331, 1029);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numberPlayers);
      this.Controls.Add(this.startGameButton);
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Loyalty";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numberPlayers)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button startGameButton;
    private System.Windows.Forms.NumericUpDown numberPlayers;
    private System.Windows.Forms.Label label1;
  }
}

