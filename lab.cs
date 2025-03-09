namespace lab
{
    public class AccountControl
    {
        string[] usernames = new string[0];
        string[] passwords = new string[0];

        public  string[] CreateUsername()
        {
            string username;
            Console.Write("Username yarating:");
            username = Convert.ToString(Console.ReadLine());
            string usernameHashed = Convert.ToString(username.GetHashCode());
            usernames = usernames.Append(usernameHashed).ToArray();

            return usernames;
        }

        public  string[] CreatePassword()
        {
            string password;
            Console.Write("password yarating:");
            password = Convert.ToString(Console.ReadLine());
            string passwordHashed = Convert.ToString(password.GetHashCode());
            passwords = passwords.Append(passwordHashed).ToArray();
            return passwords;
        }

        public void DRM()
        {
            string username;
            string password;
            bool usernameTrue = false;
            bool paswordTrue = false;
            while (true)
            {
                Console.Write("Username kiriting:");
                username = Convert.ToString(Console.ReadLine());
                string usernameHashed = Convert.ToString(username.GetHashCode());
                Console.Write("Parol kiting:");
                password = Convert.ToString(Console.ReadLine());
                string passwordHashed = Convert.ToString(password.GetHashCode());
                foreach (string element in usernames)
                {
                    if (element == usernameHashed)
                    {
                        usernameTrue = true;
                    }
                }
                foreach (string element in passwords)
                {
                    if (element == passwordHashed)
                    {
                        paswordTrue = true;
                    }
                }

                if (paswordTrue == true && usernameTrue == true) {
                    break;
                
                }
                else
                {
                    Console.WriteLine("qayta urinib koring!");
                }
            }
            Console.WriteLine("Akkauntga Mufaqiyatli kirdingiz");
            foreach (string element in passwords)
            {
                Console.Write("Passwords:" +element);
            }            
            foreach (string element in usernames)
            {
                Console.WriteLine("Usernames:" + element);
            }

            


        }
    }
}