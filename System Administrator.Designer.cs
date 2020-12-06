
using System.Collections.Generic;

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
      this.addNewLocationBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.backToMainMenuButton = new System.Windows.Forms.Button();
      this.addLocationNameTextbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.addLocationAddressTextbox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.deleteLocationBtn = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.locationListbox = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // addNewLocationBtn
      // 
      this.addNewLocationBtn.Location = new System.Drawing.Point(453, 217);
      this.addNewLocationBtn.Name = "addNewLocationBtn";
      this.addNewLocationBtn.Size = new System.Drawing.Size(118, 23);
      this.addNewLocationBtn.TabIndex = 0;
      this.addNewLocationBtn.Text = "Create Location";
      this.addNewLocationBtn.UseVisualStyleBackColor = true;
      this.addNewLocationBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(227, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(128, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "System Adminstrator View";
      this.label1.Click += new System.EventHandler(this.label1_Click);
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
      // addLocationNameTextbox
      // 
      this.addLocationNameTextbox.Location = new System.Drawing.Point(459, 123);
      this.addLocationNameTextbox.Name = "addLocationNameTextbox";
      this.addLocationNameTextbox.Size = new System.Drawing.Size(100, 20);
      this.addLocationNameTextbox.TabIndex = 3;
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
      // addLocationAddressTextbox
      // 
      this.addLocationAddressTextbox.Location = new System.Drawing.Point(459, 172);
      this.addLocationAddressTextbox.Name = "addLocationAddressTextbox";
      this.addLocationAddressTextbox.Size = new System.Drawing.Size(100, 20);
      this.addLocationAddressTextbox.TabIndex = 5;
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
      // deleteLocationBtn
      // 
      this.deleteLocationBtn.Location = new System.Drawing.Point(453, 339);
      this.deleteLocationBtn.Name = "deleteLocationBtn";
      this.deleteLocationBtn.Size = new System.Drawing.Size(112, 23);
      this.deleteLocationBtn.TabIndex = 8;
      this.deleteLocationBtn.Text = "Delete Location";
      this.deleteLocationBtn.UseVisualStyleBackColor = true;
      this.deleteLocationBtn.Click += new System.EventHandler(this.button3_Click);
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
      // locationListbox
      // 
      this.locationListbox.FormattingEnabled = true;
      this.locationListbox.Location = new System.Drawing.Point(48, 62);
      this.locationListbox.Name = "locationListbox";
      this.locationListbox.Size = new System.Drawing.Size(251, 303);
      this.locationListbox.TabIndex = 13;
      this.locationListbox.UseTabStops = false;
      this.locationListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // System_Administrator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(582, 450);
      this.Controls.Add(this.locationListbox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBox3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.deleteLocationBtn);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.addLocationAddressTextbox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.addLocationNameTextbox);
      this.Controls.Add(this.backToMainMenuButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.addNewLocationBtn);
      this.Name = "System_Administrator";
      this.Text = "Meeting Scheduler";
      this.Load += new System.EventHandler(this.System_Administrator_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button addNewLocationBtn;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button backToMainMenuButton;
    private System.Windows.Forms.TextBox addLocationNameTextbox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox addLocationAddressTextbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button deleteLocationBtn;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox locationListbox;
  }
}