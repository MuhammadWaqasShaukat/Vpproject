namespace Data_Structure_Simulator
{
    partial class Settings
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
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxShapeWidth = new System.Windows.Forms.ComboBox();
            this.comboBoxShapeHeight = new System.Windows.Forms.ComboBox();
            this.labelShapeHeight = new System.Windows.Forms.Label();
            this.labelShapeWidth = new System.Windows.Forms.Label();
            this.labelShapeColor = new System.Windows.Forms.Label();
            this.comboBoxShapeColor = new System.Windows.Forms.ComboBox();
            this.buttonSettingOk = new System.Windows.Forms.Button();
            this.buttonSettingCancel = new System.Windows.Forms.Button();
            this.groupBoxSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSetting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxSetting.Controls.Add(this.comboBoxShapeWidth);
            this.groupBoxSetting.Controls.Add(this.comboBoxShapeHeight);
            this.groupBoxSetting.Controls.Add(this.labelShapeHeight);
            this.groupBoxSetting.Controls.Add(this.labelShapeWidth);
            this.groupBoxSetting.Controls.Add(this.labelShapeColor);
            this.groupBoxSetting.Controls.Add(this.comboBoxShapeColor);
            this.groupBoxSetting.Location = new System.Drawing.Point(21, 23);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(206, 101);
            this.groupBoxSetting.TabIndex = 10;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "Settings";
            this.groupBoxSetting.Enter += new System.EventHandler(this.groupBoxSetting_Enter);
            // 
            // comboBoxShapeWidth
            // 
            this.comboBoxShapeWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapeWidth.FormattingEnabled = true;
            this.comboBoxShapeWidth.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.comboBoxShapeWidth.Location = new System.Drawing.Point(82, 43);
            this.comboBoxShapeWidth.Name = "comboBoxShapeWidth";
            this.comboBoxShapeWidth.Size = new System.Drawing.Size(92, 21);
            this.comboBoxShapeWidth.TabIndex = 7;
            // 
            // comboBoxShapeHeight
            // 
            this.comboBoxShapeHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapeHeight.FormattingEnabled = true;
            this.comboBoxShapeHeight.Items.AddRange(new object[] {
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100"});
            this.comboBoxShapeHeight.Location = new System.Drawing.Point(82, 67);
            this.comboBoxShapeHeight.Name = "comboBoxShapeHeight";
            this.comboBoxShapeHeight.Size = new System.Drawing.Size(92, 21);
            this.comboBoxShapeHeight.TabIndex = 8;
            // 
            // labelShapeHeight
            // 
            this.labelShapeHeight.AutoSize = true;
            this.labelShapeHeight.Location = new System.Drawing.Point(7, 75);
            this.labelShapeHeight.Name = "labelShapeHeight";
            this.labelShapeHeight.Size = new System.Drawing.Size(72, 13);
            this.labelShapeHeight.TabIndex = 4;
            this.labelShapeHeight.Text = "Shape Height";
            // 
            // labelShapeWidth
            // 
            this.labelShapeWidth.AutoSize = true;
            this.labelShapeWidth.Location = new System.Drawing.Point(7, 51);
            this.labelShapeWidth.Name = "labelShapeWidth";
            this.labelShapeWidth.Size = new System.Drawing.Size(69, 13);
            this.labelShapeWidth.TabIndex = 5;
            this.labelShapeWidth.Text = "Shape Width";
            // 
            // labelShapeColor
            // 
            this.labelShapeColor.AutoSize = true;
            this.labelShapeColor.Location = new System.Drawing.Point(7, 26);
            this.labelShapeColor.Name = "labelShapeColor";
            this.labelShapeColor.Size = new System.Drawing.Size(65, 13);
            this.labelShapeColor.TabIndex = 1;
            this.labelShapeColor.Text = "Shape Color";
            // 
            // comboBoxShapeColor
            // 
            this.comboBoxShapeColor.AllowDrop = true;
            this.comboBoxShapeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShapeColor.FormattingEnabled = true;
            this.comboBoxShapeColor.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Green",
            "Red"});
            this.comboBoxShapeColor.Location = new System.Drawing.Point(82, 20);
            this.comboBoxShapeColor.Name = "comboBoxShapeColor";
            this.comboBoxShapeColor.Size = new System.Drawing.Size(92, 21);
            this.comboBoxShapeColor.Sorted = true;
            this.comboBoxShapeColor.TabIndex = 6;
            // 
            // buttonSettingOk
            // 
            this.buttonSettingOk.Location = new System.Drawing.Point(74, 130);
            this.buttonSettingOk.Name = "buttonSettingOk";
            this.buttonSettingOk.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingOk.TabIndex = 11;
            this.buttonSettingOk.Text = "Ok";
            this.buttonSettingOk.UseVisualStyleBackColor = true;
            // 
            // buttonSettingCancel
            // 
            this.buttonSettingCancel.Location = new System.Drawing.Point(155, 130);
            this.buttonSettingCancel.Name = "buttonSettingCancel";
            this.buttonSettingCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonSettingCancel.TabIndex = 12;
            this.buttonSettingCancel.Text = "Cancel";
            this.buttonSettingCancel.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(264, 156);
            this.Controls.Add(this.buttonSettingCancel);
            this.Controls.Add(this.buttonSettingOk);
            this.Controls.Add(this.groupBoxSetting);
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.groupBoxSetting.ResumeLayout(false);
            this.groupBoxSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSetting;
        private System.Windows.Forms.ComboBox comboBoxShapeWidth;
        private System.Windows.Forms.ComboBox comboBoxShapeHeight;
        private System.Windows.Forms.Label labelShapeHeight;
        private System.Windows.Forms.Label labelShapeWidth;
        private System.Windows.Forms.Label labelShapeColor;
        private System.Windows.Forms.ComboBox comboBoxShapeColor;
        private System.Windows.Forms.Button buttonSettingOk;
        private System.Windows.Forms.Button buttonSettingCancel;
    }
}