using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Player : Character // Player 클래스가 Character 클래스를 상속 받음
    {
        public Player(string _name) : base(_name)
        {

        }

        protected override float OnSkill() // Player의 Skill 함수는 덮어쓴다.
        {
            string MySkill = Console.ReadLine();
            int.TryParse(MySkill, out int _MySkill);

            if (_MySkill == 1)
            {
                Console.WriteLine($"{name}의 일반 공격");
                Console.WriteLine($" - 불꽃회오리 : Villain에게 ({attackPower})만큼의 공격을 합니다.");
                Console.WriteLine("--------------------------------------------------");
            }

            else if (_MySkill == 2)
            {
                Console.WriteLine($"{name}의 스킬 발동");
                Console.WriteLine($" - 파이어볼 : Villain에게 ({attackPower * 3})만큼의 공격을 합니다.");
                Console.WriteLine("--------------------------------------------------");
            }

            else
            {
                Console.WriteLine("스킬을 다시 선택해주세요.");
                Console.WriteLine("--------------------------------------------------");
                OnSkill();
            }

            return attackPower;
        }

        protected override void OnDefence()
        {
            Console.WriteLine($"{name}의 방어");
            Console.WriteLine("적의 공격에 방어막이 파괴됩니다.");
            Console.WriteLine($" - ({defencePower - damage})만큼의 피해를 입었습니다.");
            Console.WriteLine(" - (8.8) 만큼의 마나가 손상됩니다.");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"{name}의 현재 HP는 ({HP})입니다.");
            Console.WriteLine($"{name}의 현재 MP는 ({MP})입니다.");
            Console.WriteLine("");
        }
    }
}
