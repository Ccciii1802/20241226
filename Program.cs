using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _20241226
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Puppy MyPuppy = new Puppy();
            //設定MyPuppy的屬性值.
            MyPuppy.Id = 1;
            MyPuppy.Owner = "Albee";
            MyPuppy.Description ="cute";
            MyPuppy.Gender = "famale";
            MyPuppy.Variety = "薩摩耶";
            MyPuppy.Age = 3;
            MyPuppy.Food = 45000;
            //類堆..所有屬性都要設.

            //最後,叫用MyPuppy的方法PrintAllAttrib( )印出所有屬性參數.
            MyPuppy.PrintAllAttrib();

            //===============================================
            //第二個 使用有參數的建構子設一隻寵物MickeyPuppy.
            //經由建構子函式2 來設定所有屬性
            Puppy MickeyPuppy = new Puppy(2, "Mickey", "8787", "female", "馬爾濟斯", 11, 50000);

            //最後,叫用 MickeyPuppy的方法PrintAllAttrib( )印出所有屬性參數.
            MickeyPuppy.PrintAllAttrib();
        }
    }
}
