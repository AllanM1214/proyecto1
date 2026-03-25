int opcion;
int totalevaluados = 0;
int totalrechazados = 0;
int totalpublicados = 0;
int totaleenrevision = 0;

int alto = 0;
int medio = 0;
int bajo = 0;

do
{

    Console.WriteLine("1. contenido nuevo");
    Console.WriteLine("2. reglas del sistema");
    Console.WriteLine("3. estadisticas de la sesion");
    Console.WriteLine("4. reiniciar estadisticas");
    Console.WriteLine("5. salir");


    opcion = int.Parse(Console.ReadLine());
    
    switch (opcion)
    {
        case 1:

            Console.WriteLine("A). Evaluacion de contenido");
            int contenidonuevo;
            do
            {

                Console.WriteLine("tipo de contenido: ");
                string contenido = Console.ReadLine();
                Console.WriteLine("duracion de contenido en minutos: ");
                int duracion = int.Parse(Console.ReadLine());
                Console.WriteLine("clasificacion: ");
                int clasificacion = int.Parse(Console.ReadLine());
                Console.WriteLine("hora programada: ");
                int hora = int.Parse(Console.ReadLine());
                Console.WriteLine("nivel de produccion: ");
                string produccion = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Contenido: " + contenido);
                Console.WriteLine("duracion: " + duracion + "min");
                Console.WriteLine("Clasificacion: +" + clasificacion);
                Console.WriteLine("hora programada: " + hora + "Hrs.");
                Console.WriteLine("nivel de produccion: " + produccion);
                Console.WriteLine("contenido registrado...");
                totalevaluados++;

                bool valido = true;
                string razon = "";

                if (clasificacion == 13)
                {
                    if (hora < 6 || hora > 22)
                        valido = false;
                    razon = "Horario no permitido para +13";
                }
                else if (clasificacion == 18)
                    if (hora >= 22 || hora <= 5)
                    {
                        valido = false;
                        razon = "Horario no permitido para +18";
                    }
                if (valido)
                {
                    if (contenido == "pelicula")
                    {
                        if (duracion < 60 || duracion > 180)
                        {
                            valido = false;
                            razon = "Duración incorrecta";
                        }
                    }
                    else if (contenido == "serie")
                    {
                        if (duracion < 20 || duracion > 90)
                        {
                            valido = false;
                            razon = "Duración incorrecta";
                        }
                    }
                    else if (contenido == "documental")
                    {
                        if (duracion < 30 || duracion > 120)
                        {
                            valido = false;
                            razon = "Duración incorrecta";
                        }
                    }
                    else if (contenido == "evento")
                    {
                        if (duracion < 30 || duracion > 240)
                        {
                            valido = false;
                            razon = "Duracion incorrecta";
                        }
                    }
                }
            }
            while (opcion != 0);
            {
                Console.WriteLine("presione enter para salir");
                

            }

            break;
        case 2:
            Console.WriteLine("B). Reglas del Sistema");
            int reglas;
            do
            {
                Console.WriteLine("1. Reglas de clasificación y horario");
                Console.WriteLine("2. Reglas de duración por tipo");
                Console.WriteLine("3. Reglas de producción");
                Console.WriteLine(". salir");
                reglas = int.Parse(Console.ReadLine());

                Console.Clear();
                if (reglas == 1)
                {
                    Console.WriteLine("• Todo público: cualquier hora");
                    Console.WriteLine("• +13: entre 6 y 22 horas");
                    Console.WriteLine("• +18: entre 22 y 5 horas");
                }
                if (reglas == 2)
                {
                    Console.WriteLine("• Película: 60–180 minutos");
                    Console.WriteLine("• Serie: 20–90 minutos");
                    Console.WriteLine("• Documental: 30–120 minutos");
                    Console.WriteLine("• Evento en vivo: 30–240 minutos");
                }
                if (reglas == 3)
                {
                    Console.WriteLine("• Producción baja solo válida para Todo público o +13");
                    Console.WriteLine("• Producción media o alta válida para cualquier clasificación");

                }
            }
            while (reglas != 4);
            break;
        case 3:
            Console.WriteLine("3. Estadisticas de la Sesion");

            Console.WriteLine("Total: " + totalevaluados);
            Console.WriteLine("Publicados: " + totalpublicados);
            Console.WriteLine("Rechazados: " + totalrechazados);
            Console.WriteLine("En revisión: " + totaleenrevision);

            break;
        case 4:
            Console.WriteLine("4. Reiniciar Estadisticas");

            break;
        case 5:
            Console.WriteLine("5. Salir");
            Console.WriteLine("presione enter para salir");
            break;
    }


}
while (opcion != 5);

