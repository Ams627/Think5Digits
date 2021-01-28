using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace Think5Digits
{
    class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var rlist = new List<int>();
                for (int i = 11111; i <= 88888; i++)
                {
                    var up = i + 11111;
                    var down = i - 11111;

                    var d0 = i % 10;
                    var d1 = (i / 10) % 10;
                    var d2 = (i / 100) % 10;
                    var d3 = (i / 1000) % 10;
                    var d4 = (i / 10000) % 10;

                    if (up % 3 == 0 && down % 4 == 0 && d0 < d1 && d1 < d2 && d2 < d3 && d3 < d4)
                    {
                        rlist.Add(i);
                    }
                }

                foreach (var entry in rlist)
                {
                    Console.WriteLine($"{entry}");
                }
            }
            catch (Exception ex)
            {
                var fullname = System.Reflection.Assembly.GetEntryAssembly().Location;
                var progname = Path.GetFileNameWithoutExtension(fullname);
                Console.Error.WriteLine($"{progname} Error: {ex.Message}");
            }

        }
    }
}
