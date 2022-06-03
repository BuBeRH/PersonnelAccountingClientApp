namespace PersonnelAccountingClientApp
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
            this.components = new System.ComponentModel.Container();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridPersonal = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.functionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departamentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ButtonExit.Location = new System.Drawing.Point(656, 360);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(132, 42);
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
            this.idDataGridViewTextBoxColumn,
            this.functionDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.departamentDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.specialInformationDataGridViewTextBoxColumn});
            this.DataGridPersonal.DataSource = this.personViewBindingSource4;
            this.DataGridPersonal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridPersonal.Location = new System.Drawing.Point(12, 72);
            this.DataGridPersonal.MultiSelect = false;
            this.DataGridPersonal.Name = "DataGridPersonal";
            this.DataGridPersonal.ReadOnly = true;
            this.DataGridPersonal.RowTemplate.Height = 25;
            this.DataGridPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridPersonal.Size = new System.Drawing.Size(760, 277);
            this.DataGridPersonal.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // functionDataGridViewTextBoxColumn
            // 
            this.functionDataGridViewTextBoxColumn.DataPropertyName = "Function";
            this.functionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.functionDataGridViewTextBoxColumn.Name = "functionDataGridViewTextBoxColumn";
            this.functionDataGridViewTextBoxColumn.ReadOnly = true;
            this.functionDataGridViewTextBoxColumn.Width = 90;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Width = 170;
            // 
            // departamentDataGridViewTextBoxColumn
            // 
            this.departamentDataGridViewTextBoxColumn.DataPropertyName = "Departament";
            this.departamentDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.departamentDataGridViewTextBoxColumn.Name = "departamentDataGridViewTextBoxColumn";
            this.departamentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departamentDataGridViewTextBoxColumn.Width = 110;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Width = 70;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 60;
            // 
            // specialInformationDataGridViewTextBoxColumn
            // 
            this.specialInformationDataGridViewTextBoxColumn.DataPropertyName = "SpecialInformation";
            this.specialInformationDataGridViewTextBoxColumn.HeaderText = "Дополнительно";
            this.specialInformationDataGridViewTextBoxColumn.Name = "specialInformationDataGridViewTextBoxColumn";
            this.specialInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialInformationDataGridViewTextBoxColumn.Width = 177;
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
            this.PersonLabel.Location = new System.Drawing.Point(22, 20);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(373, 30);
            this.PersonLabel.TabIndex = 2;
            this.PersonLabel.Text = "Список сотрудников предприятия ";
            // 
            // ButtonAddPerson
            // 
            this.ButtonAddPerson.Location = new System.Drawing.Point(631, 20);
            this.ButtonAddPerson.Name = "ButtonAddPerson";
            this.ButtonAddPerson.Size = new System.Drawing.Size(141, 33);
            this.ButtonAddPerson.TabIndex = 3;
            this.ButtonAddPerson.Text = "Добавить сотрудника";
            this.ButtonAddPerson.UseVisualStyleBackColor = true;
            this.ButtonAddPerson.Click += new System.EventHandler(this.ButtonAddPerson_Click);
            // 
            // ButtonUpdatePerson
            // 
            this.ButtonUpdatePerson.Location = new System.Drawing.Point(459, 20);
            this.ButtonUpdatePerson.Name = "ButtonUpdatePerson";
            this.ButtonUpdatePerson.Size = new System.Drawing.Size(166, 33);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.ButtonUpdatePerson);
            this.Controls.Add(this.ButtonAddPerson);
            this.Controls.Add(this.PersonLabel);
            this.Controls.Add(this.DataGridPersonal);
            this.Controls.Add(this.ButtonExit);
            this.Name = "Form1";
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
        private Label PersonLabel;
        private Button ButtonAddPerson;
        private Button ButtonUpdatePerson;
        private BindingSource personViewBindingSource1;
        private BindingSource personViewBindingSource;
        private BindingSource personViewBindingSource2;
        private BindingSource personBindingSource2;
        private BindingSource personViewBindingSource4;
        private BindingSource personViewBindingSource3;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn functionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departamentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specialInformationDataGridViewTextBoxColumn;
    }
}