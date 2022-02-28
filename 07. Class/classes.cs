using System;

namespace CSharpStudy {
    /* [ List of Access modifier ]
     * public               Internal & External access is OK
     * protected            External is BLOCKED, but from Derived class is OK
     * private              Internal access ONLY
     * internal             Determined 'public' at same assembly(file), but other access will be BLOCKED 
     * protected internal   Determined 'protected' at same assembly(file), but other access will be BLOCKED
     * private protected    Access from inherited class ONLY (Must be at same assembly(file))
    */

    // To prevent deriving, use 'sealed' keyword
    // (ex #1. public sealed class A - Blocking class inheriting)
    // (ex #2. public sealed void B() - Blocking method overriding)
    public static class ClassForExtentionMethod {
        public static void PrintThis(this string a) {
            Console.WriteLine(a);
        }
    }
    public partial class Character {  // Skipping destructor in here
        public string character_name = "";
        public uint health_point = 0, mana_point = 0, strength = 0;
        public static int character_count = 0;  // Static variable
        public Character() {
            this.health_point = 100;
            this.mana_point = 100;
        }
        public Character(string name, uint STR) : this() {  // Using this(), Setting HP and MP to 100
            this.character_name = name;
            this.strength = STR;
            CallThisAfterNewCharacterAdded();
        }
        public Character(string name, uint HP, uint MP, uint STR) {  // Using this(), Setting HP and MP to 100
            this.character_name = name;
            this.health_point = HP;
            this.mana_point = MP;
            this.strength = STR;
            CallThisAfterNewCharacterAdded();
        }
    }
    // Partial class, can split class definition at other parts or other files.
    public partial class Character {
        public void Attack(Character a) {
            Console.WriteLine("\n[!] {0} attacked {1}! ({0}'s STR = {2})", character_name, a.character_name, strength);
            if (a.health_point > this.strength) {
                a.health_point -= this.strength;
                Console.WriteLine("    - {0}'s remaining HP = {1}", a.character_name, a.health_point);
            }
            else if (a.health_point == this.strength)
                a.health_point = 0;
            else
                a.health_point = 0;
            if (a.health_point <= 0) {
                Console.WriteLine("[!] {0} has been eliminated by {1}'s attack!", a.character_name, character_name);
            }
            Console.WriteLine();
        }
        public virtual void Heal(Character a) {
            uint heal_amount = 45;
            a.health_point += heal_amount;
            Console.WriteLine("\n[!] {0} healed {1}! (+{2}HP)", character_name, a.character_name, heal_amount);
        }
        public void CallThisAfterNewCharacterAdded() {
            character_count++;
        }
        public void DisplayCharacterInfo() {  // Instance method
            Console.WriteLine("  [?] Character name = {0}", this.character_name);
            Console.WriteLine("      HP = {0}/100  |  MP = {1}/100  |  STR = {2}", this.health_point, this.mana_point, this.strength);
        }
        public static void GetCharacterCount() {  // Static method
            Console.WriteLine("\n[?] {0} character in this program.", character_count);
        }
        public Character CopyFromThisCharacter(Character a) {  // Deep copying method
            this.character_name = a.character_name;
            this.health_point = a.health_point;
            this.mana_point = a.mana_point;
            this.strength = a.strength;
            CallThisAfterNewCharacterAdded();
            return this;
        }
    }
    public class EnemyCharacter : Character {  // Inherited from class:Character
        // Inherited class must re-define constructor
        static uint enemy_count = 0;
        public EnemyCharacter() {
            this.health_point = 20;
            this.mana_point = 0;
            enemy_count++;
            base.CallThisAfterNewCharacterAdded();  // base keyword, access to the parent class
        }
        public EnemyCharacter(string name, uint STR) : this() {  // Using this(), Setting HP and MP to 100
            this.character_name = name;
            this.strength = STR;
        }
        public EnemyCharacter(string name, uint HP, uint MP, uint STR) {  // Using this(), Setting HP and MP to 100
            this.character_name = name;
            this.health_point = HP;
            this.mana_point = MP;
            this.strength = STR;
            enemy_count++;
            base.CallThisAfterNewCharacterAdded();
        }
        public override void Heal(Character a) {  
            uint heal_amount = 5;
            a.health_point += heal_amount;
            Console.WriteLine("\n[!] {0} healed {1}! (+{2}HP)", character_name, a.character_name, heal_amount);
        }
        public new static void GetCharacterCount() {
            Console.WriteLine("\n[?] {0} enemy in this program.", enemy_count);
        }
    }
    class Classes {
        public static void Main(String[] args) {

            // 1. Make new class named 'Character'
            Character Revi = new Character(name: "Revi", STR: 30);
            Revi.DisplayCharacterInfo();
            Character Preen = new Character(name: "Preen", STR: 15);
            Preen.DisplayCharacterInfo();
            Character.GetCharacterCount();  // Call static method

            Revi.Attack(Preen);

            //Character CopiedPreen = Preen;  // Shallow copy - This will cause various problem (Reference type)

            Character CopiedPreen = new Character();
            CopiedPreen.CopyFromThisCharacter(Preen);
            CopiedPreen.character_name = "Preen (Copied)";
            CopiedPreen.DisplayCharacterInfo();

            Revi.Attack(Preen);
            Revi.DisplayCharacterInfo();
            Preen.DisplayCharacterInfo();
            CopiedPreen.DisplayCharacterInfo();

            EnemyCharacter Monster1 = new EnemyCharacter(name: "Monster1", STR: 10);
            Monster1.DisplayCharacterInfo();

            Character.GetCharacterCount();

            Console.WriteLine("[?] (Preen is EnemyCharacter) = {0}", Preen is Character);
            Console.WriteLine("[?] (Preen is EnemyCharacter) = {0}\n", Preen is EnemyCharacter);

            EnemyCharacter Monster2 = new EnemyCharacter(name: "Monster2", STR: 5);
            //Character Neutral1 = Monster2 as Character;  // (= (Character)monster2 )
            // ▲ Be aware this line copies 'monster2' shallowly.
            //Neutral1.character_name = "neutral1";
            //Neutral1.DisplayCharacterInfo();

            Preen.Heal(Preen);
            Preen.DisplayCharacterInfo();

            Monster1.Heal(Monster1);
            Monster1.DisplayCharacterInfo();

            EnemyCharacter.GetCharacterCount();
            "\n\n[!] End of examples.".PrintThis();

            // Program exit
            Console.WriteLine("\n\n[?] Press any key to exit... ");
            Console.ReadKey();
            return;
        }
    }
}