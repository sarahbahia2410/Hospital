using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Enfermeiro : Funcionário
    {
        public string InstrumentoCirúrgico { get; protected set; }
        public bool BULLYING { get;  set; }

        
        public override void Vestir()
        {
            base.Vestir();
            Console.WriteLine("O enfermeiro usa jaleco bege");
        }
        public override void GanharSalario()
        {
            SALÁRIO = 3.092;
        }
        public void ExílioEstatal()
        {
            if (BULLYING == true)
                Console.WriteLine("Indivíduo Deportado");
  
        }
    }
}
