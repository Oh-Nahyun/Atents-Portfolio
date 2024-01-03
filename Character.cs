using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject
{
    class Character
    {
        private float hp; // 체력
        public float HP // 프로퍼티(property)
        {
            get => hp; // 읽기는 public
            private set // 쓰기는 private
            {
                hp = value;
                //Console.WriteLine($"[{name}]의 HP는 {HP}가 되었다.");

                if (hp <= 0)
                {
                    Die();
                }

                hp = Math.Clamp(value, 0, maxHp);
            }
        }
        protected float maxHp; // 최대 체력

        public bool IsAlive => hp > 0; // 플레이어가 살아있는지 죽어있는지 확인하는 프로퍼티(살아있으면 true, 죽었으면 false)

        protected float mp; // 마나
        public float MP
        {
            get => mp; // 읽기는 public
            private set // 쓰기는 private
            {
                mp = value;

                if (mp <= 0)
                {
                    
                }

                mp = Math.Clamp(value, 0, maxMp);
            }
        }
        protected float maxMp; // 최대 마나

        /*
        private int mySkill;
        public int MySkill
        {
            get => mySkill;
            private set
            {
                mySkill = value;
            }
        }
        */

        protected int level; // 레벨
        protected float exp; // 경험치
        protected const float maxExp = 100; // 최대 경험치
        protected float attackPower; // 공격력
        protected float defencePower; // 방어력
        protected float damage;

        protected string name; // 이름
        public string Name => name; // Name이라는 프로퍼티를 읽기 전용으로 만들고 읽으면 name을 리턴한다.

        protected string MyJob; // 직업
        public string myjob => MyJob;
        protected string JobInfo; // 직업 정보

        protected const float skillCost = 10.0f;
        private bool CanSkillUse => mp > skillCost; // 프로퍼티

        Random random;

        public Character(string _name)
        {
            random = new Random();

            hp = 100.0f;
            maxHp = 100.0f;
            mp = 50.0f;
            maxMp = 50.0f;
            level = 1;
            exp = 0.0f;
            attackPower = random.Next(30) * 1.0f;
            defencePower = random.Next(10) * 1.0f;
            this.name = _name;
        }

        public void Attack(Character target)
        {
            Console.Write("당신의 행동을 선택하세요 (1.일반공격 2.스킬) : ");

            if (CanSkillUse)
            {
                target.OnSkill();
            }

            else
            {
                Console.WriteLine($"[{name}]가 공격한다.");
                target.OnDefence();
            }
        }

        public void Avoidance(Character target)
        {
            target.OnDefence();
        }

        protected virtual float OnSkill()
        {
            //Console.WriteLine($"{name}의 스킬 발동");
            return 10.0f; /////수??????????????????????????????
        }

        protected virtual void OnDefence()
        {
            //Console.WriteLine($"{name}의 방어");
            HP -= (damage - defencePower);
            //Console.WriteLine($"[{name}]이 {damage - defencePower} 만큼의 피해를 입었습니다.");
            //Console.WriteLine($"[{name}]의 체력은 [{HP}]입니다.");
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