using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierachy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Interface Hierachy");
            //call from object level
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 100, 150);
            myBitmap.DrawUpSideDown();

            //get IAdvancedDraw explicitly
            IAdvancedDraw IAdvDraw = myBitmap as IAdvancedDraw;
            if (IAdvDraw != null)
            {
                IAdvDraw.DrawUpSideDown();
            }
            Console.ReadLine();

        }


        
    }
}
