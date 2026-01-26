namespace LabØvelse4
{
    public class UserAccount
    {
        public string Username { get; private set; }
        private string Password ;

        public void EditPassword(string NewPassword)
        {
            Password = NewPassword;
        }
    }
}
