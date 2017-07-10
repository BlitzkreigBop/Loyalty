namespace Engine
{
  partial class PlayerForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.lblPlayerNum = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblTurnCardNum = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lblPeasantsNum = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblHinterlands = new System.Windows.Forms.Label();
      this.numRmvPeasant = new System.Windows.Forms.NumericUpDown();
      this.btnRemovePlayersPeasant = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.lblNumGold = new System.Windows.Forms.Label();
      this.btnTakeTurn = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numRmvPeasant)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(102, 17);
      this.label1.TabIndex = 0;
      this.label1.Text = "Player Number";
      // 
      // lblPlayerNum
      // 
      this.lblPlayerNum.AutoSize = true;
      this.lblPlayerNum.Location = new System.Drawing.Point(203, 27);
      this.lblPlayerNum.Name = "lblPlayerNum";
      this.lblPlayerNum.Size = new System.Drawing.Size(16, 17);
      this.lblPlayerNum.TabIndex = 1;
      this.lblPlayerNum.Text = "#";
      this.lblPlayerNum.UseMnemonic = false;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(29, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(126, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "Turn Card Number";
      // 
      // lblTurnCardNum
      // 
      this.lblTurnCardNum.AutoSize = true;
      this.lblTurnCardNum.Location = new System.Drawing.Point(203, 79);
      this.lblTurnCardNum.Name = "lblTurnCardNum";
      this.lblTurnCardNum.Size = new System.Drawing.Size(16, 17);
      this.lblTurnCardNum.TabIndex = 3;
      this.lblTurnCardNum.Text = "#";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(32, 142);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(67, 17);
      this.label3.TabIndex = 4;
      this.label3.Text = "Peasants";
      // 
      // lblPeasantsNum
      // 
      this.lblPeasantsNum.AutoSize = true;
      this.lblPeasantsNum.Location = new System.Drawing.Point(200, 142);
      this.lblPeasantsNum.Name = "lblPeasantsNum";
      this.lblPeasantsNum.Size = new System.Drawing.Size(16, 17);
      this.lblPeasantsNum.TabIndex = 5;
      this.lblPeasantsNum.Text = "#";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(32, 201);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(80, 17);
      this.label5.TabIndex = 6;
      this.label5.Text = "Hinterlands";
      // 
      // lblHinterlands
      // 
      this.lblHinterlands.AutoSize = true;
      this.lblHinterlands.Location = new System.Drawing.Point(203, 201);
      this.lblHinterlands.Name = "lblHinterlands";
      this.lblHinterlands.Size = new System.Drawing.Size(16, 17);
      this.lblHinterlands.TabIndex = 7;
      this.lblHinterlands.Text = "#";
      // 
      // numRmvPeasant
      // 
      this.numRmvPeasant.Location = new System.Drawing.Point(35, 368);
      this.numRmvPeasant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numRmvPeasant.Name = "numRmvPeasant";
      this.numRmvPeasant.Size = new System.Drawing.Size(120, 22);
      this.numRmvPeasant.TabIndex = 9;
      this.numRmvPeasant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // btnRemovePlayersPeasant
      // 
      this.btnRemovePlayersPeasant.Location = new System.Drawing.Point(35, 313);
      this.btnRemovePlayersPeasant.Name = "btnRemovePlayersPeasant";
      this.btnRemovePlayersPeasant.Size = new System.Drawing.Size(210, 23);
      this.btnRemovePlayersPeasant.TabIndex = 10;
      this.btnRemovePlayersPeasant.Text = "Remove Player\'s Peasant";
      this.btnRemovePlayersPeasant.UseVisualStyleBackColor = true;
      this.btnRemovePlayersPeasant.Click += new System.EventHandler(this.btnRemovePlayersPeasant_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(35, 253);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 17);
      this.label4.TabIndex = 11;
      this.label4.Text = "Gold";
      // 
      // lblNumGold
      // 
      this.lblNumGold.AutoSize = true;
      this.lblNumGold.Location = new System.Drawing.Point(203, 253);
      this.lblNumGold.Name = "lblNumGold";
      this.lblNumGold.Size = new System.Drawing.Size(16, 17);
      this.lblNumGold.TabIndex = 12;
      this.lblNumGold.Text = "#";
      // 
      // btnTakeTurn
      // 
      this.btnTakeTurn.Enabled = false;
      this.btnTakeTurn.Location = new System.Drawing.Point(38, 424);
      this.btnTakeTurn.Name = "btnTakeTurn";
      this.btnTakeTurn.Size = new System.Drawing.Size(207, 23);
      this.btnTakeTurn.TabIndex = 13;
      this.btnTakeTurn.Text = "Take Turn";
      this.btnTakeTurn.UseVisualStyleBackColor = true;
      this.btnTakeTurn.Click += new System.EventHandler(this.btnTakeTurn_Click);
      // 
      // PlayerForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(282, 542);
      this.Controls.Add(this.btnTakeTurn);
      this.Controls.Add(this.lblNumGold);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btnRemovePlayersPeasant);
      this.Controls.Add(this.numRmvPeasant);
      this.Controls.Add(this.lblHinterlands);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.lblPeasantsNum);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lblTurnCardNum);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lblPlayerNum);
      this.Controls.Add(this.label1);
      this.Name = "PlayerForm";
      this.Text = "PlayerForm";
      ((System.ComponentModel.ISupportInitialize)(this.numRmvPeasant)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    System.Windows.Forms.Label lblPlayerNum;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblTurnCardNum;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lblPeasantsNum;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblHinterlands;
    private System.Windows.Forms.NumericUpDown numRmvPeasant;
    private System.Windows.Forms.Button btnRemovePlayersPeasant;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label lblNumGold;
    private System.Windows.Forms.Button btnTakeTurn;
  }
}