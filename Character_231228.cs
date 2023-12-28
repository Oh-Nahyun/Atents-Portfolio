using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Character
    {
        /// 액세스 한정자 (접근 제한자)
        /// private, protected, public
        /// 기본이 private

        private float hp; // 체력
        public float HP // 프로퍼티(property)
        {
            get => hp; // 읽기는 public
            private set // 쓰기는 private
            {
                hp = value;

                /// 방법 1
                //if (hp < 0)
                //    hp = 0;
                //if (hp > maxHp)
                //    hp = maxHp;

                /// 방법 2
                hp = Math.Clamp(value, 0, maxHp);
            }
        }

        protected float maxHp; // 최대 체력
        protected float mp; // 마나..?
        protected float maxMp; // 최대 마나
        
        protected int level; // 레벨
        protected float exp; // 경험치
        protected const float maxExp = 100; // 최대 경험치 // const : 상수. 절대 변경 불가
        protected float attackPower; // 공격력
        protected float defencePower; // 방어력
        
        protected string name; // 이름
        string Name => name; // Name이라는 프로퍼티를 읽기 전용으로 만들고 읽으면 name을 리턴한다.

        public Character()
        {
            hp = 100.0f;
            maxHp = 100.0f;
            mp = 50.0f;
            maxMp = 50.0f;
            level = 1;
            exp = 0.0f;
            attackPower = 10.0f;
            defencePower = 5.0f;
            name = "NA";
        }

        public Character(string _name)
        {
            hp = 100.0f;
            maxHp = 100.0f;
            mp = 50.0f;
            maxMp = 50.0f;
            level = 1;
            exp = 0.0f;
            attackPower = 10.0f;
            defencePower = 5.0f;
            this.name = _name;
        }

        public void Attack(Character target)
        {
            Console.WriteLine($"[{name}]가 공격한다.");
            target.Skill();
            target.Defence(attackPower);
        }

        public virtual void Skill() // Skill은 virtual 함수다. => Skill 함수는 상속받은 클래스에서 덮어쓸 수 있다(override 가능).
        {
            Console.WriteLine("무슨 스킬을 사용할까?");
            Console.WriteLine("(1) 파이어볼 (2) 백만볼트 (3) 얍");
        }

        void Defence(float damage)
        {
            HP -= (damage - defencePower);
            Console.WriteLine($"[{name}]이 {damage - defencePower} 만큼의 피해를 입었습니다.");
            Console.WriteLine($"[{name}]의 체력은 [{HP}]입니다.");
        }

        void LevelUp()
        {

        }

        public void Die()
        {
            Console.WriteLine($"[{name}]가 쓰러졌다.");
            Console.WriteLine("게임을 종료합니다.");
        }
    }
}
