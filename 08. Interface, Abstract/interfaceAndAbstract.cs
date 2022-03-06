using System;

namespace CSharpStudy {
    // #1. Declare Interface, and use it (Multiple inheritance is allowed at Interface, but not Abstract class)
    public interface I_Fireable {
        void Fire();
    }
    public interface I_InternalMagazine {
        void ReloadToChamber();
    }
    public interface I_MagazineReloadable {
        void Reload();
    }
    public class PP91 : I_Fireable, I_MagazineReloadable {
        private int round = 30;
        public void Fire() {
            round--;
            return;
        }
        public void Reload() {
            round = 30;
        }
    }

    // #2. Making interface-inherited interface / Muiti-interface inheriting
    public interface I_AssaultRifle : I_Fireable, I_MagazineReloadable {
        void Reload(int round_amount);
    }
    // #4. Abstract Class
    public abstract class AR15 : I_AssaultRifle {
        private int round = 10;
        public void Fire() {
            if (round <= 0) {
                Console.Write("**Tick** ");
                return;
            }
            round--;
            Console.Write("Bang! ");
        }
        public void Reload() {
            Console.Write("**Reloaded** ");
            round = 10;
        }
        public void Reload(int round_amount) {
            Console.Write("**Reloaded as {0} round magazine.** ", round_amount);
            round = round_amount;
        }
    }
    public class M4_Carbine : AR15 { }
    public class InterfaceAndAbstract {
        public static void Main(string[] args) {
            M4_Carbine Akdong_v1_M4 = new M4_Carbine();

            for (int i = 0; i <= 10; i++) {
                Akdong_v1_M4.Fire();
            }
            Akdong_v1_M4.Reload();

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}