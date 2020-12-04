
namespace MeetingScheduler
{
  partial class Equipment_Keeper
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
      this.equipmentList = new System.Windows.Forms.ListBox();
      this.addEquipmentLabel = new System.Windows.Forms.Label();
      this.selectLocationNameLabel = new System.Windows.Forms.Label();
      this.addEquipmentNameLabel = new System.Windows.Forms.Label();
      this.addEquipmentNameTextbox = new System.Windows.Forms.TextBox();
      this.backToMainMenuButton = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.selectLocationBox = new System.Windows.Forms.ComboBox();
      this.addEquipmentLocationDropdown = new System.Windows.Forms.ComboBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.comboBox3 = new System.Windows.Forms.ComboBox();
      this.comboBox4 = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.comboBox5 = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // equipmentList
      // 
      this.equipmentList.FormattingEnabled = true;
      this.equipmentList.Items.AddRange(new object[] {
            "Projector",
            "Laptops",
            "Whiteboard"});
      this.equipmentList.Location = new System.Drawing.Point(35, 77);
      this.equipmentList.Name = "equipmentList";
      this.equipmentList.Size = new System.Drawing.Size(251, 329);
      this.equipmentList.TabIndex = 26;
      this.equipmentList.SelectedIndexChanged += new System.EventHandler(this.equipmentList_SelectedIndexChanged);
      // 
      // addEquipmentLabel
      // 
      this.addEquipmentLabel.AutoSize = true;
      this.addEquipmentLabel.Location = new System.Drawing.Point(388, 51);
      this.addEquipmentLabel.Name = "addEquipmentLabel";
      this.addEquipmentLabel.Size = new System.Drawing.Size(101, 13);
      this.addEquipmentLabel.TabIndex = 24;
      this.addEquipmentLabel.Text = "Add new equipment";
      // 
      // selectLocationNameLabel
      // 
      this.selectLocationNameLabel.AutoSize = true;
      this.selectLocationNameLabel.Location = new System.Drawing.Point(325, 106);
      this.selectLocationNameLabel.Name = "selectLocationNameLabel";
      this.selectLocationNameLabel.Size = new System.Drawing.Size(81, 13);
      this.selectLocationNameLabel.TabIndex = 20;
      this.selectLocationNameLabel.Text = "Select Location";
      // 
      // addEquipmentNameLabel
      // 
      this.addEquipmentNameLabel.AutoSize = true;
      this.addEquipmentNameLabel.Location = new System.Drawing.Point(325, 77);
      this.addEquipmentNameLabel.Name = "addEquipmentNameLabel";
      this.addEquipmentNameLabel.Size = new System.Drawing.Size(88, 13);
      this.addEquipmentNameLabel.TabIndex = 18;
      this.addEquipmentNameLabel.Text = "Equipment Name";
      // 
      // addEquipmentNameTextbox
      // 
      this.addEquipmentNameTextbox.Location = new System.Drawing.Point(438, 77);
      this.addEquipmentNameTextbox.Name = "addEquipmentNameTextbox";
      this.addEquipmentNameTextbox.Size = new System.Drawing.Size(100, 20);
      this.addEquipmentNameTextbox.TabIndex = 17;
      // 
      // backToMainMenuButton
      // 
      this.backToMainMenuButton.Location = new System.Drawing.Point(14, 506);
      this.backToMainMenuButton.Name = "backToMainMenuButton";
      this.backToMainMenuButton.Size = new System.Drawing.Size(115, 23);
      this.backToMainMenuButton.TabIndex = 16;
      this.backToMainMenuButton.Text = "Back to Main Menu";
      this.backToMainMenuButton.UseVisualStyleBackColor = true;
      this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click_1);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(225, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 13);
      this.label1.TabIndex = 15;
      this.label1.Text = "Equipment Keeper View";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(420, 153);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(118, 23);
      this.button1.TabIndex = 14;
      this.button1.Text = "Add equipment";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // selectLocationBox
      // 
      this.selectLocationBox.FormattingEnabled = true;
      this.selectLocationBox.Items.AddRange(new object[] {
            "Location A",
            "Location B",
            "Location C"});
      this.selectLocationBox.Location = new System.Drawing.Point(35, 50);
      this.selectLocationBox.Name = "selectLocationBox";
      this.selectLocationBox.Size = new System.Drawing.Size(251, 21);
      this.selectLocationBox.TabIndex = 27;
      // 
      // addEquipmentLocationDropdown
      // 
      this.addEquipmentLocationDropdown.FormattingEnabled = true;
      this.addEquipmentLocationDropdown.Location = new System.Drawing.Point(438, 103);
      this.addEquipmentLocationDropdown.Name = "addEquipmentLocationDropdown";
      this.addEquipmentLocationDropdown.Size = new System.Drawing.Size(100, 21);
      this.addEquipmentLocationDropdown.TabIndex = 28;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(438, 250);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(100, 21);
      this.comboBox1.TabIndex = 34;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(388, 198);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 13);
      this.label2.TabIndex = 33;
      this.label2.Text = "Remove equipment";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(325, 253);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(90, 13);
      this.label3.TabIndex = 32;
      this.label3.Text = "Select Equipment";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(325, 224);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(81, 13);
      this.label4.TabIndex = 31;
      this.label4.Text = "Select Location";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(420, 286);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(118, 23);
      this.button2.TabIndex = 29;
      this.button2.Text = "Remove equipment";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Location = new System.Drawing.Point(438, 223);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(100, 21);
      this.comboBox2.TabIndex = 35;
      // 
      // comboBox3
      // 
      this.comboBox3.FormattingEnabled = true;
      this.comboBox3.Location = new System.Drawing.Point(438, 362);
      this.comboBox3.Name = "comboBox3";
      this.comboBox3.Size = new System.Drawing.Size(100, 21);
      this.comboBox3.TabIndex = 41;
      // 
      // comboBox4
      // 
      this.comboBox4.FormattingEnabled = true;
      this.comboBox4.Location = new System.Drawing.Point(438, 389);
      this.comboBox4.Name = "comboBox4";
      this.comboBox4.Size = new System.Drawing.Size(100, 21);
      this.comboBox4.TabIndex = 40;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(388, 337);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(86, 13);
      this.label5.TabIndex = 39;
      this.label5.Text = "Move equipment";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(325, 392);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(90, 13);
      this.label6.TabIndex = 38;
      this.label6.Text = "Select Equipment";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(325, 363);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(81, 13);
      this.label7.TabIndex = 37;
      this.label7.Text = "Select Location";
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(391, 443);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(147, 23);
      this.button3.TabIndex = 36;
      this.button3.Text = "Change equipment location";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // comboBox5
      // 
      this.comboBox5.FormattingEnabled = true;
      this.comboBox5.Location = new System.Drawing.Point(438, 416);
      this.comboBox5.Name = "comboBox5";
      this.comboBox5.Size = new System.Drawing.Size(100, 21);
      this.comboBox5.TabIndex = 43;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(325, 419);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(100, 13);
      this.label8.TabIndex = 42;
      this.label8.Text = "Select new location";
      // 
      // button4
      // 
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.ForeColor = System.Drawing.Color.Red;
      this.button4.Location = new System.Drawing.Point(330, 485);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(210, 44);
      this.button4.TabIndex = 44;
      this.button4.Text = "Show Equipment Conflicts";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.checkBox1.Checked = true;
      this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
      this.checkBox1.Location = new System.Drawing.Point(473, 130);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(65, 17);
      this.checkBox1.TabIndex = 45;
      this.checkBox1.Text = "Portable";
      this.checkBox1.UseVisualStyleBackColor = true;
      // 
      // Equipment_Keeper
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(552, 550);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.comboBox5);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.comboBox3);
      this.Controls.Add(this.comboBox4);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.addEquipmentLocationDropdown);
      this.Controls.Add(this.selectLocationBox);
      this.Controls.Add(this.equipmentList);
      this.Controls.Add(this.addEquipmentLabel);
      this.Controls.Add(this.selectLocationNameLabel);
      this.Controls.Add(this.addEquipmentNameLabel);
      this.Controls.Add(this.addEquipmentNameTextbox);
      this.Controls.Add(this.backToMainMenuButton);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.button1);
      this.Name = "Equipment_Keeper";
      this.Text = "Meeting Scheduler - Equipment Keeper View";
      this.Load += new System.EventHandler(this.Equipment_Keeper_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox equipmentList;
    private System.Windows.Forms.Label addEquipmentLabel;
    private System.Windows.Forms.Label selectLocationNameLabel;
    private System.Windows.Forms.Label addEquipmentNameLabel;
    private System.Windows.Forms.TextBox addEquipmentNameTextbox;
    private System.Windows.Forms.Button backToMainMenuButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ComboBox selectLocationBox;
    private System.Windows.Forms.ComboBox addEquipmentLocationDropdown;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.ComboBox comboBox3;
    private System.Windows.Forms.ComboBox comboBox4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.ComboBox comboBox5;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.CheckBox checkBox1;
  }
}