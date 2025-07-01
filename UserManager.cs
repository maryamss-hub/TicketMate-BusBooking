using MongoDB.Driver;

namespace TicketMate
{
    public static class UserManager
    {
        private static IMongoCollection<User> userCollection = DatabaseHelper.GetCollection<User>("Users");

        public static bool RegisterUser(string name, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return false;

            var existingUser = userCollection.Find(u => u.Email == email).FirstOrDefault();
            if (existingUser != null)
                return false; // Email already exists

            var newUser = new User
            {
                Name = name,
                Email = email,
                Password = password
            };

            userCollection.InsertOne(newUser);
            return true;
        }

        public static User Authenticate(string email, string password)
        {
            return userCollection.Find(u => u.Email == email && u.Password == password).FirstOrDefault();
        }
    }
}
