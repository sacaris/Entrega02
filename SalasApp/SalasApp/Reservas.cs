using System;
using System.Collections.Generic;
using System.Text;

namespace SalasApp
{
    public class Reservas
    {
        public List<Estudiante> Grupo; //corresponde al grupo de personas que integrará la reserva, valido solo para reservas de estudiantes
        public DateTime Ingreso { get; set; } // hora de ingreso a la sala
        public DateTime Salida { get; set; } //hora de salida de la sala
        public Profesor Profesor { get; set; }
    }
}
