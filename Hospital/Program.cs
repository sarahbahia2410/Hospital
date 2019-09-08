using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Médico Archaman = new Médico();
            Archaman.Codigo(45999999999555);
            Archaman.GanharSalario();
            Archaman.Vestir();

            Enfermeiro Nurse = new Enfermeiro();
            Nurse.Vestir();
            Nurse.GanharSalario();
            Nurse.ExílioEstatal(false);

            Enfermeiro BadNurse = new Enfermeiro();
            BadNurse.Vestir();
            BadNurse.GanharSalario();
            BadNurse.ExílioEstatal(true);

            Recepcionista xuliana = new Recepcionista();
            xuliana.Vestir();
            xuliana.GanharSalario();



        }
    }
}
