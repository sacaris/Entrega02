using System;
using System.Collections.Generic;
using System.Text;

namespace SalasApp
{
    public class Bibliotecario : Usuario
    {
       public string Horario { get; set; } //horario de trabajo bibliotecario.
       public List<Reservas> ListaReservas;

        private void VerReservas()
        {
            Console.WriteLine(ListaReservas);
        }
        private void Castigar(Estudiante estudiante)
        {
            estudiante.Estado = "castigado";
            estudiante.Puntaje = estudiante.Puntaje -1;
            
        }
        private void Descastigar(Estudiante estudiante)
        {
            estudiante.Estado = "disponible";
        }
        private void SubirPuntaje(Estudiante estudiante)
        {
            estudiante.Puntaje = estudiante.Puntaje + 1;
        }

        public void AceptarReserva(ReservasAceptadas reservasAceptadas,Reservas reserva)
        {
            reservasAceptadas.ResAceptadas.Add(reserva);
           

        }

    }
}
