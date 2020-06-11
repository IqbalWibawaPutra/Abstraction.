using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class infromasi: MataKuliah
    {
        public override void Jadwal()
        {
            Console.WriteLine("INFORMASI CLASS ");
            Console.WriteLine("Contoh Belajar Animasi, Aplikasi Blender dst");
        }
    }
}
