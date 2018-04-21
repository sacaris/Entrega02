using System;
using System.Collections.Generic;
using System.Text;


namespace SalasApp
{
    public class Estudiante : Usuario
    {
        public string Estado { get; set; }
        public int Puntaje { get; set; }
        
        
        private void VerEstado()//metodo que permite que el estudiante ver su estado, que significaría ver si puede reservar salas o no
        {
            Console.WriteLine(Estado);

        }
        private void VerPuntaje()
        {
            Console.WriteLine(Puntaje);
        }
        public void HacerRecerva( List<Estudiante> grupo,DateTime ingreso, DateTime salida,Bibliotecario bibliotecario)
        {
            Reservas reserva = new Reservas();
            reserva.Grupo = grupo;
            reserva.Ingreso = ingreso;
            reserva.Salida = salida;
            bibliotecario.ListaReservas.Add(reserva);

        }

    }
    
}
    