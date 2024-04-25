using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static Game_Dungeon.MainGame;

namespace Game_Dungeon
{
    internal class MainGame
    {
        public static Startper _startper = new Startper(1, 10, 5, 100, 1500);
       // private static MainGame _startgame = new MainGame();
      // public static Inven inven = new Inven();
        static void Main(string[] args)
        {
            startGame();









        }

        public static void startGame()
        {
            //1번 구현
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\r\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine("1.상태보기  / 2.인벤토리 / 3.상점 ");
            Console.WriteLine("원하시는 행동을 입력해주세요 ");
            string cho = Console.ReadLine();

            switch (cho)
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    Console.WriteLine("1.상태보기 ");
                    Console.WriteLine("캐릭터의 정보가 표시됩니다 ");
                   // _startper.hpLV =10;
                    _startper.Viewsta();

                    break;
                case "2":
                    Console.WriteLine("2.인벤토리 ");
                    _startper._inven.invenlist();

                    break;
                case "3":
                    Console.WriteLine("3.상점");
                    break;


                default:
                    Console.WriteLine("잘못입력했습니다");

                    break;
            }
        }

     




    }


  
}
