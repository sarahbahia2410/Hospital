using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Funcionário : Pessoa
    {
        public int AnoDeAdmissão { get; protected set; }
        public double SALÁRIO { get; protected set; }
        public string codigo { get; protected set; }

        public virtual void GanharSalario()
        {
            Console.WriteLine(SALÁRIO);
        }
        public void Codigo()
        {
            if (codigo == "")
            
                Console.WriteLine("Código não identificado, a polícia será acionada em 10 segundos");
            
            else if (codigo.Length > 11)
            
                Console.WriteLine("O código não deve ser maior que 11 caracteres");

            
            else
                Console.WriteLine(codigo);

        }
    }
}
