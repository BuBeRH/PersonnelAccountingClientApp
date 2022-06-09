using PersonnelAccountingClientApp.Classes.Personal;
using PersonnelAccountingClientApp.Classes.Response;
using PersonnelAccountingClientApp.ServerRequests;

namespace PersonnelAccountingClientApp
{
    public partial class MainForm : Form
    {
        private Person person = new();
        private List<Person> persons = new();
        private bool HasFiltred = false;

        public MainForm()
        {
            InitializeComponent();
            GetListPerson();
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            PersonForm Form = new(new Person(), false, this);
            Form.Show();
        }

        private void ButtonUpdatePerson_Click(object sender, EventArgs e)
        {
            PersonForm Form = new(persons[DataGridPersonal.CurrentCell.RowIndex], true, this);
            Form.Show();
        }

        private void ButtonDeletePerson_Click(object sender, EventArgs e)
        {

            Requests.RemovePerson(persons[DataGridPersonal.CurrentCell.RowIndex].Id);
            GetListPerson();
        }

        public async void GetListPerson()
        {
            if (HasFiltred)
            {
                switch (BoxFilterRule.Text)
                {
                    case "Фамилия":
                        persons = await Requests.GetFiltredPerson("LastName", BoxFilter.Text);
                        break;
                    case "Имя":
                        persons = await Requests.GetFiltredPerson("FirstName", BoxFilter.Text);
                        break;
                    case "Отчество":
                        persons = await Requests.GetFiltredPerson("ThirdName", BoxFilter.Text);
                        break;
                    case "Должность":
                        persons = await Requests.GetFiltredPerson("Function", BoxFilter.Text);
                        break;
                }
            }
            else
            {
                persons = await Requests.GetPersons();
            }
            List<PersonView> persondata = new();
            if(persons.Count != 0)
            {
                foreach (Person person in persons)
                {
                    persondata.Add(person.ConvertToPersonView());
                }
            }
            DataGridPersonal.DataSource = persondata;
        }

        private void BoxFilter_TextChanged(object sender, EventArgs e)
        {
            if(BoxFilter.Text != "") { HasFiltred = true; }
            else { HasFiltred = false; }
            GetListPerson();
        }
    }
}