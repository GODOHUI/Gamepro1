using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Game_Dungeon.MainGame;

namespace Game_Dungeon
{
    internal class Startper
    {//2번 구현
       // private static Startper _startper = new Startper(1, 10, 5, 100, 1500);
         public  Inven _inven ; 

        public int levl;
        public int fight;
        public int def;
        public int Gold;
        public int hpLV;

        //생성자 매개변수가 들어있는
        public Startper(int lvl, int _fight, int _def, int hpLv, int gold)
        {
            _inven = new Inven(); //플레이어가 생성될때 인벤토리가 만들어진다
            _inven.SetInven();
            levl = lvl;
            fight = _fight;
            def = _def;
            hpLV = hpLv;
            Gold = gold;

        }

        public void Viewsta() 
        {
            Console.WriteLine("[상태보기]");



            Console.WriteLine($"캐릭터의 정보가 표시됩니다.");
            Console.WriteLine($"Lv. {levl}");
            Console.WriteLine("전사");
            Console.WriteLine($"공격력 : {fight}");
            Console.WriteLine($"방어력 : {def}");
            Console.WriteLine($"체 력 : {hpLV}"); ;
            Console.WriteLine($"Gold : {Gold} ");
            Console.WriteLine(" ");
            Console.WriteLine("0. 나가기");
        }

    }
    }
