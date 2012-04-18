namespace ResizeImagesSettings
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.btnRightClick = new System.Windows.Forms.Button();
      this.spinWidth = new System.Windows.Forms.NumericUpDown();
      this.spinHeight = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSetSize = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.spinWidth)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spinHeight)).BeginInit();
      this.SuspendLayout();
      // 
      // btnRightClick
      // 
      this.btnRightClick.Location = new System.Drawing.Point(12, 12);
      this.btnRightClick.Name = "btnRightClick";
      this.btnRightClick.Size = new System.Drawing.Size(131, 23);
      this.btnRightClick.TabIndex = 0;
      this.btnRightClick.Text = "Create Right Click";
      this.btnRightClick.UseVisualStyleBackColor = true;
      this.btnRightClick.Click += new System.EventHandler(this.btnRightClick_Click);
      // 
      // spinWidth
      // 
      this.spinWidth.Location = new System.Drawing.Point(145, 69);
      this.spinWidth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.spinWidth.Name = "spinWidth";
      this.spinWidth.Size = new System.Drawing.Size(120, 20);
      this.spinWidth.TabIndex = 1;
      // 
      // spinHeight
      // 
      this.spinHeight.Location = new System.Drawing.Point(145, 111);
      this.spinHeight.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.spinHeight.Name = "spinHeight";
      this.spinHeight.Size = new System.Drawing.Size(120, 20);
      this.spinHeight.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 71);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Width";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(29, 113);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Height";
      // 
      // btnSetSize
      // 
      this.btnSetSize.Location = new System.Drawing.Point(217, 137);
      this.btnSetSize.Name = "btnSetSize";
      this.btnSetSize.Size = new System.Drawing.Size(75, 23);
      this.btnSetSize.TabIndex = 5;
      this.btnSetSize.Text = "Set Size";
      this.btnSetSize.UseVisualStyleBackColor = true;
      this.btnSetSize.Click += new System.EventHandler(this.btnSetSize_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(304, 172);
      this.Controls.Add(this.btnSetSize);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.spinHeight);
      this.Controls.Add(this.spinWidth);
      this.Controls.Add(this.btnRightClick);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximumSize = new System.Drawing.Size(320, 210);
      this.Name = "Form1";
      this.Text = "Resize Images Settings";
      ((System.ComponentModel.ISupportInitialize)(this.spinWidth)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spinHeight)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnRightClick;
    private System.Windows.Forms.NumericUpDown spinWidth;
    private System.Windows.Forms.NumericUpDown spinHeight;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSetSize;
  }
}

