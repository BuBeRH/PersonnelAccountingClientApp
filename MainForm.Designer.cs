namespace PersonnelAccountingClientApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridPersonal = new System.Windows.Forms.DataGridView();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personViewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PersonLabel = new System.Windows.Forms.Label();
            this.ButtonAddPerson = new System.Windows.Forms.Button();
            this.ButtonUpdatePerson = new System.Windows.Forms.Button();
            this.personViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonDeletePerson = new System.Windows.Forms.Button();
            this.LabelFilter = new System.Windows.Forms.Label();
            this.BoxFilter = new System.Windows.Forms.TextBox();
            this.BoxFilterRule = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonExit.Location = new System.Drawing.Point(962, 483);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(151, 56);
            this.ButtonExit.TabIndex = 0;
            this.ButtonExit.Text = "Выход";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.Person);
            // 
            // DataGridPersonal
            // 
            this.DataGridPersonal.AllowUserToAddRows = false;
            this.DataGridPersonal.AllowUserToDeleteRows = false;
            this.DataGridPersonal.AllowUserToResizeColumns = false;
            this.DataGridPersonal.AllowUserToResizeRows = false;
            this.DataGridPersonal.AutoGenerateColumns = false;
            this.DataGridPersonal.CausesValidation = false;
            this.DataGridPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.specialInformationDataGridViewTextBoxColumn});
            this.DataGridPersonal.DataSource = this.personViewBindingSource4;
            this.DataGridPersonal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridPersonal.Location = new System.Drawing.Point(14, 102);
            this.DataGridPersonal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataGridPersonal.MultiSelect = false;
            this.DataGridPersonal.Name = "DataGridPersonal";
            this.DataGridPersonal.ReadOnly = true;
            this.DataGridPersonal.RowHeadersWidth = 51;
            this.DataGridPersonal.RowTemplate.Height = 25;
            this.DataGridPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridPersonal.Size = new System.Drawing.Size(1099, 363);
            this.DataGridPersonal.TabIndex = 1;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 290;
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "Function";
            this.functionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.functionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            this.functionDataGridViewTextBoxColumn.ReadOnly = true;
            this.functionDataGridViewTextBoxColumn.Width = 220;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 98;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 90;
            // 
            // specialInformationDataGridViewTextBoxColumn
            // 
            this.specialInformationDataGridViewTextBoxColumn.DataPropertyName = "SpecialInformation";
            this.specialInformationDataGridViewTextBoxColumn.HeaderText = "Дополнительно";
            this.specialInformationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.specialInformationDataGridViewTextBoxColumn.Name = "specialInformationDataGridViewTextBoxColumn";
            this.specialInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialInformationDataGridViewTextBoxColumn.Width = 347;
            // 
            // personViewBindingSource4
            // 
            this.personViewBindingSource4.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.PersonView);
            // 
            // personBindingSource2
            // 
            this.personBindingSource2.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.Person);
            // 
            // personViewBindingSource2
            // 
            this.personViewBindingSource2.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.PersonView);
            // 
            // personBindingSource1
            // 
            this.personBindingSource1.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.Person);
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonLabel.Location = new System.Drawing.Point(14, 12);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(475, 37);
            this.PersonLabel.TabIndex = 2;
            this.PersonLabel.Text = "Список сотрудников предприятия";
            // 
            // ButtonAddPerson
            // 
            this.ButtonAddPerson.Location = new System.Drawing.Point(558, 12);
            this.ButtonAddPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAddPerson.Name = "ButtonAddPerson";
            this.ButtonAddPerson.Size = new System.Drawing.Size(170, 44);
            this.ButtonAddPerson.TabIndex = 3;
            this.ButtonAddPerson.Text = "Добавить сотрудника";
            this.ButtonAddPerson.UseVisualStyleBackColor = true;
            this.ButtonAddPerson.Click += new System.EventHandler(this.ButtonAddPerson_Click);
            // 
            // ButtonUpdatePerson
            // 
            this.ButtonUpdatePerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonUpdatePerson.Location = new System.Drawing.Point(734, 12);
            this.ButtonUpdatePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonUpdatePerson.Name = "ButtonUpdatePerson";
            this.ButtonUpdatePerson.Size = new System.Drawing.Size(208, 44);
            this.ButtonUpdatePerson.TabIndex = 4;
            this.ButtonUpdatePerson.Text = "Редактировать сотрудника";
            this.ButtonUpdatePerson.UseVisualStyleBackColor = true;
            this.ButtonUpdatePerson.Click += new System.EventHandler(this.ButtonUpdatePerson_Click);
            // 
            // personViewBindingSource
            // 
            this.personViewBindingSource.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.PersonView);
            // 
            // personViewBindingSource1
            // 
            this.personViewBindingSource1.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.PersonView);
            // 
            // personViewBindingSource3
            // 
            this.personViewBindingSource3.DataSource = typeof(PersonnelAccountingClientApp.Classes.Personal.PersonView);
            // 
            // ButtonDeletePerson
            // 
            this.ButtonDeletePerson.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonDeletePerson.Location = new System.Drawing.Point(948, 13);
            this.ButtonDeletePerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonDeletePerson.Name = "ButtonDeletePerson";
            this.ButtonDeletePerson.Size = new System.Drawing.Size(165, 44);
            this.ButtonDeletePerson.TabIndex = 5;
            this.ButtonDeletePerson.Text = " Удалить сотрудника";
            this.ButtonDeletePerson.UseVisualStyleBackColor = true;
            this.ButtonDeletePerson.Click += new System.EventHandler(this.ButtonDeletePerson_Click);
            // 
            // LabelFilter
            // 
            this.LabelFilter.AutoSize = true;
            this.LabelFilter.Location = new System.Drawing.Point(14, 65);
            this.LabelFilter.Name = "LabelFilter";
            this.LabelFilter.Size = new System.Drawing.Size(60, 20);
            this.LabelFilter.TabIndex = 6;
            this.LabelFilter.Text = "Фильтр";
            // 
            // BoxFilter
            // 
            this.BoxFilter.Location = new System.Drawing.Point(203, 65);
            this.BoxFilter.Name = "BoxFilter";
            this.BoxFilter.Size = new System.Drawing.Size(199, 27);
            this.BoxFilter.TabIndex = 7;
            this.BoxFilter.TextChanged += new System.EventHandler(this.BoxFilter_TextChanged);
            // 
            // BoxFilterRule
            // 
            this.BoxFilterRule.FormattingEnabled = true;
            this.BoxFilterRule.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Должность"});
            this.BoxFilterRule.Location = new System.Drawing.Point(80, 65);
            this.BoxFilterRule.Name = "BoxFilterRule";
            this.BoxFilterRule.Size = new System.Drawing.Size(105, 28);
            this.BoxFilterRule.TabIndex = 8;
            this.BoxFilterRule.Text = "Фамилия";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 552);
            this.Controls.Add(this.BoxFilterRule);
            this.Controls.Add(this.BoxFilter);
            this.Controls.Add(this.LabelFilter);
            this.Controls.Add(this.ButtonDeletePerson);
            this.Controls.Add(this.ButtonUpdatePerson);
            this.Controls.Add(this.ButtonAddPerson);
            this.Controls.Add(this.PersonLabel);
            this.Controls.Add(this.DataGridPersonal);
            this.Controls.Add(this.ButtonExit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personViewBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonExit;
        private BindingSource personBindingSource;
        private DataGridView DataGridPersonal;
        private BindingSource personBindingSource1;
        private Button ButtonAddPerson;
        private Button ButtonUpdatePerson;
        private BindingSource personViewBindingSource1;
        private BindingSource personViewBindingSource;
        private BindingSource personViewBindingSource2;
        private BindingSource personBindingSource2;
        private BindingSource personViewBindingSource4;
        private BindingSource personViewBindingSource3;
        private Button ButtonDeletePerson;
        private Label PersonLabel;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specialInformationDataGridViewTextBoxColumn;
        private Label LabelFilter;
        private TextBox BoxFilter;
        private ComboBox BoxFilterRule;
    }
}