using PersonnelAccountingClientApp.Classes.Personal;
using PersonnelAccountingClientApp.Classes.Response;
using PersonnelAccountingClientApp.ServerRequests;

namespace PersonnelAccountingClientApp
{
    public partial class Form1 : Form
    {
        private Person person = new();
        private List<Person> persons = new();

        public Form1()
        {
            InitializeComponent();
            GetListPerson();
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void GetListPerson()
        {
            persons = await Requests.GetPersons();
            List<PersonView> persondata = new();
            foreach (Person person in persons)
            {
                persondata.Add(person.ConvertToPersonView());
            }
            DataGridPersonal.DataSource = persondata;
        }

        private void ButtonAddPerson_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonUpdatePerson_Click(object sender, EventArgs e)
        {
            person = persons[DataGridPersonal.CurrentCell.RowIndex];
        }

    }
}