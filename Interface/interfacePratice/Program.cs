using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacePratice
{
    class Program
    {
        static void Main(string[] args)
        {
            Character You = new Character();
            Character Oak = new Character();

            You.name = "You";
            Oak.name = "Oak";

            You.Attack(You, Oak);
            You.Hit(Oak, 10);
            
            Oak.Attack(Oak, You);
            Oak.Hit(You, 5);
            
            You.CriticalAttack(You, Oak, 90);
        }
    }

    class Character
    {
        public string name;
        int hp = 100;

        public void Attack(Character me, Character target)
        {
            Console.WriteLine($"{me.name}가 {target.name}에게 공격을 했습니다.");
        }

        public void Hit(Character me, int damage)
        {
            Console.WriteLine($"{me.name}가 {damage}의 공격을 받았습니다.");
            
            int result = hp - damage;

            if (hp <= 0)
                Console.WriteLine($"Hp가 없습니다. {me.name}는 죽었습니다.");

            Console.WriteLine($"현재 남아있는 Hp는 {result}입니다.\n");
            
            hp = result;
        }

        public void CriticalAttack(Character me, Character target, int damage)
        {
            int result = hp - damage;

            Console.WriteLine($"{me.name}가 {target.name}에게 {damage}의 치명타를 주었습니다.");

            hp = result;

            if (hp <=0)
            {
                Console.WriteLine($"{target.name}의 Hp가 0이 되었습니다.\n");
            }            
        }
    }
}
