namespace WF_DZ04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            countryComboBox = new ComboBox();
            countryPanel = new Panel();
            cityPanel = new Panel();
            label2 = new Label();
            cityComboBox = new ComboBox();
            streetPanel = new Panel();
            label3 = new Label();
            streetComboBox = new ComboBox();
            buildingPanel = new Panel();
            label4 = new Label();
            buildingComboBox = new ComboBox();
            button1 = new Button();
            countryPanel.SuspendLayout();
            cityPanel.SuspendLayout();
            streetPanel.SuspendLayout();
            buildingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 16);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Страна";
            // 
            // countryComboBox
            // 
            countryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComboBox.FormattingEnabled = true;
            countryComboBox.Location = new Point(96, 16);
            countryComboBox.Name = "countryComboBox";
            countryComboBox.Size = new Size(176, 23);
            countryComboBox.TabIndex = 1;
            countryComboBox.SelectedIndexChanged += countryComboBox_SelectedIndexChanged;
            // 
            // countryPanel
            // 
            countryPanel.Anchor = AnchorStyles.None;
            countryPanel.Controls.Add(label1);
            countryPanel.Controls.Add(countryComboBox);
            countryPanel.Location = new Point(96, 32);
            countryPanel.Name = "countryPanel";
            countryPanel.Size = new Size(288, 48);
            countryPanel.TabIndex = 2;
            // 
            // cityPanel
            // 
            cityPanel.Anchor = AnchorStyles.None;
            cityPanel.Controls.Add(label2);
            cityPanel.Controls.Add(cityComboBox);
            cityPanel.Location = new Point(96, 96);
            cityPanel.Name = "cityPanel";
            cityPanel.Size = new Size(288, 48);
            cityPanel.TabIndex = 2;
            cityPanel.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 0;
            label2.Text = "Город";
            // 
            // cityComboBox
            // 
            cityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            cityComboBox.FormattingEnabled = true;
            cityComboBox.Location = new Point(96, 16);
            cityComboBox.Name = "cityComboBox";
            cityComboBox.Size = new Size(176, 23);
            cityComboBox.TabIndex = 1;
            cityComboBox.SelectedIndexChanged += cityComboBox_SelectedIndexChanged;
            // 
            // streetPanel
            // 
            streetPanel.Anchor = AnchorStyles.None;
            streetPanel.Controls.Add(label3);
            streetPanel.Controls.Add(streetComboBox);
            streetPanel.Location = new Point(96, 160);
            streetPanel.Name = "streetPanel";
            streetPanel.Size = new Size(288, 48);
            streetPanel.TabIndex = 2;
            streetPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(0, 16);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 0;
            label3.Text = "Улица";
            // 
            // streetComboBox
            // 
            streetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            streetComboBox.FormattingEnabled = true;
            streetComboBox.Location = new Point(96, 16);
            streetComboBox.Name = "streetComboBox";
            streetComboBox.Size = new Size(176, 23);
            streetComboBox.TabIndex = 1;
            streetComboBox.SelectedIndexChanged += streetComboBox_SelectedIndexChanged;
            // 
            // buildingPanel
            // 
            buildingPanel.Anchor = AnchorStyles.None;
            buildingPanel.Controls.Add(label4);
            buildingPanel.Controls.Add(buildingComboBox);
            buildingPanel.Location = new Point(96, 224);
            buildingPanel.Name = "buildingPanel";
            buildingPanel.Size = new Size(288, 48);
            buildingPanel.TabIndex = 2;
            buildingPanel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(0, 16);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 0;
            label4.Text = "Дом";
            // 
            // buildingComboBox
            // 
            buildingComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            buildingComboBox.FormattingEnabled = true;
            buildingComboBox.Location = new Point(96, 16);
            buildingComboBox.Name = "buildingComboBox";
            buildingComboBox.Size = new Size(176, 23);
            buildingComboBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(176, 352);
            button1.Name = "button1";
            button1.Size = new Size(112, 32);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 450);
            Controls.Add(button1);
            Controls.Add(buildingPanel);
            Controls.Add(streetPanel);
            Controls.Add(cityPanel);
            Controls.Add(countryPanel);
            Name = "Form1";
            Text = "Form1";
            countryPanel.ResumeLayout(false);
            countryPanel.PerformLayout();
            cityPanel.ResumeLayout(false);
            cityPanel.PerformLayout();
            streetPanel.ResumeLayout(false);
            streetPanel.PerformLayout();
            buildingPanel.ResumeLayout(false);
            buildingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox countryComboBox;
        private Panel countryPanel;
        private Panel cityPanel;
        private Label label2;
        private ComboBox cityComboBox;
        private Panel streetPanel;
        private Label label3;
        private ComboBox streetComboBox;
        private Panel buildingPanel;
        private Label label4;
        private ComboBox buildingComboBox;
        private Button button1;
    }
}
