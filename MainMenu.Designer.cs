
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
      this.goToMeetingInitiatorView = new System.Windows.Forms.Button();
      this.goToSysAdminView = new System.Windows.Forms.Button();
      this.gotoEquipmentKeeperView = new System.Windows.Forms.Button();
      this.goToImportantParticipantView = new System.Windows.Forms.Button();
      this.goToParticipantView = new System.Windows.Forms.Button();
      this.exitProgramButton = new System.Windows.Forms.Button();
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
      // goToMeetingInitiatorView
      // 
      this.goToMeetingInitiatorView.Location = new System.Drawing.Point(20, 56);
      this.goToMeetingInitiatorView.Name = "goToMeetingInitiatorView";
      this.goToMeetingInitiatorView.Size = new System.Drawing.Size(143, 29);
      this.goToMeetingInitiatorView.TabIndex = 1;
      this.goToMeetingInitiatorView.Text = "Meeting Initiator";
      this.goToMeetingInitiatorView.UseVisualStyleBackColor = true;
      this.goToMeetingInitiatorView.Click += new System.EventHandler(this.goToMeetingInitiatorView_Click);
      // 
      // goToSysAdminView
      // 
      this.goToSysAdminView.Location = new System.Drawing.Point(229, 58);
      this.goToSysAdminView.Name = "goToSysAdminView";
      this.goToSysAdminView.Size = new System.Drawing.Size(149, 24);
      this.goToSysAdminView.TabIndex = 2;
      this.goToSysAdminView.Text = "System Administrator";
      this.goToSysAdminView.UseVisualStyleBackColor = true;
      this.goToSysAdminView.Click += new System.EventHandler(this.button2_Click);
      // 
      // gotoEquipmentKeeperView
      // 
      this.gotoEquipmentKeeperView.Location = new System.Drawing.Point(436, 58);
      this.gotoEquipmentKeeperView.Name = "gotoEquipmentKeeperView";
      this.gotoEquipmentKeeperView.Size = new System.Drawing.Size(149, 23);
      this.gotoEquipmentKeeperView.TabIndex = 3;
      this.gotoEquipmentKeeperView.Text = "Equipment Keeper";
      this.gotoEquipmentKeeperView.UseVisualStyleBackColor = true;
      this.gotoEquipmentKeeperView.Click += new System.EventHandler(this.button3_Click);
      // 
      // goToImportantParticipantView
      // 
      this.goToImportantParticipantView.Location = new System.Drawing.Point(129, 103);
      this.goToImportantParticipantView.Name = "goToImportantParticipantView";
      this.goToImportantParticipantView.Size = new System.Drawing.Size(120, 23);
      this.goToImportantParticipantView.TabIndex = 4;
      this.goToImportantParticipantView.Text = "Important Participant";
      this.goToImportantParticipantView.UseVisualStyleBackColor = true;
      this.goToImportantParticipantView.Click += new System.EventHandler(this.goToImportantParticipantView_Click);
      // 
      // goToParticipantView
      // 
      this.goToParticipantView.Location = new System.Drawing.Point(367, 103);
      this.goToParticipantView.Name = "goToParticipantView";
      this.goToParticipantView.Size = new System.Drawing.Size(75, 23);
      this.goToParticipantView.TabIndex = 5;
      this.goToParticipantView.Text = "Participant";
      this.goToParticipantView.UseVisualStyleBackColor = true;
      this.goToParticipantView.Click += new System.EventHandler(this.goToParticipantView_Click);
      // 
      // exitProgramButton
      // 
      this.exitProgramButton.Location = new System.Drawing.Point(13, 152);
      this.exitProgramButton.Name = "exitProgramButton";
      this.exitProgramButton.Size = new System.Drawing.Size(75, 23);
      this.exitProgramButton.TabIndex = 6;
      this.exitProgramButton.Text = "Exit";
      this.exitProgramButton.UseVisualStyleBackColor = true;
      this.exitProgramButton.Click += new System.EventHandler(this.button6_Click);
      // 
      // MainMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(605, 187);
      this.Controls.Add(this.exitProgramButton);
      this.Controls.Add(this.goToParticipantView);
      this.Controls.Add(this.goToImportantParticipantView);
      this.Controls.Add(this.gotoEquipmentKeeperView);
      this.Controls.Add(this.goToSysAdminView);
      this.Controls.Add(this.goToMeetingInitiatorView);
      this.Controls.Add(this.label1);
      this.Name = "MainMenu";
      this.Text = "Meeting Scheduler";
      this.Load += new System.EventHandler(this.MainMenu_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button goToMeetingInitiatorView;
    private System.Windows.Forms.Button goToSysAdminView;
    private System.Windows.Forms.Button gotoEquipmentKeeperView;
    private System.Windows.Forms.Button goToImportantParticipantView;
    private System.Windows.Forms.Button goToParticipantView;
    private System.Windows.Forms.Button exitProgramButton;
  }
}

