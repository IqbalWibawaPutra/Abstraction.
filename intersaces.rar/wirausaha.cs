using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Wirausaha : IMataKuliah
    {
        public void Jadwal()
        {
            Console.WriteLine("Mata kuliah yang fokus pada bidang bisnis");
            Console.WriteLine("Contoh pembelajaran dengan cara praktek terjun");
        }
    }
}