
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_Administrator));
      this.addNewLocationBtn = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.backToMainMenuButton = new System.Windows.Forms.Button();
      this.addLocationNameTextbox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.deleteLocationBtn = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.locationListbox = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // addNewLocationBtn
      // 
      this.addNewLocationBtn.Location = new System.Drawing.Point(264, 63);
      this.addNewLocationBtn.Name = "addNewLocationBtn";
      this.addNewLocationBtn.Size = new System.Drawing.Size(118, 23);
      this.addNewLocationBtn.TabIndex = 0;
      this.addNewLocationBtn.Text = "Add Location";
      this.addNewLocationBtn.UseVisualStyleBackColor = true;
      this.addNewLocationBtn.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(28, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(382, 33);
      this.label1.TabIndex = 1;
      this.label1.Text = "System Adminstrator View";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // backToMainMenuButton
      // 
      this.backToMainMenuButton.Location = new System.Drawing.Point(20, 410);
      this.backToMainMenuButton.Name = "backToMainMenuButton";
      this.backToMainMenuButton.Size = new System.Drawing.Size(115, 23);
      this.backToMainMenuButton.TabIndex = 2;
      this.backToMainMenuButton.Text = "Back to Main Menu";
      this.backToMainMenuButton.UseVisualStyleBackColor = true;
      this.backToMainMenuButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // addLocationNameTextbox
      // 
      this.addLocationNameTextbox.Location = new System.Drawing.Point(264, 39);
      this.addLocationNameTextbox.Name = "addLocationNameTextbox";
      this.addLocationNameTextbox.Size = new System.Drawing.Size(118, 20);
      this.addLocationNameTextbox.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(261, 23);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Location Name";
      // 
      // deleteLocationBtn
      // 
      this.deleteLocationBtn.Location = new System.Drawing.Point(146, 329);
      this.deleteLocationBtn.Name = "deleteLocationBtn";
      this.deleteLocationBtn.Size = new System.Drawing.Size(112, 23);
      this.deleteLocationBtn.TabIndex = 8;
      this.deleteLocationBtn.Text = "Delete Location";
      this.deleteLocationBtn.UseVisualStyleBackColor = true;
      this.deleteLocationBtn.Click += new System.EventHandler(this.button3_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(260, 7);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(122, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Add a New Location";
      // 
      // locationListbox
      // 
      this.locationListbox.FormattingEnabled = true;
      this.locationListbox.Location = new System.Drawing.Point(7, 22);
      this.locationListbox.Name = "locationListbox";
      this.locationListbox.Size = new System.Drawing.Size(251, 303);
      this.locationListbox.TabIndex = 13;
      this.locationListbox.UseTabStops = false;
      this.locationListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.locationListbox);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Controls.Add(this.deleteLocationBtn);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.addLocationNameTextbox);
      this.panel1.Controls.Add(this.addNewLocationBtn);
      this.panel1.Location = new System.Drawing.Point(20, 52);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(391, 356);
      this.panel1.TabIndex = 14;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(5, 6);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(155, 13);
      this.label4.TabIndex = 14;
      this.label4.Text = "List of availiable locations";
      // 
      // System_Administrator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(420, 447);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.backToMainMenuButton);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "System_Administrator";
      this.Text = "Meeting Scheduler";
      this.Load += new System.EventHandler(this.System_Administrator_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button addNewLocationBtn;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button backToMainMenuButton;
    private System.Windows.Forms.TextBox addLocationNameTextbox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button deleteLocationBtn;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListBox locationListbox;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label4;
  }
}