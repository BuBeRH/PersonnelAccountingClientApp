
namespace PersonnelAccountingClientApp.Classes.Personal
{
    public class PersonView : GeneralInformation
    {
        public string Function
        {
            get
            {
                return function;
            }
            set
            {
                function = value;
                UpdateSpecialInformation(value);
            }
        }

        public string? FullName { get; set; }

        private string? firstname;
        public new string? FirstName 
        { 
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
                FullName = LastName + " " + FirstName + " " + ThirdName;
            } 
        }

        private string? lastname;
        public new string? LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
                FullName = LastName + " " + FirstName + " " + ThirdName;
            }
        }

        private string? thirdname;
        public new string? ThirdName
        {
            get
            {
                return thirdname;
            }
            set
            {
                thirdname = value;
                FullName = LastName + " " + FirstName + " " + ThirdName;
            }
        }

        public string? SpecialInformation { get; set; }

        private void UpdateSpecialInformation(string NameFunction)
        {
            if (NameFunction == "Директор")
            {
                SpecialInformation = UniqueDirector;
            }
            else if (NameFunction == "Руководитель подразделения")
            {
                SpecialInformation = UniqueLeader;
            }
            else if (NameFunction == "Контролер")
            {
                SpecialInformation = UniqueControler;
            }
            else if (NameFunction == "Рабочий")
            {
                SpecialInformation = UniqueWorker;
            }
        }
    }
}
