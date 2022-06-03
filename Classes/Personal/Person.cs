using System.Text.Json.Serialization;

namespace PersonnelAccountingClientApp.Classes.Personal
{
    public class Person : GeneralInformation
    {
        [JsonPropertyName("Function")]
        public string Function { 
            get
            {
                return function;
            }
            set
            {
                function = value;
                DeleteExcessInformation(value);
            } 
        }


        private void DeleteExcessInformation(string NameFunction)
        {
            if(NameFunction != "Директор")
            {
                UniqueDirector = null;
            }
            if (NameFunction != "Руководитель подразделения")
            {
                UniqueLeader = null;
            }
            if (NameFunction != "Контролер")
            {
                UniqueControler = null;
            }
            if (NameFunction != "Рабочий")
            {
                UniqueWorker = null;
            }
        }

        public PersonView ConvertToPersonView()
        {
            PersonView person = new();

            person.Id = Id;
            person.Function = Function;
            person.LastName = LastName;
            person.FirstName = FirstName;
            person.ThirdName = ThirdName;
            person.Departament = Departament;
            person.DateOfBirth = DateOfBirth;
            person.Gender = Gender;
            person.UniqueDirector = UniqueDirector;
            person.UniqueLeader = UniqueLeader;
            person.UniqueControler = UniqueControler;
            person.UniqueWorker = UniqueWorker;

            return person;
        }
    }
}
