namespace ActividadNet.Models
{
    public class Bootcamp
    {
        public int id;
        public List<User> users;

        public Bootcamp(int id)
        {
            this.id = id;
        }
    }
}
