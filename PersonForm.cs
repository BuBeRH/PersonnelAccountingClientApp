using PersonnelAccountingClientApp.Classes.Personal;
using PersonnelAccountingClientApp.ServerRequests;

namespace PersonnelAccountingClientApp
{
    public partial class PersonForm : Form
    {
        private Person person = new();
        private bool NewOrChange = false;
        private MainForm form = new();
        public PersonForm(Person person, bool NewOrChange,MainForm form) // true - Change, false - new
        {
            this.form = form;
            this.person = person;
            this.NewOrChange = NewOrChange;
            InitializeComponent();
            if (NewOrChange)
            {
                BoxLastName.Text = person.LastName;
                BoxFirstName.Text = person.FirstName;
                BoxThirdName.Text = person.ThirdName;
                PickerDateBirth.Text = person.DateOfBirth;
                ComboBoxFunction.Text = person.Function;
                if (person.Gender == "Мужской") { GenderMale.Checked = true; }
                else { GenderFemale.Checked = true; }
                SwitchFunction();
            }
            else { GenderMale.Checked = true; }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if(NewOrChange) { Requests.UpdatePerson(person); }
            else { Requests.AddPerson(person); }
            form.GetListPerson();
            this.Close();
        }

        private void GenderFemale_Clicked(object sender, EventArgs e)
        {

            GenderMale.Checked = false;
            person.Gender = "Женский";
            GenderFemale.Checked = true;
        }

        private void GenderMale_Clicked(object sender, EventArgs e)
        {
            GenderFemale.Checked = false;
            person.Gender = "Мужской";
            GenderMale.Checked = true;
        }

        private void BoxLastName_TextChanged(object sender, EventArgs e)
        {
            person.LastName = BoxLastName.Text;
        }

        private void BoxFirstName_TextChanged(object sender, EventArgs e)
        {
            person.FirstName = BoxFirstName.Text;
        }

        private void BoxThirdName_TextChanged(object sender, EventArgs e)
        {
            person.ThirdName = BoxThirdName.Text;
        }

        private void PickerDateBirth_ValueChanged(object sender, EventArgs e)
        {
            person.DateOfBirth = DateTime.Parse(PickerDateBirth.Value.ToString()).ToShortDateString();
        }

        private void ComboBoxFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            person.Function = ComboBoxFunction.Text;
            SwitchFunction();
        }

        private void BoxSpecial_TextChanged(object sender, EventArgs e)
        {
            switch (person.Function)
            {
                case "Директор":
                    person.UniqueDirector = BoxSpecial.Text;
                    break;
                case "Руководитель подразделения":
                    person.UniqueLeader = BoxSpecial.Text;
                    break;
                case "Контролер":
                    person.UniqueControler = BoxSpecial.Text;
                    break;
                case "Рабочий":
                    person.UniqueWorker = BoxSpecial.Text;
                    break;
            }
        }

        private void SwitchFunction()
        {
            switch (person.Function)
            {
                case "Директор":
                    LabelSpecial.Text = "Направление деятельности";
                    BoxSpecial.Text = person.UniqueDirector;
                    break;
                case "Руководитель подразделения":
                    LabelSpecial.Text = "Подразделение";
                    BoxSpecial.Text = person.UniqueLeader;
                    break;
                case "Контролер":
                    LabelSpecial.Text = "Контролируемый параметр работы";
                    BoxSpecial.Text = person.UniqueControler;
                    break;
                case "Рабочий":
                    LabelSpecial.Text = "Руководитель";
                    BoxSpecial.Text = person.UniqueWorker;
                    break;
            }
        }
    }
}
