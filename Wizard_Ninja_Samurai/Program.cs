using System;
using System.Collections.Generic;

namespace Wizard_Ninja_Samurai
{
    //Create parent Human class
    public class Human //get rid of all the _health_max stuff. can't get it to work.
    {
        public string name;
        protected int _health;
        public int health{
            get { return _health; }
            set {
                _health = Math.Max(value, 0);
             }
        }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person){
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp){
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void Attack(object obj){
            Human enemy = obj as Human;
            if(enemy == null){
                Console.WriteLine("Failed Attack");
            }
            else{
                enemy.health -= strength*5;
            }
        }
    }

    public class Wizard : Human
    {
        public Wizard(string person) : base(person){
            intelligence = 25;
            health = 50;
        }
        public void Heal(){
            health *= intelligence*10;
        }
        public void Fireball(object obj){
            Random rand = new Random();
            Human enemy = obj as Human;
            if(enemy == null){
                Console.WriteLine("Fireball failed!");
            }
            else{
                enemy.health -= rand.Next(20,51);
                Console.WriteLine($"{name} used fireball on {enemy.name}!");
            }
        }
    }

    public class Ninja : Human
    {
        public Ninja(string person) : base(person){
            dexterity = 175;
        }
        public void Steal(object obj){
            Human enemy = obj as Human;
            if(enemy == null){
                Console.WriteLine("Steal failed!");
            }
            else{
                enemy.health -= 10;
                health += 10;
            }
        }
        public void Get_away(){
            health -= 15;
            Console.WriteLine("You got away!");
        }
    }

    public class Samurai : Human
    {
        public static int count = 0;
        //new public int health{
        //    get { return _health; }
        //    set {
        //        _health = Math.Min(Math.Max(value, 0), _health_max);
        //    }
        //}
        public Samurai(string person) : base(person){
            count++;
            health = 200;
        }
        public void Death_blow(object obj){
            Human enemy = obj as Human;
            if(enemy is null){
                Console.WriteLine("Death blow failed!");
            }
            else{
                if(enemy.health >= 50){
                    Console.WriteLine("This guy is too strong for death blow!");
                }
                else{
                    enemy.health = 0;
                }
            }
        }
        public void Meditate(){
            health = 200;
        }
        public void How_many(){
            Console.WriteLine($"There are {count} samurai.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard zach = new Wizard("Zachard");
            Console.WriteLine($"Intelligence: {zach.intelligence}");
            Console.WriteLine($"Name: {zach.name}");
            Console.WriteLine($"Dexterity: {zach.dexterity}");
            Samurai kyle = new Samurai("Kylai");
            Samurai alex = new Samurai("Alexai");
            alex.How_many();
            Human paul = new Human("Paul");
            zach.Fireball(kyle);
            Console.WriteLine($"Kyle's health is now {kyle.health}");
            zach.Fireball(kyle);
            Console.WriteLine($"Kyle's health is now {kyle.health}");
            zach.Fireball(kyle);
            Console.WriteLine($"Kyle's health is now {kyle.health}");
            zach.Fireball(kyle);
            Console.WriteLine($"Kyle's health is now {kyle.health}");
        }
    }
}
