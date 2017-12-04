using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8.User_Database
{
    class Program
    {
      private static string dbName = "users.txt";
        private static Dictionary<string, string> virtuallDB = new Dictionary<string, string>();
        private static string loggedUser = null;
            
        static void Main(string[] args)
        {
            if (File.Exists(dbName))
            {
                File.Create(dbName).Close();
            }

            //Load files from "users.txt"

            string[] commands = File.ReadAllLines("TextFIle1.txt");
            foreach (var item in commands)
            {
                var tokens = item.Split(' ');
                switch (tokens[0])
                {
                    case "register":
                        var userName = tokens[1];
                        var pass = tokens[2];
                        var confirmedPass = tokens[3];
                        Register(userName,pass,confirmedPass);
                        break;
                    case "login":
                        userName = tokens[1];
                        pass = tokens[2];
                        Login(userName, pass);
                        break;
                    case "logout":
                        Logout();
                        break;

                }
                
            }
          
        }

        private static void Logout()
        {
            if(loggedUser == null)
            {
                Console.WriteLine("There is no currently logged in user.");
                return;
            }
            loggedUser = null; 
        }

        private static void Login(string userName, string pass)
        {
           if(loggedUser != null)
            {
                Console.WriteLine("There is already a logged in user");
                return;
            }
           if(!virtuallDB.ContainsKey(userName))
            {

                Console.WriteLine("There is no user with the given username.");
                return;
            }
            if (pass != virtuallDB[userName])
            {
                Console.WriteLine("The password you entered is incorrect.");
            }
            
        }

        private static void Register(string userName, string pass, string confirmedPass)
        {
            if(virtuallDB.ContainsKey(userName))
            {
                Console.WriteLine("The given username already exist.");
                    return;
            }
            if(pass != confirmedPass)
            {
                Console.WriteLine("The two passwords must match.");
                return;
            }
            virtuallDB[userName] = pass;
            File.AppendAllText("users.txt", $"{userName} {pass} {Environment.NewLine} ");



        }
    }
}
