using System;
using System.Collections.Generic;

namespace Human
{
    public class Human
    {
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        public Human(string name_input){
            name = name_input;
        }
        public Human(string name_input, int strength_input, int intelligence_input, int dexterity_input, int health_input){
            name = name_input;
            strength = strength_input;
            intelligence = intelligence_input;
            dexterity = dexterity_input;
            health = health_input;
        }
        //add Attack method that passes 5*strength damage to another Human object
        public void Attack(Human enemy){
            enemy.health -= strength*5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human protege = new Human("Zach");
        }
    }
}
