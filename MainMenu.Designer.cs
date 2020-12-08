
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
      this.label1 = new System.Windows.Forms.Label();
      this.goToMeetingInitiatorView = new System.Windows.Forms.Button();
      this.goToSysAdminView = new System.Windows.Forms.Button();
      this.gotoEquipmentKeeperView = new System.Windows.Forms.Button();
      this.goToImportantParticipantView = new System.Windows.Forms.Button();
      this.goToParticipantView = new System.Windows.Forms.Button();
      this.exitProgramButton = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(14, 12);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(254, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "Please select which user you want to view";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // goToMeetingInitiatorView
      // 
      this.goToMeetingInitiatorView.BackColor = System.Drawing.SystemColors.MenuBar;
      this.goToMeetingInitiatorView.Location = new System.Drawing.Point(15, 40);
      this.goToMeetingInitiatorView.Name = "goToMeetingInitiatorView";
      this.goToMeetingInitiatorView.Size = new System.Drawing.Size(251, 30);
      this.goToMeetingInitiatorView.TabIndex = 1;
      this.goToMeetingInitiatorView.Text = "Meeting Initiator";
      this.goToMeetingInitiatorView.UseVisualStyleBackColor = false;
      this.goToMeetingInitiatorView.Click += new System.EventHandler(this.goToMeetingInitiatorView_Click);
      // 
      // goToSysAdminView
      // 
      this.goToSysAdminView.Location = new System.Drawing.Point(15, 184);
      this.goToSysAdminView.Name = "goToSysAdminView";
      this.goToSysAdminView.Size = new System.Drawing.Size(251, 30);
      this.goToSysAdminView.TabIndex = 2;
      this.goToSysAdminView.Text = "System Administrator";
      this.goToSysAdminView.UseVisualStyleBackColor = true;
      this.goToSysAdminView.Click += new System.EventHandler(this.button2_Click);
      // 
      // gotoEquipmentKeeperView
      // 
      this.gotoEquipmentKeeperView.BackColor = System.Drawing.SystemColors.MenuBar;
      this.gotoEquipmentKeeperView.Location = new System.Drawing.Point(15, 148);
      this.gotoEquipmentKeeperView.Name = "gotoEquipmentKeeperView";
      this.gotoEquipmentKeeperView.Size = new System.Drawing.Size(251, 30);
      this.gotoEquipmentKeeperView.TabIndex = 3;
      this.gotoEquipmentKeeperView.Text = "Equipment Keeper";
      this.gotoEquipmentKeeperView.UseVisualStyleBackColor = false;
      this.gotoEquipmentKeeperView.Click += new System.EventHandler(this.button3_Click);
      // 
      // goToImportantParticipantView
      // 
      this.goToImportantParticipantView.BackColor = System.Drawing.SystemColors.MenuBar;
      this.goToImportantParticipantView.Location = new System.Drawing.Point(15, 76);
      this.goToImportantParticipantView.Name = "goToImportantParticipantView";
      this.goToImportantParticipantView.Size = new System.Drawing.Size(251, 30);
      this.goToImportantParticipantView.TabIndex = 4;
      this.goToImportantParticipantView.Text = "Important Participant";
      this.goToImportantParticipantView.UseVisualStyleBackColor = false;
      this.goToImportantParticipantView.Click += new System.EventHandler(this.goToImportantParticipantView_Click);
      // 
      // goToParticipantView
      // 
      this.goToParticipantView.BackColor = System.Drawing.SystemColors.MenuBar;
      this.goToParticipantView.Location = new System.Drawing.Point(15, 112);
      this.goToParticipantView.Name = "goToParticipantView";
      this.goToParticipantView.Size = new System.Drawing.Size(251, 30);
      this.goToParticipantView.TabIndex = 5;
      this.goToParticipantView.Text = "Participant";
      this.goToParticipantView.UseVisualStyleBackColor = false;
      this.goToParticipantView.Click += new System.EventHandler(this.goToParticipantView_Click);
      // 
      // exitProgramButton
      // 
      this.exitProgramButton.Location = new System.Drawing.Point(12, 247);
      this.exitProgramButton.Name = "exitProgramButton";
      this.exitProgramButton.Size = new System.Drawing.Size(75, 23);
      this.exitProgramButton.TabIndex = 6;
      this.exitProgramButton.Text = "Exit";
      this.exitProgramButton.UseVisualStyleBackColor = true;
      this.exitProgramButton.Click += new System.EventHandler(this.button6_Click);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.goToSysAdminView);
      this.panel1.Controls.Add(this.goToMeetingInitiatorView);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.goToParticipantView);
      this.panel1.Controls.Add(this.gotoEquipmentKeeperView);
      this.panel1.Controls.Add(this.goToImportantParticipantView);
      this.panel1.Location = new System.Drawing.Point(12, 12);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(282, 229);
      this.panel1.TabIndex = 7;
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(308, 278);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.exitProgramButton);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainMenu";
      this.Text = "Meeting Scheduler";
      this.Load += new System.EventHandler(this.MainMenu_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button goToMeetingInitiatorView;
    private System.Windows.Forms.Button goToSysAdminView;
    private System.Windows.Forms.Button gotoEquipmentKeeperView;
    private System.Windows.Forms.Button goToImportantParticipantView;
    private System.Windows.Forms.Button goToParticipantView;
    private System.Windows.Forms.Button exitProgramButton;
    private System.Windows.Forms.Panel panel1;
  }
}

