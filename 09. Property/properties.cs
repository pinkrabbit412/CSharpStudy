using System;

namespace CSharpStudy {
    public interface IAccount {
        // Property in Interface
        int ID { get; set; }
        string ScreenName { get; set; }
        void GetUserInfo();
    }
    public abstract class Account : IAccount {
        // Auto-Implemented Property
        public int ID { get; set; } = 0;
        public string ScreenName { get; set; } = "Unknown";
        public void GetUserInfo() {
            Console.WriteLine("[?] Requested user's info at below: ");
            Console.WriteLine("    - screen_name = {0}, ID = {1:d8}\n", this.ScreenName, this.ID);
        }
    }
    public class UserAccount : Account {
        /* [Standard method]
        private int ID = 0;  // This is 'Field'
        private string name = "";
        public int AccountID {  // This is 'Property'
            get {
                return ID;
            }
            set {
                ID = value;
            }
        }
        public string AccountName {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public void GetUserInfo() {  // This is 'Method'
            Console.WriteLine("[?] Requested user's info at below: ");
            Console.WriteLine("    - screen_name = {0}, ID = {1:d8}", this.ScreenName, this.ID);
        }
        */
    }

    public class Properties {
        public static void Main(string[] args) {
            UserAccount User1 = new UserAccount();
            User1.ID = 1;
            User1.ScreenName = "pinkrabbit412";
            User1.GetUserInfo();

            // Initialize object using Property
            UserAccount User2 = new UserAccount() { ID = 2, ScreenName = "YT_AkdongRabbit" };
            User2.GetUserInfo();

            // Anonymous type (READ ONLY, This is useful with LINQ)
            var NewUser = new { ID = 3, ScreenName = "AkdongRabbit" };
            Console.WriteLine("[?] Please check your information at below: ");
            Console.WriteLine("    - screen_name = {0}, ID = {1:d8}", NewUser.ScreenName, NewUser.ID);

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}