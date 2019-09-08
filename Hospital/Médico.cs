using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Médico : Funcionário
    {
        public int SalaPropria { get; protected set; }
        public string MusicaSIA { get; protected set; }

        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("O médico usa jaleco branco");
        }
        public override void GanharSalario()
        {
            SALÁRIO = 10.780;
        }
    }
}
