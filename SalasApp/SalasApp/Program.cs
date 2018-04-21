using System;
using System.Collections.Generic;

namespace SalasApp
{
    class Program
    {
        public static List<Usuario> usuarios;
        public static Usuario loggedIn;
        static void Main(string[] args)
        {
            var I = "a";//al definir "I" con un string cualquiera (en este caso con la letra "a") que no sea "salir" o "Salir" ésta ingresa al programa, el str I puede cambiar mas adelante
            while (I != "Salir" && I != "salir")//loop infinito hasta que I sea "salir" o "Salir"
            {
                usuarios = new List<Usuario>();
                Console.WriteLine("Ingreso o Registro o Salir:");
                //I sería la variable que almacena si la persona está ingresando o registrandose o salir del programa.
                I = Console.ReadLine();//variable string I puede ser o ingreso o registro o salir del programa
                while (I != "Ingreso" && I != "ingreso" && I != "registro" && I != "Registro" && I != "Salir" && I != "salir")
                {
                    Console.WriteLine("Lo ingresado no es válido \nIngreso o Registro o Salir: ");
                    // Loop infinito hasta que el usuario ingrese lo correspondiente
                    I = Console.ReadLine();//variable string I puede ser o ingreso o registro o salir
                }
                    if (I == "Ingreso" || I == "ingreso")
                    {
                        Console.WriteLine("Ingrese su nombre ");
                        String name = Console.ReadLine();
                        Console.WriteLine("Ingrese su clave: ");
                        String clave = Console.ReadLine();
                        int asd = 2; // Este numero entero cambiará mas adelante si es que el usuario ingresó correctamente su nombre y contraseña
                        //si asd sigue manteniendo su valor que en este caso es 2, quiere decir que lo ingresado no permite acceso
                        //si asd cambia su valor a 0 quiere decir que el usuario ingresó exitosamente, de este modo asd no entra a if (asd==2)
                        for (int i = 0; i < usuarios.Count; i++)
                        {

                            if (usuarios[i].Nombre == name && usuarios[i].Contraseña == clave)
                            {
                                asd = 0;//como los datos coinciden y se accederá al menú, el valor de asd cambia de 2 a 0 para evitar que aparezca en pantalla el mensaje de que no se permite acceso
                                loggedIn = usuarios[i];
                                Console.Clear();
                                break;
                            }
                        }
                        if (asd == 2)//si asd sigue teniendo el valor 2 quiere decir que los datos ingresados no corresponden a los de un usuario, por lo que no se permite el acceso
                        {
                            Console.WriteLine("Los valores ingresados no permiten acceso");
                        }
                        if (asd == 0)//si los datos ingresados coinciden, se entratá al menú ya que el valor de asd cambia de 2 a 0
                        {
                            if (loggedIn.GetType() == typeof(Profesor)) //Menú para los profesores
                            {
                                var mm = "a";//al definir "mm" con un string cualquiera (en este caso con la letra "a") éste entra en el ciclo while hasta que se le asigne el valor "salir" o "Salir"
                                while (mm!="salir" && mm!="Salir")
                                {
                                    Console.WriteLine("Bienvenido \nSi desea hacer ua reserva escriba reserva \nSi desea salir escriba salir: ");
                                    mm = Console.ReadLine();
                                    if (mm=="reserva" || mm=="Reserva")
                                    {   
                                                
                                        


                                        



                                    }
                                    if (mm!="reserva" && mm != "Reserva" && mm != "salir" && mm != "Salir" )
                                    {
                                        Console.WriteLine("Lo ingresado no es válido");
                                    }





                                }
                            }
                            if (loggedIn.GetType() == typeof(Estudiante)) //Menú para los estudiantes
                            {
                                var ee = "a";//al definir "ee" con un string cualquiera (en este caso con la letra "a") éste entra en el ciclo while hasta que se le asigne el valor "salir" o "Salir"
                                while (ee != "salir" && ee != "Salir")
                                {
                                    Console.WriteLine("Bienvenido \nSi desea hacer una reserva escriba reserva \nSi desea ver su puntaje escriba puntaje \nSi desea ver su estado escriba estado\n: ");
                                    ee = Console.ReadLine();
                                    if (ee=="reserva" || ee=="Reserva")
                                    {

                                    }
                                    if (ee == "puntaje" || ee == "Puntaje")
                                    {

                                    }
                                    if (ee == "estado" || ee == "Estado")
                                    {

                                    }
                                    if (ee!="estado" && ee!="Estado" && ee!="reserva" && ee != "Reserva" && ee != "puntaje" && ee != "Puntaje" && ee != "salir" && ee != "Salir")
                                    {
                                        Console.WriteLine("Lo ingresado no es válido");
                                    }




                                }
                            }
                            if (loggedIn.GetType() == typeof(Bibliotecario)) //Menú para los bibliotecarios
                            {
                                var kk = "a";//al definir "kk" con un string cualquiera (en este caso con la letra "a") éste entra en el ciclo while hasta que se le asigne el valor "salir" o "Salir"
                                while (kk!="salir" && kk!="Salir")
                                {
                                    Console.WriteLine("Bienvenido \nSi desea ver reservas escriba ver \nSi desea aceptar reserva escriba aceptar \nSi desea castigar escriba castigar \nSi desea subir puntaje escriba subir \nSi desea descastigar escriba descastigar");

                                    kk = Console.ReadLine();
                                    if (kk == "ver" || kk == "Ver")
                                    {

                                    }
                                    if (kk == "aceptar" || kk == "Aceptar")
                                    {

                                    }
                                    if (kk == "subir" || kk == "Subir")
                                    {

                                    }
                                    if (kk == "castigar" || kk == "Castigar")
                                    {

                                    }
                                    if (kk == "Descastigar" || kk == "descastigar")
                                    {

                                    }
                                    if (kk != "descastigar" && kk != "Descastigar" && kk != "castigar" && kk != "Castigar" && kk != "subir" && kk != "Subir" && kk != "salir" && kk != "Salir" && kk!="aceptar" && kk != "Aceptar" && kk != "ver" && kk != "Ver")
                                    {
                                        Console.WriteLine("Lo ingresado no es válido");
                                    }







                                }
                            }
                        }
                    }
                    while (I == "Registro" || I == "registro")//arreglar los usuarios para que tome más de 1 

                    {
                        Console.WriteLine("Estudiante, Profesor o Bibliotecario: ");
                        var a = Console.ReadLine();//variable string que nos dirá si que tipo de usuario se estará registrando
                        while (a != "estudiante" && a != "Estudiante" && a != "Profesor" && a != "profesor" && a != "bibliotecario" && a != "Bibliotecario")
                        {
                            Console.WriteLine("Lo ingresado no es válido. \nEstudiante, Profesor o Bibliotecario: ");
                            // Loop infinito hasta que el usuario ingrese lo correspondiente
                            a = Console.ReadLine();
                        }
                        if (a == "Estudiante" || a == "estudiante")
                        {
                            Estudiante estudiante = new Estudiante();
                            Console.WriteLine("Ingrese su nombre: ");//aquí se crearía el nombre de usuario del estudiante                    
                            estudiante.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese su rut: ");
                            estudiante.Rut = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña: ");
                            estudiante.Contraseña = Console.ReadLine();
                            Console.WriteLine("Ingrese su mail: ");
                            estudiante.Mail = Console.ReadLine();
                            estudiante.Estado = "habil: ";
                            estudiante.Puntaje = 10;
                            usuarios.Add(estudiante);
                            break;
                        }
                        else if (a == "profesor" || a == "Profesor")
                        {
                            Profesor profesor = new Profesor();
                            Console.WriteLine("Ingrese su nombre: ");//aquí se crearía el nombre de usuario del profesor               
                            profesor.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese su rut: ");
                            profesor.Rut = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña: ");
                            profesor.Contraseña = Console.ReadLine();
                            Console.WriteLine("Ingrese su mail: ");
                            profesor.Mail = Console.ReadLine();
                            usuarios.Add(profesor);
                            break;

                        }
                        else if (a == "bibliotecario" || a == "Bibliotecario")
                        {
                            Bibliotecario bibliotecario = new Bibliotecario();
                            Console.WriteLine("Ingrese su nombre: ");//aquí se crearía el nombre de usuario del Bibliotecario             
                            bibliotecario.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese su rut: ");
                            bibliotecario.Rut = Console.ReadLine();
                            Console.WriteLine("Ingrese su contraseña: ");
                            bibliotecario.Contraseña = Console.ReadLine();
                            Console.WriteLine("Ingrese su mail: ");
                            bibliotecario.Mail = Console.ReadLine();
                            bibliotecario.Horario = "Horario: ";
                            usuarios.Add(bibliotecario);
                            break;

                        }

                    }

             }
         }
     }
}

