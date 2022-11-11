namespace ActividadNet.Models
{
    public class Bootcamp
    {
        private int id { get; set; }
        private List<User> users { get; set; }

        public Bootcamp(int id) { 
            this.id = id;
        }

        public void AddUser(User user) {
            this.users.Add(user);
        }

        public List<User> getUsers() 
        {
            return this.users;
        }
    }
}
