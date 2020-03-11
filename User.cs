using Newtonsoft.Json;

namespace Demo
{
    public class User
    {
        public string UserName {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Email {get; set;}
        public int[] Grades {get; set;}
        public string PhoneNumber {get; set;}
        public string ProfilePicture {get; set;}

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}