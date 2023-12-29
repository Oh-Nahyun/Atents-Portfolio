using System.Numerics;
using System.Security.Cryptography;
using static System.Formats.Asn1.AsnWriter;

namespace MyProject
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    public enum DayofWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }

    internal class MyCode_231229
    {
        static void Main(string[] args)
        {
            ///231229

            /// 231228 실습 코드 풀이 (+ 스킬 & 마나 사용)
            //Player player = new Player("주인공");
            //Enemy enemy = new Enemy("오크");

            //while (player.IsAlive && enemy.IsAlive)
            //{
            //    player.Attack(enemy);

            //    if (enemy.IsAlive)
            //    {
            //        enemy.Attack(player);
            //    }
            //}

            TestStatic.i = 20;
            TestStatic.Test2();

            TestStatic a = new TestStatic();
            a.Test1();

            TestStatic.i = 30;
            TestStatic.i = 40;
        }

        private static void Day_231226()
        {
            ///231226

            /// 출력
            Console.WriteLine("Hello, World!");
            Console.WriteLine("오나현");           // 한 줄 출력 코드
            Console.Write("dkdkdk");              // 글자 출력 코드
            Console.Write("대대대\n아아아\n");     // 엔터

            /// 입력
            /// 변수 (Variable) : 변하는 숫자, 메모리에 기록해둔 값
            /// 변수를 사용하려면 미리 선언해야 한다.
            /// 변수를 선언할 때는 데이터 타입과 이름을 명시해야 한다.
            /// 키보드 입력을 한 줄 받아서 input이라는 변수에 기록하기
            string input;                         // string 타입의 변수를 input이라는 이름으로 선언
            input = Console.ReadLine();
            Console.WriteLine(input);             // input 변수의 내용 출력


            /// 실습
            /// 시작하면 이름을 물어보고 이름을 3번 출력하는 코드 만들기
            Console.Write("당신의 이름은 무엇입니까? : ");
            string MyName = Console.ReadLine();
            Console.WriteLine(MyName);
            Console.WriteLine(MyName);
            Console.WriteLine(MyName);
        }

        private static void Day_231227()
        {
            ///231227

            /// 데이터 타입
            /// string : 문자열. 글자들을 저장하기 위한 데이터 타입
            /// int : 인티저. 정수형. 소수점 없는 숫자를 저장하기 위한 데이터 타입 (32bit), +-21억까지는 안전.
            /// float : 플로트. 실수형. 소수점 있는 숫자를 저장하기 위한 데이터 타입 (32bit), 태생적으로 오차가 있다.
            /// bool : 불. true 아니면 false만 저장하는 데이터 타입

            /// 함수 (Function)
            /// 특정 기능을 수행하는 코드 뭉치
            /// 구성요소 : 리턴타입, 이름, 파라메터(매개변수), 함수바디(코드)
            InputName(); // 이름을 입력받고 출력하는 함수


            /// 실습
            /// 함수 만들기 (7~42번 라인까지를 수행하는 함수 만들기)
            /// 이름 : Day_231226
            Day_231226();


            /// 대입 연산자
            int i; // 정수 타입의 변수 i를 선언
            i = 10; // i에 10을 대입한다. (같다는 의미가 아니다.) (= 은 대입 연산자)
            bool b = (i == 10); // i와 10을 비교한 후, 같으면 b에 true를 대입하고, 다르면 false를 대입한다. (== 은 비교 연산자)

            /// 산술 연산자
            int j;
            j = i + 10; // j는 20 (+ - * / 는 산술 연산자)

            /// 비교 연산자
            // i > j;
            // i >= j;
            // i < j;
            // i <= j;

            float f;
            f = j + 10; // int 데이터를 float에 넣는 것은 가능
            // i = f; // float 데이터를 int에 넣는 것은 불가능

            string str1 = "Hello ";
            string str2 = "World";
            string str3 = str1 + str2; // str3 = "Hello World"

            bool b2 = (str1 == "Hello "); // true
            bool b3 = (str1 == "HellO "); // false
            // 문자열간의 비교는 피할 수 있으면 무조건 피하는 것이 이득이다.

            // 불가피하게 사용해야하는 경우, 아래 코드 참고
            string.Format("{0} {1}", str1, str2);
            string str4 = $"{str1} {str2}";

            string str5 = str1 + str2 + str1 + str2;
            // 최악의 경우. 쓸대 없는 임시공간이 2개 더 발생 (4개)

            Console.WriteLine($"str5 = {str5}");
            Console.Write($"{str1}{str2}");

            /// 제어문 : 코드의 흐름을 제어하는 코드

            /// 예시 1
            /// 20살 미만이면 미성년자입니다.
            /// 20살 이상이면 성인입니다.

            /// 조건문 : 제어문 중의 하나로 특정 조건에 따라 다른 코드를 실행하는 코드
            int age1 = 20;
            if (age1 < 20)
                Console.WriteLine($"{age1}살은 미성년자입니다.");
            else
                Console.WriteLine($"{age1}살은 성인입니다.");

            int age2 = 15;
            if (age2 < 8)
                Console.WriteLine($"{age2}살은 미취학아동입니다.");
            else if (age2 < 14)
                Console.WriteLine($"{age2}살은 초등학생입니다.");
            else if (age2 < 17)
                Console.WriteLine($"{age2}살은 중학생입니다.");
            else if (age2 < 20)
                Console.WriteLine($"{age2}살은 고등학생입니다.");

            int age;
            Console.Write("몇 살인가요? : ");
            string inputAge = Console.ReadLine();
            //age = int.Parse(inputAge); // inputAge에 들어있는 글자를 int 타입으로 변경하는 코드
            int.TryParse(inputAge, out age);
            AgeCheck(age);

            /// 점수 관련 함수 만들기
            float score;
            Console.Write("몇 점인가요? : ");
            string inputScore = Console.ReadLine();
            float.TryParse(inputScore, out score);
            GradeCheck(score);

            //float score;
            Console.Write("몇 점인가요? : ");
            //string inputScore = Console.ReadLine();
            float.TryParse(inputScore, out score);
            Grade grade = GradeCheck(score); // GradeCheck 함수의 결과를 grade에 대입

            Console.WriteLine($"당신의 등급은 [{grade}]입니다.");
            switch (grade)
            {
                case Grade.A:
                    Console.WriteLine("A등급은 ~한 혜택이 있습니다.");
                    break;
                case Grade.B:
                    Console.WriteLine("B등급은 ~한 혜택이 있습니다.");
                    break;
                case Grade.C:
                    Console.WriteLine("C등급은 ~한 혜택이 있습니다.");
                    break;
                case Grade.D:
                    Console.WriteLine("D등급은 ~한 혜택이 있습니다.");
                    break;
                case Grade.F:
                    Console.WriteLine("F등급은 혜택이 없습니다.");
                    break;
                default:
                    Console.WriteLine("아무 등급도 아닙니다.");
                    break;
            }

            /// 반복문 : 코드를 반복하는 코드

            // int temp2 = 0;
            // temp2 = temp2 + 1; // temp2++; // 둘 다 같은 코드

            //for (int temp = 0; temp < 10; temp++) // (초기화; 종료조건; 증가량)
            //{
            //}

            /// 구구단 함수 만들기
            Console.Write("구구단 몇 단을 출력할까요? : ");
            int.TryParse(Console.ReadLine(), out int dan);
            Gugudan(dan);

            /// while문 : () 사이의 조건이 참이면 반복하는 코드
            //while()
            //{
            //}

            int count = 0;
            while (count < 10)
            {
                count++;
            }

            /// do-while문 : 일단 한 번 실행하고 () 사이의 조건이 참이면 반복하는 코드
            //int count = 0;
            do
            {
                count++;
            } while (count < 10);

            /// 대입 연산자
            /// = : = 왼쪽에 있는 변수에 = 오른쪽에 있는 값을 대입한다.

            /// 산술 연산자
            /// +
            /// -
            /// *
            /// /
            /// ++
            /// --
            /// += : 왼쪽에 있는 변수에 오른쪽에 있는 값을 더해서 왼쪽에 있는 변수에 대입한다.
            /// ( i += 10, i에 10을 더한 후 i에 대입  )
            /// -=
            /// *=
            /// /=
            /// % : 나머지 연산 ( i = 10 % 3, i에는 1이 들어간다. )

            /// 비교 연산자
            /// == : 양쪽이 같으면 true, 다르면 false
            /// != : 양쪽이 다르면 true, 같으면 false
            /// >
            /// <
            /// >=
            /// <=

            /// 논리 연산자 (결과는 무조건 bool 타입)
            /// && : 앤드(and), 양쪽이 모두 true일때만 true ( bool result = true && false; 결과는 false )
            /// || : 오어(or), 양쪽이 모두 false일때만 false ( bool result = true || false; 결과는 true )

            Random r = new Random();
            int dice = r.Next(5) + 1; // dice에는 1~6이 들어간다.

            /// 실습
            /// 주사위 게임 만들기
            /// 1. High / Low 게임 만들기
            ///     1.1. 시작하면 High와 Low 중 하나를 입력받음
            ///     1.2. 주사위를 굴려서 1~3이면 Low, 4~6이면 High를 출력한다.
            ///     1.3. 플레이어의 선택이 맞으면 성공으로 한 후 1.1로 돌아가 다시 시작한다.
            ///     1.4. 플레이어의 선택이 틀리면 이때까지 몇 번 성공했는지 출력하고 종료한다.
            string choose1 = "";
            MyHighLow(choose1);

            /// 2. 홀짝 게임 만들기
            ///     2.1. 시작하면 홀짝 중 하나를 입력받음
            ///     2.2. 주사위를 굴려서 홀이면 "홀", 짝이면 "짝"를 출력한다.
            ///     2.3. 플레이어의 선택이 맞으면 성공으로 한 후 2.1로 돌아가 다시 시작한다.
            ///     2.4. 플레이어의 선택이 틀리면 이때까지 몇 번 성공했는지 출력하고 종료한다.
            string choose2 = "";
            MyOddEven(choose2);
        }

        static void InputName()
        {
            /// 리턴타입 : void
            /// 이름 : InputName
            /// 파라메터 : 생략됨. () 안에 있는 변수
            /// 함수바디 : {} 사이에 있는 코드

            Console.Write("당신의 이름은 무엇입니까? : ");
            string MyName = Console.ReadLine();
            Console.WriteLine(MyName);
        }

        /// <summary>
        /// 나이를 확인해서 어떤 학교에 다니는지 출력하는 함수
        /// </summary>
        /// <param name="age">입력받은 나이</param>
        static void AgeCheck(int age)
        {
            if (age < 8)
                Console.WriteLine($"{age}살은 미취학아동입니다.");
            else if (age < 14)
                Console.WriteLine($"{age}살은 초등학생입니다.");
            else if (age < 17)
                Console.WriteLine($"{age}살은 중학생입니다.");
            else if (age < 20)
                Console.WriteLine($"{age}살은 고등학생입니다.");
        }

        private static void Day_231228()
        {
            ///231228

            /// 231227 실습 코드 풀이
            //RunHighLowDice();
            //RunOddEvenDice();

            /// 객체 (or 오브젝트)
            //Character my = new Character(); // 메모리를 할당하여 클래스를 생성(인스턴스화) 했다.
            //my.Skill();
            //Character enemyTemp = new Character("적");
            //enemyTemp.Skill();

            //Player player = new Player("나");
            ////player.Skill();

            //Enemy enemy = new Enemy("적");
            ////enemy.Skill();

            //player.Attack(enemy);

            //Character test = new Player(); // 자식클래스의 인스턴스는 부모타입의 변수에 저장할 수 있다.
            //test.Skill();

            //Character test2 = new Player();
            //test2.Attack();

            //float f = my.HP; // 읽기
            //my.HP = 100; // 쓰기


            /// 실습
            /// 적과 나 중에 한 명이 죽을 때까지 한 번씩 공격하기
            /// 죽을 때, 누가 죽었는지 출력이 되어야 한다.
            /// 한 명이 죽으면 프로그램 종료
            Player player = new Player("나");
            Enemy enemy = new Enemy("적");

            Console.WriteLine("<< Game Start >>");
            Console.WriteLine("");

            Console.Write("누가 공격할까요? (나(1), 적(2)) : ");
            string myName = Console.ReadLine();
            int.TryParse(myName, out int go);
            Console.WriteLine("");

            if (go == 1)
            {
                while (true)
                {
                    Console.WriteLine("----------------------------------------");
                    player.Attack(enemy);
                    Console.WriteLine("----------------------------------------");
                    enemy.Attack(player);

                    if (enemy.HP <= 0)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("[나] WIN!!!!!");
                        enemy.Die();
                        break;
                    }
                }
            }

            else if (go == 2)
            {
                while (true)
                {
                    Console.WriteLine("----------------------------------------");
                    enemy.Attack(player);
                    Console.WriteLine("----------------------------------------");
                    player.Attack(enemy);

                    if (player.HP <= 0)
                    {
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("");
                        Console.WriteLine("[적] WIN!!!!!");
                        player.Die();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// 점수를 받아서 A~F까지 성적을 출력하는 함수
        /// </summary>
        /// <param name="score">점수</param>
        //static void GradeCheck(float score)
        //{
        //    // 90점 이상은 A
        //    if (score > 89)
        //        Console.WriteLine($"{score}점은 A입니다.");
        //    // 80점 이상은 B
        //    else if (score > 79)
        //        Console.WriteLine($"{score}점은 B입니다.");
        //    // 70점 이상은 C
        //    else if (score > 69)
        //        Console.WriteLine($"{score}점은 C입니다.");
        //    // 60점 이상은 D
        //    else if (score > 59)
        //        Console.WriteLine($"{score}점은 D입니다.");
        //    // 60점 미만은 F
        //    else
        //        Console.WriteLine($"{score}점은 F입니다.");
        //}
        static Grade GradeCheck(float score)
        {
            Grade grade = Grade.F;
            // 90점 이상은 A
            if (score > 89)
            {
                Console.WriteLine("A등급입니다.");
                grade = Grade.A;

                // return Grade.A;
            }
            // 80점 이상은 B
            else if (score > 79)
            {
                Console.WriteLine("B등급입니다.");
                grade = Grade.A;
            }
            // 70점 이상은 C
            else if (score > 69)
            {
                Console.WriteLine("C등급입니다.");
                grade = Grade.A;
            }
            // 60점 이상은 D
            else if (score > 59)
            {
                Console.WriteLine("D등급입니다.");
                grade = Grade.A;
            }
            // 60점 미만은 F
            else
                Console.WriteLine("F등급입니다.");

            return grade;
        }

        /// <summary>
        /// 구구단을 출력하는 함수
        /// </summary>
        /// <param name="dan">출력할 단 수</param>
        static void Gugudan(int dan)
        {
            Console.WriteLine($"구구단 {dan}단 출력하기");
            for (int i = 1; i < 10; i++)
            {
                int ans = dan * i;
                Console.WriteLine($"{dan} x {i} = {ans}");
            }
        }

        /// <summary>
        /// My Game 1
        /// </summary>
        /// <param name="choose"></param>
        static void MyHighLow(string choose)
        {
            int score = 0;
            while (true)
            {
                Console.Write("High와 Low 중 하나를 선택하시오. : ");
                choose = Console.ReadLine();

                Random r = new Random();
                int dice = r.Next(5) + 1; // dice에는 1~6이 들어간다.

                if (dice > 0 && dice < 4)
                {
                    Console.WriteLine("Low");
                    if (choose == "Low" || choose == "low")
                        score = score + 1;
                    else
                    {
                        Console.WriteLine($"플레이어의 점수 : {score}");
                        break;
                    }
                }
                else if (dice > 3 && dice < 7)
                {
                    Console.WriteLine("High");
                    if (choose == "High" || choose == "high")
                        score = score + 1;
                    else
                    {
                        Console.WriteLine($"플레이어의 점수 : {score}");
                        break;
                    }
                }
            }
        }

        static void RunHighLowDice()
        {
            /// 실습
            /// 주사위 게임 만들기
            /// 1. High / Low 게임 만들기
            ///     1.1. 시작하면 High와 Low 중 하나를 입력받음
            ///     1.2. 주사위를 굴려서 1~3이면 Low, 4~6이면 High를 출력한다.
            ///     1.3. 플레이어의 선택이 맞으면 성공으로 한 후 1.1로 돌아가 다시 시작한다.
            ///     1.4. 플레이어의 선택이 틀리면 이때까지 몇 번 성공했는지 출력하고 종료한다.

            Console.WriteLine("주사위 게임 - High Low");
            Console.WriteLine("게임을 시작합니다.");

            int winCount = 0;
            int select = 0;

            bool isLose = false;
            while (!isLose)
            {
                // 입력 받기 ------------------------------------------------------------
                /// 방법 1
                /// 1 또는 2가 입력 될 때까지 반복하기
                //do
                //{
                //    Console.Write("High와 Low 중 하나를 선택해주세요(1-High, 2-Low) : ");
                //    string temp = Console.ReadLine();
                //    int.TryParse(temp, out select);
                //} while (select != 1 && select != 2);

                /// 방법 2
                /// 1 또는 2가 들어오면 break를 이용해 while 끝내기
                //while (true)
                //{
                //    Console.Write("High와 Low 중 하나를 선택해주세요(1-High, 2-Low) : ");
                //    string temp = Console.ReadLine();
                //    int.TryParse(temp, out select);

                //    if(select == 1 && select == 2)
                //    {
                //        break;
                //    }
                // 잘못된 입력이 있을 경우, 경고 표시
                //    Console.WriteLine("잘못된 입력입니다. 1 또는 2를 입력해주세요.");
                //}

                /// 방법 3
                /// 성공적으로 입력을 받았는지 표시하는 변수
                bool isSuccess = false;
                while (!isSuccess) // while (isSuccess == false)
                {
                    Console.Write("High와 Low 중 하나를 선택해주세요(1-High, 2-Low) : ");
                    string temp = Console.ReadLine();
                    int.TryParse(temp, out select);

                    if (select == 1 || select == 2)
                    {
                        isSuccess = true; // 정상적으로 입력이 되었으면 성공이라고 표시
                    }
                }

                bool isSelectHigh;
                switch (select)
                {
                    case 1:
                        Console.WriteLine("당신의 선택은 High!");
                        isSelectHigh = true;
                        break;
                    case 2:
                        Console.WriteLine("당신의 선택은 Low!");
                        isSelectHigh = false;
                        break;
                    default:
                        Console.WriteLine("ERROR!!!!! 있을 수 없는 선택입니다.");
                        isSelectHigh = false;
                        break;
                }
                // Console.WriteLine($"Select : {select}");

                // 주사위 굴리기 ------------------------------------------------------------
                Random r = new Random();
                int dice = r.Next(5) + 1;

                /// 방법 1
                //bool isDiceHigh = false;
                //if (dice > 3)
                //{
                //    isDiceHigh = true;
                //}

                /// 방법 2
                bool isDiceHigh = (dice > 3) ? true : false; // 3항 연산자를 사용했을 때.
                                                             // (조건) ? 조건이 참일때의 값 : 조건ㅇㅣ 거짓일 때의 값

                Console.WriteLine($"주사위 값은 {dice}가 나왔습니다.");
                if (isDiceHigh)
                {
                    Console.WriteLine("주사위 결과는 High!");
                }
                else
                {
                    Console.WriteLine("주사위 결과는 Low!");
                }

                // 승패 확인하기 ------------------------------------------------------------
                if (isSelectHigh == isDiceHigh)
                {
                    Console.WriteLine("당신의 승리!");
                    winCount++;
                }
                else
                {
                    Console.WriteLine("당신의 패배!");
                    Console.WriteLine($"당신은 이때까지 {winCount}연승 했었습니다.");
                    isLose = true;
                }

                //string a = "High";
                //a = a.ToLower(); // 모든 영어를 소문자로 만들기
                //a = a.ToUpper(); // 모든 영어를 대문자로 만들기
            }
        }

        /// <summary>
        /// My Game 2
        /// </summary>
        /// <param name="choose"></param>
        static void MyOddEven(string choose)
        {
            int score = 0;
            while (true)
            {
                Console.Write("Odd와 Even 중 하나를 선택하시오. : ");
                choose = Console.ReadLine();

                Random r = new Random();
                int dice = r.Next(5) + 1; // dice에는 1~6이 들어간다.

                if (dice % 2 == 1)
                {
                    Console.WriteLine("Odd");
                    if (choose == "Odd" || choose == "odd")
                        score = score + 1;
                    else
                    {
                        Console.WriteLine($"플레이어의 점수 : {score}");
                        break;
                    }
                }
                else if (dice % 2 == 0)
                {
                    Console.WriteLine("Even");
                    if (choose == "Even" || choose == "even")
                        score = score + 1;
                    else
                    {
                        Console.WriteLine($"플레이어의 점수 : {score}");
                        break;
                    }
                }
            }
        }

        static void RunOddEvenDice()
        {
            /// 2. 홀짝 게임 만들기
            ///     2.1. 시작하면 홀짝 중 하나를 입력받음
            ///     2.2. 주사위를 굴려서 홀이면 "홀", 짝이면 "짝"를 출력한다.
            ///     2.3. 플레이어의 선택이 맞으면 성공으로 한 후 2.1로 돌아가 다시 시작한다.
            ///     2.4. 플레이어의 선택이 틀리면 이때까지 몇 번 성공했는지 출력하고 종료한다.

            Console.WriteLine("주사위 게임 - Odd Even");
            Console.WriteLine("게임을 시작합니다.");

            int winCount = 0;
            int select = 0;

            bool isLose = false;
            while (!isLose)
            {
                // 입력 받기 ------------------------------------------------------------
                bool isSuccess = false;
                while (!isSuccess) // while (isSuccess == false)
                {
                    Console.Write("Odd와 Even 중 하나를 선택해주세요(1-Odd, 2-Even) : ");
                    string temp = Console.ReadLine();
                    int.TryParse(temp, out select);

                    if (select == 1 || select == 2)
                    {
                        isSuccess = true; // 정상적으로 입력이 되었으면 성공이라고 표시
                    }
                }

                bool isSelectOdd; // 홀짝 기록하기
                switch (select)
                {
                    case 1:
                        Console.WriteLine("당신의 선택은 Odd!");
                        isSelectOdd = true;
                        break;
                    case 2:
                        Console.WriteLine("당신의 선택은 Even!");
                        isSelectOdd = false;
                        break;
                    default:
                        Console.WriteLine("ERROR!!!!! 있을 수 없는 선택입니다.");
                        isSelectOdd = false;
                        break;
                }

                // 주사위 굴리기 ------------------------------------------------------------
                Random r = new Random();
                int dice = r.Next(5) + 1;

                bool isDiceOdd = ((dice % 2) == 1) ? true : false; // (조건) ? 조건이 참일때의 값 : 조건ㅇㅣ 거짓일 때의 값

                Console.WriteLine($"주사위 값은 {dice}가 나왔습니다.");
                if (isDiceOdd)
                {
                    Console.WriteLine("주사위 결과는 Odd!");
                }
                else
                {
                    Console.WriteLine("주사위 결과는 Even!");
                }

                // 승패 확인하기 ------------------------------------------------------------
                if (isSelectOdd == isDiceOdd)
                {
                    Console.WriteLine("당신의 승리!");
                    winCount++;
                }
                else
                {
                    Console.WriteLine("당신의 패배!");
                    Console.WriteLine($"당신은 이때까지 {winCount}연승 했었습니다.");
                    isLose = true;
                }
            }
        }
    }
}
