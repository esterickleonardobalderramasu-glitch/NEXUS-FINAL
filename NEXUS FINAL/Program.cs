using System;

namespace NexusUniverso
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================================================================
            // MISIÓN 01: PROTOCOLO DE INMERSIÓN
            // (Estructura del programa, variables, asignaciones, entrada/salidas)
            // =========================================================================
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==========================================================");
            Console.WriteLine("        [SISTEMA NEXUS - INICIALIZANDO SIMULACIÓN]        ");
            Console.WriteLine("==========================================================");
            Console.ResetColor();

            Console.Write("\n[PROTOCOLO]: Ingrese su identificador de Cadete: ");
            string nombreCadete = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombreCadete))
            {
                nombreCadete = "Cadete-Desconocido";
            }

            int nivelEnergia = 85;
            double frecuenciaSintonia = 433.92;
            bool conexionEstable = true;

            Console.WriteLine($"\n[NEXUS]: Enlace establecido.");
            Console.WriteLine($"[CADETE]: {nombreCadete}");
            Console.WriteLine($"[ESTADO INICIAL]: Energía: {nivelEnergia}% | Frecuencia: {frecuenciaSintonia} MHz | Conexión: {conexionEstable}\n");

            Console.WriteLine("Presione cualquier tecla para continuar a la evaluación de reglas...");
            Console.ReadKey();

            // =========================================================================
            // MISIÓN 02: LAS REGLAS DE LA REALIDAD
            // (Estructuras de decisión y operadores lógicos)
            // =========================================================================
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("=== MISIÓN 02: EVALUACIÓN DE REGLAS DE ACCESO ===");
            Console.ResetColor();

            bool tienePaseAcceso = true;
            bool sistemaOperativo = nivelEnergia >= 20 && tienePaseAcceso;

            Console.WriteLine($"Estatus de Energía: {nivelEnergia}% (Mínimo requerido: 20%)");
            Console.WriteLine($"Pase de Acceso Sector 7: {(tienePaseAcceso ? "CONCEDIDO" : "DENEGADO")}");

            if (sistemaOperativo)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n[AUTORIZACIÓN OK]: El Explorador cumple con las reglas del sector. Acceso concedido.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[ACCESO DENEGADO]: Condiciones insuficientes para operar en NEXUS.");
                Console.ResetColor();
                return; // Finaliza si no cumple condición
            }

            Console.WriteLine("\nPresione cualquier tecla para ingresar al Bucle Principal de NEXUS...");
            Console.ReadKey();

            // =========================================================================
            // MISIÓN 04: LA MEMORIA DEL ENTRENAMIENTO
            // (Arreglos unidimensionales)
            // =========================================================================
            string[] inventario = new string[] { "Escáner de Materia", "Batería de Litio", "Módulo de Salto", "Kit Médico" };
            int[] lecturasSensores = new int[] { 42, 88, 95, 63, 77 };

            // =========================================================================
            // MISIÓN 05: CARTOGRAFÍA DE REALIDADES
            // (Arreglos bidimensionales - Mapa 2D)
            // =========================================================================
            char[,] mapaSector = new char[6, 12]
            {
                { '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█' },
                { '█', '·', '·', '·', '·', '·', '·', '·', '·', '·', '·', '█' },
                { '█', '·', '·', '█', '█', '·', '·', '·', '·', '·', '·', '█' },
                { '█', '·', '·', '·', '·', '·', '·', '·', '·', '·', '·', '█' },
                { '█', '·', '·', '·', '·', '·', '·', '·', '·', '·', '·', '█' },
                { '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█', '█' }
            };

            // Posición inicial del Explorador (P) en la matriz (Fila 3, Columna 5)
            int posX = 3;
            int posY = 5;

            // =========================================================================
            // MISIÓN 03: EL BUCLE INFINITO
            // (Estructuras de repetición)
            // =========================================================================
            bool sesionActiva = true;
            int totalAcciones = 0;

            while (sesionActiva)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"=== TERMINAL DE CONTROL NEXUS | OPERADOR: {nombreCadete} ===");
                Console.WriteLine($"[ENERGÍA: {nivelEnergia}%] | [ACCIONES REALIZADAS: {totalAcciones}]");
                Console.ResetColor();
                Console.WriteLine("\n1. Consultar Inventario y Telemetría (Memoria - Arreglos 1D)");
                Console.WriteLine("2. Explorar Cartografía 2D (Mapa interactivo - Matriz 2D)");
                Console.WriteLine("3. Ejecutar Diagnóstico en Bucle (Estructura For)");
                Console.WriteLine("4. Recargar Energía (Prueba de Condicionales)");
                Console.WriteLine("5. Abandonar Simulación (Salir)");
                Console.Write("\nSeleccione una orden: ");

                string opcion = Console.ReadLine();
                totalAcciones++;

                switch (opcion)
                {
                    case "1":
                        // Mostrar inventario y procesar vector
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("=== MISIÓN 04: MEMORIA Y TELEMETRÍA ===");
                        Console.ResetColor();

                        Console.WriteLine("\n[INVENTARIO EN EQUIPO]:");
                        for (int i = 0; i < inventario.Length; i++)
                        {
                            Console.WriteLine($"  Slot [{i}]: {inventario[i]}");
                        }

                        Console.WriteLine("\n[LECTURAS DE RADIACIÓN AMBIENTAL]:");
                        int sumaLecturas = 0;
                        foreach (int lectura in lecturasSensores)
                        {
                            Console.Write($"[{lectura} Hz] ");
                            sumaLecturas += lectura;
                        }
                        double promedio = (double)sumaLecturas / lecturasSensores.Length;
                        Console.WriteLine($"\n--> Promedio de Lecturas: {promedio:F2} Hz");

                        Console.WriteLine("\nPresione cualquier tecla para regresar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        // Modo interactivo de la Matriz Cartográfica
                        bool navegando = true;
                        while (navegando)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("=== MISIÓN 05: CARTOGRAFÍA DE REALIDADES (MAPA 2D) ===");
                            Console.ResetColor();
                            Console.WriteLine("Controles: [W] Arriba | [S] Abajo | [A] Izquierda | [D] Derecha | [Q] Salir del Mapa\n");

                            // Renderizado de la matriz con el explorador P
                            for (int fila = 0; fila < mapaSector.GetLength(0); fila++)
                            {
                                for (int col = 0; col < mapaSector.GetLength(1); col++)
                                {
                                    if (fila == posX && col == posY)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write('P'); // Jugador
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        char celda = mapaSector[fila, col];
                                        if (celda == '█') Console.ForegroundColor = ConsoleColor.DarkGray;
                                        else Console.ForegroundColor = ConsoleColor.DarkCyan;

                                        Console.Write(celda);
                                        Console.ResetColor();
                                    }
                                }
                                Console.WriteLine();
                            }

                            Console.WriteLine($"\nCoordenadas actuales del Explorador: [{posX}, {posY}]");
                            Console.Write("Movimiento: ");
                            ConsoleKeyInfo tecla = Console.ReadKey();

                            int nuevoX = posX;
                            int nuevoY = posY;

                            switch (char.ToUpper(tecla.KeyChar))
                            {
                                case 'W': nuevoX--; break;
                                case 'S': nuevoX++; break;
                                case 'A': nuevoY--; break;
                                case 'D': nuevoY++; break;
                                case 'Q': navegando = false; break;
                            }

                            // Validación de límites y colisiones con los muros '█'
                            if (navegando)
                            {
                                if (mapaSector[nuevoX, nuevoY] != '█')
                                {
                                    posX = nuevoX;
                                    posY = nuevoY;
                                    nivelEnergia = Math.Max(0, nivelEnergia - 1); // Desgaste de energía al mover
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n[IMPACTO]: Muro infranqueable.");
                                    Console.ResetColor();
                                    System.Threading.Thread.Sleep(500);
                                }
                            }
                        }
                        break;

                    case "3":
                        // Ejecución de bucles de diagnóstico
                        Console.Clear();
                        Console.WriteLine("=== MISIÓN 03: BUCLE DE DIAGNÓSTICO DE SUBSISTEMAS ===");
                        for (int i = 1; i <= 5; i++)
                        {
                            Console.WriteLine($"[ANALIZANDO PROCESO {i}/5] -> Estado: OK | Verificación de integridad completada.");
                            System.Threading.Thread.Sleep(300); // Pausa visual
                        }
                        Console.WriteLine("\n[NEXUS]: Diagnóstico completado sin anomalías.");
                        Console.WriteLine("Presione cualquier tecla para regresar...");
                        Console.ReadKey();
                        break;

                    case "4":
                        // Recarga de energía con condicionales
                        Console.Clear();
                        if (nivelEnergia >= 100)
                        {
                            Console.WriteLine("[NEXUS]: La energía ya se encuentra al máximo nivel (100%).");
                        }
                        else
                        {
                            nivelEnergia = 100;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("[SISTEMA]: Núcleo recargado con éxito. Energía restablecida al 100%.");
                            Console.ResetColor();
                        }
                        Console.WriteLine("Presione cualquier tecla para regresar...");
                        Console.ReadKey();
                        break;

                    case "5":
                        // Cierre del bucle principal
                        sesionActiva = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n[NEXUS]: Cerrando sesión de entrenamiento.");
                        Console.WriteLine($"Buen trabajo, Cadete {nombreCadete}. Simulación finalizada.");
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("\n[ERROR]: Orden no válida en NEXUS. Intente de nuevo.");
                        System.Threading.Thread.Sleep(800);
                        break;
                }
            }
        }
    }
}