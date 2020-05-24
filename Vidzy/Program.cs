using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            using (VidzyEntities context = new VidzyEntities())
            {
                context.AddVideo("Lucy", DateTime.Now.AddYears(-3), "Thriller",(byte)Classification.Gold);
                context.AddVideo("Bahubali 2", DateTime.Now.AddYears(-5), "Action",(byte)Classification.Platinum);
                
            }
        }
    }
}
