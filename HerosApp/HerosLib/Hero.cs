using System;

namespace HerosLib
{
    /*
    public class Hero
    {
        internal int id;
        
        internal string name;


      
        public Hero(){
            id = 1;
            name = "Don Quixote";

        }
       
        public Hero(int newID, string newName)
        {
            id = newID;
            name = newName;
        }

      public int Id{get;set;}

      public string Name{get;set;}


    }
    */

    public class Hero{
        public int Id { get; set; }

        public string Name { get; set; }

        public string[] superPowers = new string[10];

        public int[][] ja=new int[3][];
      

        
    }
    
}
