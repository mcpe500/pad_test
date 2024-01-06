using PAD_ROTIKITA.Contracts;
using PAD_ROTIKITA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAD_ROTIKITA.Controller
{
    public class UserHandler
    {
        private static db_rotiEntities db = DatabaseService.GetDbContext();
        public static string user_ID;
        public static string nama;
        public static string role;

        public static string getNewUserID(string role)
        {
            var user = db.users.Where(u => u.role == role).OrderByDescending(u => u.user_id).FirstOrDefault();
            if (user != null)
            {
                string lastId = user.user_id;
                string idCount = "";
                for (int i = 0; i < lastId.Length; i++)
                {
                    if (char.IsDigit(lastId[i]))
                    {
                        idCount += lastId[i];
                    }
                }
                int newIdCount = int.Parse(idCount) + 1;
                return DatabaseService.PadLeftZero(role, newIdCount, 10);
            }
            return DatabaseService.PadLeftZero(role, 1, 10);
        }
        public static List<UserVisible> GetAllUsersVisible()
        {
            var users = (from user in db.users
                         select user).OrderBy(user => user.user_id).ToList();
            List<UserVisible> listUser = new List<UserVisible>();
            foreach (var user in users)
            {
                listUser.Add(new UserVisible(user.user_id, user.nama, user.role));
            }
            return listUser;
        }
        public static void AddUser(string nama, string password, string role)
        {
            if (nama == "" || password == "" || role == "")
            {
                MessageBox.Show("Tidak boleh ada kolom kosong!");
                return;
            }
            string userId = getNewUserID(role);
            string hashedPassword = SimpleHash(password);
            user newUser = new user()
            {
                user_id = userId,
                nama = nama,
                password = hashedPassword,
                role = role
            };
            db.users.Add(newUser);
            db.SaveChanges();
        }
        public static string reverseString(string text)
        {
            string reversed = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }
        public static string SimpleHash(string text)
        {
            string hashed = "";
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = (char)(text[i] + 13);
                if (currentChar >= 'z' || currentChar >= 'Z')
                {
                    currentChar -= (char)26;
                }
                //if (currentChar > 'Z')
                //{
                //    currentChar -= (char)26;
                //}

                hashed += currentChar;
            }
            hashed = reverseString(hashed);
            return hashed;
        }


        public static bool LoginHandler(string userID, string password)
        {
            string hashedPassword = SimpleHash(password);
            var users = from user in db.users
                        where user.user_id == userID && user.password == hashedPassword
                        select user;
            //var users = db.users.Where(u => u.user_id == userID && u.password == SimpleHash(password)).FirstOrDefault();
            if (users.Count() == 0)
            {
                return false;
            }
            else
            {
                user_ID = users.FirstOrDefault().user_id;
                nama = users.FirstOrDefault().nama;
                role = users.FirstOrDefault().role;
                return true;
            }
        }

    }
}
