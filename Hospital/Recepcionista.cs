using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Recepcionista : Funcionário
    {
        public int DDD { get; protected set; }
        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("O recepcionista usa boina");
        }
        public override void GanharSalario()
        {
            SALÁRIO = 998.00;
        }
    }
}
