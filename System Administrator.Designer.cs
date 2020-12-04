
namespace MeetingScheduler
{
  partial class System_Administrator
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
      this.button1 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.backToMainMenuButton = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(453, 217);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(118, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Create Location";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(213, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(128, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "System Adminstrator View";
      // 
      // backToMainMenuButton
      // 
      this.backToMainMenuButton.Location = new System.Drawing.Point(12, 415);
      this.backToMainMenuButton.Name = "backToMainMenuButton";
      this.backToMainMenuButton.Size = new System.Drawing.Size(115, 23);
      this.backToMainMenuButton.TabIndex = 2;
      this.backToMainMenuButton.Text = "Back to Main Menu";
      this.backToMainMenuButton.UseVisualStyleBackColor = true;
      this.backToMainMenuButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(459, 123);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(346, 123);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Location Name";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(459, 172);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(346, 172);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(89, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Location Address";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(453, 339);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(112, 23);
      this.button3.TabIndex = 8;
      this.button3.Text = "Delete Location";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(346, 313);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "Location Name";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(459, 313);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 10;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(404, 80);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(104, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Add a New Location";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(417, 285);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(91, 13);
      this.label6.TabIndex = 12;
      this.label6.Text = "Delete a Location";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Items.AddRange(new object[] {
            "Location A",
            "Location B",
            "Location C"});
      this.listBox1.Location = new System.Drawing.Point(48, 62);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(251, 303);
      this.listBox1.TabIndex = 13;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // System_Administrator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 450);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.backToMainMenuButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "System_Administrator";
      this.Text = "Meeting Scheduler";
      this.Load += new System.EventHandler(this.System_Administrator_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button backToMainMenuButton;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox listBox1;
  }
}