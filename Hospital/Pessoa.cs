using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Pessoa
    {
        public string NOME { get; protected set; }
        public int IDADE { get; protected set; }
        public bool VIVO { get; protected set; }
        public double PESO { get; protected set; }
        public double ALTURA { get; protected set; }

        public void Sorrir ()
        {

        }
        public void Viver ()
        {

        }
        public void Morrer ()
        {
            VIVO = false;
            Console.WriteLine("O individuo foi procurar pão alto demais!");
        }
        public virtual void Vestir ()
        {
            Console.WriteLine("Roupas intimas vestidas");

        }
       
    }
}
