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
                //if (hp != value) // 변경되었을 때를 알 수 있는 코드
                //{
                    hp = value;
                    Console.WriteLine($"[{name}]의 HP는 {HP}가 되었다.");

                    if (hp <= 0)
                    {
                        Die();
                    }

                    /// 방법 1
                    //if (hp < 0)
                    //    hp = 0;
                    //if (hp > maxHp)
                    //    hp = maxHp;

                    /// 방법 2
                    hp = Math.Clamp(value, 0, maxHp);
                //}
            }
        }

        public bool IsAlive => hp > 0; // 플레이어가 살아있는지 죽어있는지 확인하는 프로퍼티(살아있으면 true, 죽었으면 false)

        protected float maxHp; // 최대 체력
        protected float mp; // 마나..?
        protected float maxMp; // 최대 마나

        protected int level; // 레벨
        protected float exp; // 경험치
        protected const float maxExp = 100; // 최대 경험치 // const : 상수. 절대 변경 불가
        protected float attackPower; // 공격력
        protected float defencePower; // 방어력

        protected string name; // 이름
        public string Name => name; // Name이라는 프로퍼티를 읽기 전용으로 만들고 읽으면 name을 리턴한다.

        protected const float skillCost = 10.0f;
        private bool CanSkillUse => mp > skillCost; // 프로퍼티

        Random random;

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

            random = new Random();
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

            random = new Random();
        }

        public void Attack(Character target)
        {
            if (CanSkillUse)
            {
                //Random random = new Random(); // class이기 때문에 메모리 이슈로 인하여 위에서 한 번만 진행되도록 수정함!!!
                if(random.NextSingle() < 0.3f) // NextSingle은 float을 의미한다.
                {
                    Skill(target);
                }
                else
                {
                    Console.WriteLine($"[{name}]가 공격한다.");
                    target.Defence(attackPower);
                }
            }

            else
            {
                Console.WriteLine($"[{name}]가 공격한다.");
                target.Defence(attackPower);
            }

            //Console.WriteLine($"[{name}]가 공격한다.");
            //target.Skill();
            //target.Defence(attackPower);
        }

        public void Skill(Character target)
        {
            if (CanSkillUse) //mp > skillCost
            {
                mp -= skillCost;

                /// 방법 1
                //float damage = OnSkill();
                //target.Defence(damage);

                /// 방법 2
                target.Defence(OnSkill());
            }
            //Console.WriteLine("무슨 스킬을 사용할까?");
            //Console.WriteLine("(1) 파이어볼 (2) 백만볼트 (3) 얍");
        }

        protected virtual float OnSkill() ///// Skill은 virtual 함수다. => Skill 함수는 상속받은 클래스에서 덮어쓸 수 있다(override 가능).
        {
            Console.WriteLine("캐릭터가 스킬을 사용한다.");
            return 10.0f;
        }

        void Defence(float damage)
        {
            Console.WriteLine($"[{name}]이 {damage - defencePower} 만큼의 피해를 입었습니다.");
            //Console.WriteLine($"[{name}]의 체력은 [{HP}]입니다.");
            HP -= (damage - defencePower);
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