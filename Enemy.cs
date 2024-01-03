using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Enemy : Character
    {
        public Enemy(string _name) : base(_name)
        {

        }

        protected override float OnSkill()
        {
            Console.WriteLine("Villain의 스킬 발동");
            Console.WriteLine($" - 스트라이크 : {name}에게 ({attackPower})만큼의 공격을 합니다.");
            //Console.WriteLine("Villain의 현재 MP는 ({MP})입니다.");
            Console.WriteLine("--------------------------------------------------");

            return attackPower;
        }

        protected override void OnDefence()
        {
            Console.WriteLine("Villain의 방어");
            Console.WriteLine($" - 적의 공격을 방어하여 최종적으로 {defencePower - damage} 만큼의 피해를 입었습니다.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Villain의 현재 HP는 ({HP})입니다.");
            Console.WriteLine("");
        }
    }
}