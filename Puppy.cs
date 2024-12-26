using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20241226
{
    internal class Puppy
    {
        //屬性
        public int Id { get; set; }  //寵物的ID,編號
        public string Owner { get; set; }  //寵物主人的名字
        public string Description { get; set; } //關於這隻寵物的描述
        public string Gender { get; set; } //性別
        public string Variety { get; set; } //品種
        public int Age { get; set; }  //年紀

        private double _food; //伙食費
        public double Food
        {
            get { return this._food; }
            set { this._food = value; }
        }

        //建構子函式1
        public Puppy() { }

        //建構子函式2 
        public Puppy(int id, string vOwner, string description, string gender, string variety, int age, double food)
        {
            Id = id;
            Owner = vOwner;
            Description = description;
            Gender = gender;
            Variety = variety;
            Age = age;
            Food = food;

        }

        public void PrintAllAttrib()
        {
            Console.WriteLine("ID is:" + this.Id.ToString());
            Console.WriteLine("Owener is :" + this.Owner.ToString());
            Console.WriteLine("Description is :" + this.Description.ToString());
            Console.WriteLine("Gender is :" + this.Gender.ToString());
            Console.WriteLine("Variety is :" + this.Variety.ToString());
            Console.WriteLine("Age is :" + this.Age.ToString());
            Console.WriteLine("Food is :" + this.Food.ToString());
            //類推..把所有屬性印出來.

        }
    }
}
