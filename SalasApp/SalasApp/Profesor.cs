using System;
using System.Collections.Generic;
using System.Text;

namespace SalasApp
{
    public class Profesor : Usuario
    {
        
            
     
            public void HacerRecervap(Profesor profesor ,DateTime ingreso, DateTime salida, Bibliotecario bibliotecario)
            {
                Reservas reserva = new Reservas();
                reserva.Profesor = profesor;
                reserva.Ingreso = ingreso;
                reserva.Salida = salida;
                bibliotecario.ListaReservas.Add(reserva);

            }
     
        
    }
}
