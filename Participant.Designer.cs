
namespace MeetingScheduler
{
  partial class Participant
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Participant));
      this.panel2 = new System.Windows.Forms.Panel();
      this.currentMeetingBackOutOfMeetingBtn = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.currentMeetingEquipmentListbox = new System.Windows.Forms.ListBox();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.currentMeetingRequestEquipmentBtn = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.currentMeetingParticipantListbox = new System.Windows.Forms.ListBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.selectMeetingDropdown = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.backToMainMenuButton = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label5 = new System.Windows.Forms.Label();
      this.importantParticipantSuggestedMeetingLocationsListbox = new System.Windows.Forms.ListBox();
      this.importantParticipantSelectNewLocationToSuggestDropdown = new System.Windows.Forms.ComboBox();
      this.importantParticipantAddSuggestedLocationBtn = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.currentMeetingSuggestEquipmentDropdown = new System.Windows.Forms.ComboBox();
      this.selectUserDropdown = new System.Windows.Forms.ComboBox();
      this.label10 = new System.Windows.Forms.Label();
      this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
      this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
      this.label11 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label13 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel2.Controls.Add(this.label9);
      this.panel2.Controls.Add(this.currentMeetingBackOutOfMeetingBtn);
      this.panel2.Controls.Add(this.currentMeetingSuggestEquipmentDropdown);
      this.panel2.Controls.Add(this.checkBox1);
      this.panel2.Controls.Add(this.label4);
      this.panel2.Controls.Add(this.currentMeetingEquipmentListbox);
      this.panel2.Controls.Add(this.textBox3);
      this.panel2.Controls.Add(this.textBox2);
      this.panel2.Controls.Add(this.currentMeetingRequestEquipmentBtn);
      this.panel2.Controls.Add(this.label6);
      this.panel2.Controls.Add(this.currentMeetingParticipantListbox);
      this.panel2.Controls.Add(this.label3);
      this.panel2.Controls.Add(this.label7);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Controls.Add(this.selectMeetingDropdown);
      this.panel2.Location = new System.Drawing.Point(12, 104);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(407, 239);
      this.panel2.TabIndex = 85;
      this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
      // 
      // currentMeetingBackOutOfMeetingBtn
      // 
      this.currentMeetingBackOutOfMeetingBtn.Location = new System.Drawing.Point(15, 185);
      this.currentMeetingBackOutOfMeetingBtn.Name = "currentMeetingBackOutOfMeetingBtn";
      this.currentMeetingBackOutOfMeetingBtn.Size = new System.Drawing.Size(115, 41);
      this.currentMeetingBackOutOfMeetingBtn.TabIndex = 97;
      this.currentMeetingBackOutOfMeetingBtn.Text = "Back out of meeting";
      this.currentMeetingBackOutOfMeetingBtn.UseVisualStyleBackColor = true;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.checkBox1.Location = new System.Drawing.Point(40, 115);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(125, 18);
      this.checkBox1.TabIndex = 96;
      this.checkBox1.Text = "Confirm Attendance";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(299, 42);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(76, 13);
      this.label4.TabIndex = 95;
      this.label4.Text = "Equipment List";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // currentMeetingEquipmentListbox
      // 
      this.currentMeetingEquipmentListbox.FormattingEnabled = true;
      this.currentMeetingEquipmentListbox.Items.AddRange(new object[] {
            "Laptops"});
      this.currentMeetingEquipmentListbox.Location = new System.Drawing.Point(287, 58);
      this.currentMeetingEquipmentListbox.Name = "currentMeetingEquipmentListbox";
      this.currentMeetingEquipmentListbox.Size = new System.Drawing.Size(100, 121);
      this.currentMeetingEquipmentListbox.TabIndex = 94;
      this.currentMeetingEquipmentListbox.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(75, 84);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(100, 20);
      this.textBox3.TabIndex = 93;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(75, 58);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(100, 20);
      this.textBox2.TabIndex = 92;
      // 
      // currentMeetingRequestEquipmentBtn
      // 
      this.currentMeetingRequestEquipmentBtn.Location = new System.Drawing.Point(287, 185);
      this.currentMeetingRequestEquipmentBtn.Name = "currentMeetingRequestEquipmentBtn";
      this.currentMeetingRequestEquipmentBtn.Size = new System.Drawing.Size(100, 41);
      this.currentMeetingRequestEquipmentBtn.TabIndex = 88;
      this.currentMeetingRequestEquipmentBtn.Text = "Request Equipment";
      this.currentMeetingRequestEquipmentBtn.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(194, 40);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(76, 13);
      this.label6.TabIndex = 87;
      this.label6.Text = "Participant List";
      // 
      // currentMeetingParticipantListbox
      // 
      this.currentMeetingParticipantListbox.FormattingEnabled = true;
      this.currentMeetingParticipantListbox.Items.AddRange(new object[] {
            "Tom",
            "Dick",
            "Harry",
            "James",
            "Julia",
            "Adam",
            "Mazen",
            "Maxwel"});
      this.currentMeetingParticipantListbox.Location = new System.Drawing.Point(181, 58);
      this.currentMeetingParticipantListbox.Name = "currentMeetingParticipantListbox";
      this.currentMeetingParticipantListbox.Size = new System.Drawing.Size(100, 121);
      this.currentMeetingParticipantListbox.TabIndex = 86;
      this.currentMeetingParticipantListbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(19, 62);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(48, 13);
      this.label3.TabIndex = 85;
      this.label3.Text = "Location";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(18, 89);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(51, 13);
      this.label7.TabIndex = 82;
      this.label7.Text = "Time Slot";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Select meeting to view";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // selectMeetingDropdown
      // 
      this.selectMeetingDropdown.FormattingEnabled = true;
      this.selectMeetingDropdown.Location = new System.Drawing.Point(136, 9);
      this.selectMeetingDropdown.Name = "selectMeetingDropdown";
      this.selectMeetingDropdown.Size = new System.Drawing.Size(251, 21);
      this.selectMeetingDropdown.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(282, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(266, 39);
      this.label1.TabIndex = 84;
      this.label1.Text = "Participant View";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // backToMainMenuButton
      // 
      this.backToMainMenuButton.Location = new System.Drawing.Point(12, 349);
      this.backToMainMenuButton.Name = "backToMainMenuButton";
      this.backToMainMenuButton.Size = new System.Drawing.Size(115, 23);
      this.backToMainMenuButton.TabIndex = 86;
      this.backToMainMenuButton.Text = "Back to Main Menu";
      this.backToMainMenuButton.UseVisualStyleBackColor = true;
      this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.importantParticipantAddSuggestedLocationBtn);
      this.groupBox1.Controls.Add(this.importantParticipantSelectNewLocationToSuggestDropdown);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.importantParticipantSuggestedMeetingLocationsListbox);
      this.groupBox1.Location = new System.Drawing.Point(430, 104);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(169, 238);
      this.groupBox1.TabIndex = 87;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Important Participant Controls";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(11, 26);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(107, 13);
      this.label5.TabIndex = 99;
      this.label5.Text = "Suggested Locations";
      // 
      // importantParticipantSuggestedMeetingLocationsListbox
      // 
      this.importantParticipantSuggestedMeetingLocationsListbox.FormattingEnabled = true;
      this.importantParticipantSuggestedMeetingLocationsListbox.Items.AddRange(new object[] {
            "Laptops"});
      this.importantParticipantSuggestedMeetingLocationsListbox.Location = new System.Drawing.Point(11, 42);
      this.importantParticipantSuggestedMeetingLocationsListbox.Name = "importantParticipantSuggestedMeetingLocationsListbox";
      this.importantParticipantSuggestedMeetingLocationsListbox.Size = new System.Drawing.Size(147, 108);
      this.importantParticipantSuggestedMeetingLocationsListbox.TabIndex = 98;
      // 
      // importantParticipantSelectNewLocationToSuggestDropdown
      // 
      this.importantParticipantSelectNewLocationToSuggestDropdown.FormattingEnabled = true;
      this.importantParticipantSelectNewLocationToSuggestDropdown.Location = new System.Drawing.Point(12, 176);
      this.importantParticipantSelectNewLocationToSuggestDropdown.Name = "importantParticipantSelectNewLocationToSuggestDropdown";
      this.importantParticipantSelectNewLocationToSuggestDropdown.Size = new System.Drawing.Size(142, 21);
      this.importantParticipantSelectNewLocationToSuggestDropdown.TabIndex = 100;
      // 
      // importantParticipantAddSuggestedLocationBtn
      // 
      this.importantParticipantAddSuggestedLocationBtn.Location = new System.Drawing.Point(11, 198);
      this.importantParticipantAddSuggestedLocationBtn.Name = "importantParticipantAddSuggestedLocationBtn";
      this.importantParticipantAddSuggestedLocationBtn.Size = new System.Drawing.Size(143, 28);
      this.importantParticipantAddSuggestedLocationBtn.TabIndex = 101;
      this.importantParticipantAddSuggestedLocationBtn.Text = "Suggest Location";
      this.importantParticipantAddSuggestedLocationBtn.UseVisualStyleBackColor = true;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(8, 160);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(152, 13);
      this.label8.TabIndex = 102;
      this.label8.Text = "Select new location to suggest";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(139, 189);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(142, 13);
      this.label9.TabIndex = 104;
      this.label9.Text = "Select Equipment to suggest";
      // 
      // currentMeetingSuggestEquipmentDropdown
      // 
      this.currentMeetingSuggestEquipmentDropdown.FormattingEnabled = true;
      this.currentMeetingSuggestEquipmentDropdown.Location = new System.Drawing.Point(139, 205);
      this.currentMeetingSuggestEquipmentDropdown.Name = "currentMeetingSuggestEquipmentDropdown";
      this.currentMeetingSuggestEquipmentDropdown.Size = new System.Drawing.Size(142, 21);
      this.currentMeetingSuggestEquipmentDropdown.TabIndex = 103;
      // 
      // selectUserDropdown
      // 
      this.selectUserDropdown.FormattingEnabled = true;
      this.selectUserDropdown.Location = new System.Drawing.Point(12, 20);
      this.selectUserDropdown.Name = "selectUserDropdown";
      this.selectUserDropdown.Size = new System.Drawing.Size(260, 21);
      this.selectUserDropdown.TabIndex = 88;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(9, 4);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(263, 13);
      this.label10.TabIndex = 89;
      this.label10.Text = "Select which participant you wish to use the system as";
      // 
      // checkedListBox1
      // 
      this.checkedListBox1.FormattingEnabled = true;
      this.checkedListBox1.Items.AddRange(new object[] {
            "Slot 1",
            "Slot 2",
            "Slot 3",
            "Slot 4",
            "Slot 5",
            "Slot 6"});
      this.checkedListBox1.Location = new System.Drawing.Point(36, 57);
      this.checkedListBox1.Name = "checkedListBox1";
      this.checkedListBox1.Size = new System.Drawing.Size(57, 94);
      this.checkedListBox1.TabIndex = 90;
      // 
      // checkedListBox2
      // 
      this.checkedListBox2.FormattingEnabled = true;
      this.checkedListBox2.Items.AddRange(new object[] {
            "Slot 1",
            "Slot 2",
            "Slot 3",
            "Slot 4",
            "Slot 5",
            "Slot 6"});
      this.checkedListBox2.Location = new System.Drawing.Point(111, 57);
      this.checkedListBox2.Name = "checkedListBox2";
      this.checkedListBox2.Size = new System.Drawing.Size(56, 94);
      this.checkedListBox2.TabIndex = 91;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(24, 41);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(78, 13);
      this.label11.TabIndex = 92;
      this.label11.Text = "Preference Set";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Location = new System.Drawing.Point(108, 41);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(71, 13);
      this.label12.TabIndex = 93;
      this.label12.Text = "Exclusion Set";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.button1);
      this.panel1.Controls.Add(this.label13);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Controls.Add(this.checkedListBox2);
      this.panel1.Controls.Add(this.checkedListBox1);
      this.panel1.Location = new System.Drawing.Point(605, 104);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(203, 238);
      this.panel1.TabIndex = 94;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(9, 4);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(186, 13);
      this.label13.TabIndex = 100;
      this.label13.Text = "Edit your preference and exlusion sets";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(27, 170);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(152, 50);
      this.button1.TabIndex = 102;
      this.button1.Text = "Update preference and exclusion sets";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // Participant
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(821, 381);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.selectUserDropdown);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.backToMainMenuButton);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Participant";
      this.Text = "Meeting Scheduler - Participant View";
      this.Load += new System.EventHandler(this.Participant_Load);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox selectMeetingDropdown;
    private System.Windows.Forms.Button backToMainMenuButton;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Button currentMeetingRequestEquipmentBtn;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox currentMeetingParticipantListbox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListBox currentMeetingEquipmentListbox;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button currentMeetingBackOutOfMeetingBtn;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ListBox importantParticipantSuggestedMeetingLocationsListbox;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox currentMeetingSuggestEquipmentDropdown;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button importantParticipantAddSuggestedLocationBtn;
    private System.Windows.Forms.ComboBox importantParticipantSelectNewLocationToSuggestDropdown;
    private System.Windows.Forms.ComboBox selectUserDropdown;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.CheckedListBox checkedListBox1;
    private System.Windows.Forms.CheckedListBox checkedListBox2;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label13;
  }
}