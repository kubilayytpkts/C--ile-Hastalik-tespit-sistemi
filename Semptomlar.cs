using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Semptomlar
    {
        public string Hastalıkbelirtileri { get; set; }
        public override string ToString()
        {
            return Hastalıkbelirtileri;
        }

    }
}
