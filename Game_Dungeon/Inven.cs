using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Dungeon
{//아이템들다루기
    internal class Inven
    {
        public static MainGame _startgame = new MainGame();
        List<Item> itemlist = new List<Item>();
        int selectnumber;





        public void SetInven()
        {
            itemlist.Add(new Item("무쇠갑옷", 1000, 0, 5, "무쇠로 만들어져 튼튼한 갑옷입니다"));
            itemlist.Add(new Item("스파르타의 창", 500, 7, 0, "스파르타의 전사들이 사용했다는 전설의 창입니다"));
            itemlist.Add(new Item("낡은 검", 300, 2, 0, "쉽게 볼 수 있는 낡은 검 입니다"));

        }

        public void invenlist()  
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("[아이템 목록]");
           // Console.WriteLine(itemlist.Count);  

            //아이템리스트안에있는걸 꺼내와야해서 for문돌리기
             //목록 구현한것 


            for (int i = 0; i < itemlist.Count; i++)
            {
              if (itemlist[i].Equip==true)
                { 
                Console.WriteLine($"[E]{i+1}. {itemlist[i].nameid} ,가격 :{itemlist[i].price}, 공격력 : {itemlist[i].att}, 방어력 : {itemlist[i].def},{itemlist[i].desc}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {itemlist[i].nameid} ,가격 :{itemlist[i].price}, 공격력 : {itemlist[i].att}, 방어력 : {itemlist[i].def},{itemlist[i].desc}");
                }
            }

            Console.WriteLine("0.나가기");
            Console.WriteLine("1.창착관리  ");

            string cho = Console.ReadLine();
            selectnumber=int.Parse( cho );  

            switch (cho)
            {
                case "0":
                    
                    //다시 처음창으로 돌아가야함...
                    break;
                case "1":
                    Console.WriteLine("1.장착관리  ");
                    Console.WriteLine( "장착할아이템을 골라주세요");
                  
                    selectnumber =int.Parse( Console.ReadLine());
                    Setitem();
                    this.invenlist();  // 루프시작 
                    //장착관리로 들어가야함
                    break;
                default:
                    Console.WriteLine("잘못입력했습니다");
                    //선택창 들어가기 
                    break;


            }
        }
        //장착하기
        public void Setitem()
        {
            itemlist[selectnumber - 1].Equip = true;
         


        }
        //빼는함수 
        public void _item() 
        {
            itemlist[selectnumber].Equip = false;
        }
    }
}
