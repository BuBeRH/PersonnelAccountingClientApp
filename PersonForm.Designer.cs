namespace PersonnelAccountingClientApp
{
    partial class PersonForm
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
            this.LabelLastName = new System.Windows.Forms.Label();
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.LabelThirdName = new System.Windows.Forms.Label();
            this.BoxLastName = new System.Windows.Forms.TextBox();
            this.BoxFirstName = new System.Windows.Forms.TextBox();
            this.BoxThirdName = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.DateBirdth = new System.Windows.Forms.Label();
            this.PickerDateBirth = new System.Windows.Forms.DateTimePicker();
            this.GenderMale = new System.Windows.Forms.CheckBox();
            this.GenderFemale = new System.Windows.Forms.CheckBox();
            this.GenderLabel = new System.Windows.Forms.Label();
            this.LabelFunction = new System.Windows.Forms.Label();
            this.LabelSpecial = new System.Windows.Forms.Label();
            this.ComboBoxFunction = new System.Windows.Forms.ComboBox();
            this.BoxSpecial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(12, 25);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(73, 20);
            this.LabelLastName.TabIndex = 0;
            this.LabelLastName.Text = "Фамилия";
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(212, 25);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(39, 20);
            this.LabelFirstName.TabIndex = 1;
            this.LabelFirstName.Text = "Имя";
            // 
            // LabelThirdName
            // 
            this.LabelThirdName.AutoSize = true;
            this.LabelThirdName.Location = new System.Drawing.Point(407, 25);
            this.LabelThirdName.Name = "LabelThirdName";
            this.LabelThirdName.Size = new System.Drawing.Size(72, 20);
            this.LabelThirdName.TabIndex = 2;
            this.LabelThirdName.Text = "Отчество";
            // 
            // BoxLastName
            // 
            this.BoxLastName.Location = new System.Drawing.Point(12, 48);
            this.BoxLastName.Name = "BoxLastName";
            this.BoxLastName.Size = new System.Drawing.Size(175, 27);
            this.BoxLastName.TabIndex = 3;
            this.BoxLastName.TextChanged += new System.EventHandler(this.BoxLastName_TextChanged);
            // 
            // BoxFirstName
            // 
            this.BoxFirstName.Location = new System.Drawing.Point(212, 48);
            this.BoxFirstName.Name = "BoxFirstName";
            this.BoxFirstName.Size = new System.Drawing.Size(175, 27);
            this.BoxFirstName.TabIndex = 4;
            this.BoxFirstName.TextChanged += new System.EventHandler(this.BoxFirstName_TextChanged);
            // 
            // BoxThirdName
            // 
            this.BoxThirdName.Location = new System.Drawing.Point(407, 48);
            this.BoxThirdName.Name = "BoxThirdName";
            this.BoxThirdName.Size = new System.Drawing.Size(175, 27);
            this.BoxThirdName.TabIndex = 5;
            this.BoxThirdName.TextChanged += new System.EventHandler(this.BoxThirdName_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(488, 226);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(94, 29);
            this.ConfirmButton.TabIndex = 6;
            this.ConfirmButton.Text = "Сохранить";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(12, 226);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(94, 29);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Отменить";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // DateBirdth
            // 
            this.DateBirdth.AutoSize = true;
            this.DateBirdth.Location = new System.Drawing.Point(12, 89);
            this.DateBirdth.Name = "DateBirdth";
            this.DateBirdth.Size = new System.Drawing.Size(115, 20);
            this.DateBirdth.TabIndex = 8;
            this.DateBirdth.Text = "Дата Рождения";
            // 
            // PickerDateBirth
            // 
            this.PickerDateBirth.Location = new System.Drawing.Point(12, 112);
            this.PickerDateBirth.Name = "PickerDateBirth";
            this.PickerDateBirth.Size = new System.Drawing.Size(185, 27);
            this.PickerDateBirth.TabIndex = 9;
            this.PickerDateBirth.Value = new System.DateTime(2022, 6, 10, 0, 0, 0, 0);
            this.PickerDateBirth.ValueChanged += new System.EventHandler(this.PickerDateBirth_ValueChanged);
            // 
            // GenderMale
            // 
            this.GenderMale.AutoSize = true;
            this.GenderMale.Location = new System.Drawing.Point(244, 112);
            this.GenderMale.Name = "GenderMale";
            this.GenderMale.Size = new System.Drawing.Size(94, 24);
            this.GenderMale.TabIndex = 10;
            this.GenderMale.Text = "Мужской";
            this.GenderMale.UseVisualStyleBackColor = true;
            this.GenderMale.Click += new System.EventHandler(this.GenderMale_Clicked);
            // 
            // GenderFemale
            // 
            this.GenderFemale.AutoSize = true;
            this.GenderFemale.Location = new System.Drawing.Point(344, 112);
            this.GenderFemale.Name = "GenderFemale";
            this.GenderFemale.Size = new System.Drawing.Size(93, 24);
            this.GenderFemale.TabIndex = 11;
            this.GenderFemale.Text = "Женский";
            this.GenderFemale.UseVisualStyleBackColor = true;
            this.GenderFemale.Click += new System.EventHandler(this.GenderFemale_Clicked);
            // 
            // GenderLabel
            // 
            this.GenderLabel.AutoSize = true;
            this.GenderLabel.Location = new System.Drawing.Point(244, 89);
            this.GenderLabel.Name = "GenderLabel";
            this.GenderLabel.Size = new System.Drawing.Size(37, 20);
            this.GenderLabel.TabIndex = 12;
            this.GenderLabel.Text = "Пол";
            // 
            // LabelFunction
            // 
            this.LabelFunction.AutoSize = true;
            this.LabelFunction.Location = new System.Drawing.Point(12, 157);
            this.LabelFunction.Name = "LabelFunction";
            this.LabelFunction.Size = new System.Drawing.Size(86, 20);
            this.LabelFunction.TabIndex = 13;
            this.LabelFunction.Text = "Должность";
            // 
            // LabelSpecial
            // 
            this.LabelSpecial.AutoSize = true;
            this.LabelSpecial.Location = new System.Drawing.Point(302, 157);
            this.LabelSpecial.Name = "LabelSpecial";
            this.LabelSpecial.Size = new System.Drawing.Size(104, 20);
            this.LabelSpecial.TabIndex = 17;
            this.LabelSpecial.Text = "Руководитель";
            // 
            // ComboBoxFunction
            // 
            this.ComboBoxFunction.FormattingEnabled = true;
            this.ComboBoxFunction.Items.AddRange(new object[] {
            "Рабочий",
            "Контролер",
            "Руководитель подразделения",
            "Директор"});
            this.ComboBoxFunction.Location = new System.Drawing.Point(12, 179);
            this.ComboBoxFunction.Name = "ComboBoxFunction";
            this.ComboBoxFunction.Size = new System.Drawing.Size(269, 28);
            this.ComboBoxFunction.TabIndex = 18;
            this.ComboBoxFunction.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFunction_SelectedIndexChanged);
            // 
            // BoxSpecial
            // 
            this.BoxSpecial.Location = new System.Drawing.Point(302, 180);
            this.BoxSpecial.Name = "BoxSpecial";
            this.BoxSpecial.Size = new System.Drawing.Size(280, 27);
            this.BoxSpecial.TabIndex = 19;
            this.BoxSpecial.TextChanged += new System.EventHandler(this.BoxSpecial_TextChanged);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 272);
            this.Controls.Add(this.BoxSpecial);
            this.Controls.Add(this.ComboBoxFunction);
            this.Controls.Add(this.LabelSpecial);
            this.Controls.Add(this.LabelFunction);
            this.Controls.Add(this.GenderLabel);
            this.Controls.Add(this.GenderFemale);
            this.Controls.Add(this.GenderMale);
            this.Controls.Add(this.PickerDateBirth);
            this.Controls.Add(this.DateBirdth);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.BoxThirdName);
            this.Controls.Add(this.BoxFirstName);
            this.Controls.Add(this.BoxLastName);
            this.Controls.Add(this.LabelThirdName);
            this.Controls.Add(this.LabelFirstName);
            this.Controls.Add(this.LabelLastName);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelLastName;
        private Label LabelFirstName;
        private Label LabelThirdName;
        private TextBox BoxLastName;
        private TextBox BoxFirstName;
        private TextBox BoxThirdName;
        private Button ConfirmButton;
        private Button CloseButton;
        private Label DateBirdth;
        private DateTimePicker PickerDateBirth;
        private CheckBox GenderMale;
        private CheckBox GenderFemale;
        private Label GenderLabel;
        private Label LabelFunction;
        private Label LabelSpecial;
        private ComboBox ComboBoxFunction;
        private TextBox BoxSpecial;
    }
}