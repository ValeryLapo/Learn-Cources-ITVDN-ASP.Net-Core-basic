
using EFCApp.Entities;

namespace EFCApp
{
    class Operations
    {
        public static void Create(User user)
        {
            using (Context db = new Context())
            {
                db.Users?.Add(user);
                db.SaveChanges();
            }
        }


        public static User Read(int id)
        {
            using (Context db = new Context())
            {
                foreach (User user in db.Users)
                {
                    if (user.Id == id) return user;
                }
            }

            return null;
        }
        public static void Update(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
        }

        public static void Delete(User user)
        {
            using (Context db = new Context())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
