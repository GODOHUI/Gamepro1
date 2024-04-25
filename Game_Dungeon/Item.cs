using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//d아이템 정보를 넣어놓고 인벤에 넣어주기
namespace Game_Dungeon
{
    internal class Item
    {
        public string nameid;
        public int price;
        public int att;
        public int def;
        public string desc;

        public bool Equip =false; //해제장착
       
        public Item(string nameID,int Price,int Att,int Def,string Desc)
        {
            nameid = nameID;
            price = Price;
            att = Att;  
            def = Def;
            desc = Desc;
           

        }

    }
}
