
namespace MeetingScheduler
{
  partial class MainMenu
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
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(284, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Main Menu";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(20, 56);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(143, 29);
      this.button1.TabIndex = 1;
      this.button1.Text = "Meeting Initiator";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(229, 58);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(149, 24);
      this.button2.TabIndex = 2;
      this.button2.Text = "System Administrator";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(436, 58);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(149, 23);
      this.button3.TabIndex = 3;
      this.button3.Text = "Equipment Keeper";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(129, 103);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(120, 23);
      this.button4.TabIndex = 4;
      this.button4.Text = "Important Participant";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(367, 103);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(75, 23);
      this.button5.TabIndex = 5;
      this.button5.Text = "Participant";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // button6
      // 
      this.button6.Location = new System.Drawing.Point(13, 152);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(75, 23);
      this.button6.TabIndex = 6;
      this.button6.Text = "Exit";
      this.button6.UseVisualStyleBackColor = true;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(605, 187);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Name = "MainMenu";
      this.Text = "Meeting Scheduler";
      this.Load += new System.EventHandler(this.MainMenu_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
  }
}

