using System;
using System.Numerics;
using System.Runtime;
using System.Xml.Linq;
using MyProject;

namespace MyGame;

internal class Program
{
    static void Main(string[] args)
    {
        GameStart();
    }

    /// <summary>
    /// 이름 입력받기
    /// </summary>
    static void NameQues()
    {
        Console.Write("당신의 이름을 입력하세요 : ");
        string MyName = Console.ReadLine();

        Console.Write($"{MyName}으로 결정하시겠습니까? (y/n) : ");
        string MyAns = Console.ReadLine();

        if (MyAns == "y")
        {
            Console.WriteLine($"당신의 이름은 [{MyName}]입니다.");
            Console.WriteLine("");
            //Player player = new Player($"{MyName}");
            ChooseJob();
        }

        else
        {
            Console.WriteLine("취소하겠습니다.");
            Console.WriteLine("--------------------------------------------------");
            NameQues();
        }
    }

    /// <summary>
    /// 직업 선택하기
    /// </summary>
    static void ChooseJob()
    {
        Console.Write("당신의 직업을 선택하세요 (1.Warrior 2.Wizzard 3.Archer) : ");
        string MyJob = Console.ReadLine();
        string _MyJob;
        string JobInfo;

        switch (MyJob)
        {
            case "1":
            case "Warrior":
            case "1.Warrior":
                _MyJob = "Warrior";
                Console.WriteLine($"{_MyJob}를 선택하였습니다.");
                Console.WriteLine("");
                JobInfo = "Strength(09) / Dexterity(06) / Wisdom(02)";
                break;

            case "2":
            case "Wizzard":
            case "2.Wizzard":
                _MyJob = "Wizzard";
                Console.WriteLine($"{_MyJob}를 선택하였습니다.");
                Console.WriteLine("");
                JobInfo = "Strength(03) / Dexterity(09) / Wisdom(09)";
                break;

            case "3":
            case "Archer":
            case "3.Archer":
                _MyJob = "Archer";
                Console.WriteLine($"{_MyJob}를 선택하였습니다.");
                Console.WriteLine("");
                JobInfo = "Strength(07) / Dexterity(03) / Wisdom(07)";
                break;

            default:
                Console.WriteLine("취소하겠습니다.");
                Console.WriteLine("--------------------------------------------------");
                ChooseJob();
                break;
        }
    }

    /// <summary>
    /// 적 등장
    /// </summary>
    static void EnemyAppear()
    {
        Console.WriteLine("적이 나타났습니다.");
        Console.WriteLine("적의 이름은 Villain. Warrior 입니다.");
        Console.WriteLine("");
        //Enemy enemy = new Enemy("Villain");
    }

    /// <summary>
    /// 상태 체크 메시지
    /// </summary>
    /*
    public void CheckPoint(Character target)
    {
        ///// 수정하기!!!!!!!!!!!!!!!!!!!!!!!!!
        for (int i = 1; i < 101; i++)
        {
            Console.WriteLine(i + "턴 시작 -------------------------------------------------- ");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ Name     ┃ {MyName}                           {MyJob}┃");
            Console.WriteLine($"┃ HP | MP  ┃ ({target.HP}/{target.maxHp})        |         ({target.MP}/{target.maxMp})┃");
            Console.WriteLine($"┃ Status   ┃ {target.JobInfo} ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");

            Console.WriteLine("");
            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃ Name     ┃ Villain                           Warrior ┃");
            Console.WriteLine($"┃ HP | MP  ┃ ({enemy.HP}/150)        |         ({enemy.MP}/150)┃");
            Console.WriteLine($"┃ Status   ┃ Strength(05) / Dexterity(06) / Wisdom(05) ┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
    */

    /// <summary>
    /// 게임 진행 코드
    /// </summary>
    static void GameStart()
    {
        string MyName = "";

        NameQues();
        EnemyAppear();

        Player player = new Player($"{MyName}");
        Enemy enemy = new Enemy("Villain");

        enemy.Attack(player);
        player.Avoidance(enemy);

        /*
        while (player.IsAlive && enemy.IsAlive)
        {
            player.Attack(enemy);

            if (enemy.IsAlive)
            {
                enemy.Attack(player);
            }
        }
        */
    }
}