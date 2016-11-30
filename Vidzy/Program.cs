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
            var vidzyContext = new VidzyEntities();

            vidzyContext.AddVideo("Rocky V", DateTime.Now, 2,(byte)Classification.Platinum);
            vidzyContext.SaveChanges();
        }
    }
}
