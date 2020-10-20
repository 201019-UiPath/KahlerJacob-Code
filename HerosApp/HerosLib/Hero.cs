using System;

namespace HerosLib
{
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
            this.id = newID;
            this.name = newName;
        }

        public string GetName(){
            return this.name;
        }

        public int GetId(){
            return this.id;
        }

        public void SetName(string n){
            name = n;
        }

        public void SetId(int i){
            id = i;
        }

    }
}
