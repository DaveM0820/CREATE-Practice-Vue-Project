namespace my_vue_backend
{
    public class Patient
    {
        public int Id
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string HealthCardNumber
        {
            get; set;
        }
        public int Age
        {
            get; set;
        }
        public List<string> Allergies
        {
            get; set;
        }
        public List<string> Conditions
        {
            get; set;
        }
    }
}
