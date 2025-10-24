using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosCsharpSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            /* 1. Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés es del 5% anual, se debe solicitar el monto del préstamo y se desea calcular la siguiente
            información.
            • Cuanto dinero se ha pagado de intereses en un año.
            • Cuanto dinero se ha pagado de intereses en el tercer trimestre del año.
            • Cuanto dinero se ha pagado de intereses en el primer mes.
            • Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses. */

            /*float montoPrestamo, interesAño, interesMes, prestamoTotal;
            const float INTERES = 0.05f;

            Console.WriteLine("Ingresa el monto del prestamo");
            montoPrestamo = float.Parse(Console.ReadLine());

            interesAño = INTERES * montoPrestamo;
            Console.WriteLine($"Los intereses al año son: {interesAño}");

            interesMes = ((INTERES * montoPrestamo) / 4) * 3;
            Console.WriteLine($"Los intereses al tercer trimestre son: {interesMes}");

            interesMes = (INTERES * montoPrestamo) / 12;
            Console.WriteLine($"Los intereses al primer mes son: {interesMes}");

            prestamoTotal = (((INTERES * montoPrestamo) * 5) + montoPrestamo);
            Console.WriteLine($"El total pagado incluyendo los intereses es de: {prestamoTotal}");*/

            // Ejercicio 2
            /*
            2. Desarrollar un algoritmo que permita generar la colilla de pago de los empleados de una
            empresa. La colilla debe mostrar:
            ● El Salario del Empleado
            ● El Valor de Ahorro mensual programado.
            ● La suma a deducir por aporte a la Salud (EPS) 12,5 %
            ● La suma a deducir por aporte al Fondo de Pensiones 16%
            ● Total a Recibir
            ● Toda la información que debe proveer el usuario del programa es el Salario del
            Empleado y el Valor de Ahorro mensual programado. El programa debe calcular y
            devolver el resto de los datos.
             */
            /*Console.WriteLine("Cuanto es el Salario del Empleado: ");
            float salarioEmpleado = float.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto es el Valor de Ahorro Mensual que Deseas Realizar: ");
            float ahorroMensual = float.Parse(Console.ReadLine());

            float aporteSalud = 0.125f * salarioEmpleado;
            float fondoPension = 0.16f * salarioEmpleado;
            float resultadoaRecibir = aporteSalud + fondoPension + salarioEmpleado;
            float resultadoAhorroMensual = (ahorroMensual * 12);
            float resultadoTotal = resultadoaRecibir - resultadoAhorroMensual;

            Console.WriteLine($"Aporte de Salud: {aporteSalud}");
            Console.WriteLine($"Fondo de Pension: {fondoPension}");
            Console.WriteLine($"Total a Recibir con Aportes: {resultadoaRecibir}");
            Console.WriteLine($"Resultado Ahorro Mensual: {ahorroMensual}, Resultado Ahorro Mensual (Anual): {resultadoAhorroMensual}");
            Console.WriteLine($"Resultado Total Descontando el Ahorro Mensual (Anual): {resultadoTotal}");*/

            // Ejercicio 3
            /*
            PROGRAMA AGENDA:
            crear una clase llamada "Persona" con las propiedades "Nombre", "Edad" y "Género (el
            usuario deberá seleccionar
            F o M) telefono". También creara un constructor para la clase "Persona" y métodos: para
            editar la información del usuario, agregar un nuevo usuario, imprimir los detalles de la
            persona y otro para calcular la edad en días. El programa solicitará al usuario que ingrese los
            detalles de la persona y luego le permitirá elegir entre dos opciones: imprimir los detalles de
            la persona o calcular la edad en días.
            solicita al usuario que ingrese los detalles de la persona (nombre, edad y género) y luego
            crea un objeto "Persona" con esos detalles. Luego, le presenta al usuario un menú de
            opciones que le permite imprimir los detalles de la persona, calcular la edad en días o salir
            del programa. Si el usuario selecciona la opción de imprimir detalles de la persona, el
            programa llama al método "ImprimirDetalles" de la clase "Persona", que imprime los
            detalles de la persona en la consola. Si el usuario selecciona la opción de calcular edad en
            días, el programa llama al método "CalcularEdadEnDias" de la clase "Persona", que calcula la
            edad en días y la imprime en la consola
             */

            /*
            // Inicio

            Console.WriteLine("Bienvenido Usuario Por Favor LLena los Siguientes Datos: ");

            // Datos Usuario Ingresar
            // Nombre
            Console.Write("Ingresa tu Nombre: ");
            string nombreIngresado = Console.ReadLine();
            // Edad
            Console.Write("Ingresa tu Edad: ");
            int edadIngresada = int.Parse(Console.ReadLine());
            // Genero
            Console.Write("Ingresa el Genero (Recuerda que despues no se podra modificar): ");
            char generoIngresado = char.Parse(Console.ReadLine());
            generoIngresado = char.ToUpper(generoIngresado);
            if (generoIngresado == 'F' || generoIngresado == 'M')
            {
                Console.WriteLine("Se ha Ingresado El genero Correctamente, se Proseguira con lo Siguiente");
                // Telefono
                Console.Write("Ingresa tu Telefono: ");
                long telefonoIngresado = long.Parse(Console.ReadLine());

                Console.WriteLine("Se han Ingresado los Datos Correctamente...");

                // Crear Objeto del Nuevo Usuario con sus Datos o Atributos

                Persona usuario1 = new Persona(nombreIngresado, edadIngresada, generoIngresado, telefonoIngresado);

                // Ciclo para el Switch

                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("Ya que has Llenado los Datos, Ingresa alguna de las Siguientes Opciones!\n 1. Imprimir Detalles del Usuario.\n2. Calcular Edad en Dias.\n3. Modificar tu Informacion.\n4. Salir del Programa.");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Has Escogido Imprimir Detalles de Usuario");
                            usuario1.DetallesUsuario();
                            break;
                        case 2:
                            Console.WriteLine("Has Escogido Calcular Edad en Dias");
                            usuario1.EdadUsuarioEnDias();
                            break;
                        case 3:
                            Console.WriteLine("Has Escogido Modificar Tu Informacion de Usuario");
                            Console.Write("Ingresa tu Nuevo Nombre: ");
                            string nombreIngresadoNuevo = Console.ReadLine();
                            // Edad
                            Console.Write("Ingresa tu Nueva Edad: ");
                            int edadIngresadaNuevo = int.Parse(Console.ReadLine());
                            // Telefono
                            Console.Write("Ingresa tu Nuevo Telefono: ");
                            long telefonoIngresadoNuevo = long.Parse(Console.ReadLine());

                            //Modificacion
                            usuario1._nombre = nombreIngresadoNuevo;
                            usuario1._edad = edadIngresadaNuevo;
                            usuario1._telefono = telefonoIngresadoNuevo;

                            // Imprimir Nueva Info
                            usuario1.EditarInformacionUsuario();
                            break;
                    }
                    if (opcion == 4)
                    {
                        Console.WriteLine("Has Salido del Programa...");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, Ingresa Correctamente el Genero Debe ser 'F' o 'M'");
            }
           */

            // Ejercicio 4
            /*
            4. ADMINISTRACIÓN DE UNA BIBLIOTECA. 
            Crear la clase "Libro" tiene los atributos "Titulo", "Autor", "Editorial" y "AnioPublicacion", 
            que se definen en el constructor de la clase. La clase "Biblioteca" contiene una lista de 
            objetos "Libro", que se pueden agregar mediante el método "AgregarLibro" y listar mediante 
            el método "ListarLibros". En el método, un método para buscar el libro por su nombre. 
            "Main", se muestra un menú de opciones.
            */

            /* Se crea el objeto para la Clase Biblioteca Donde estaba la Informacion en la Lista
            //Libro.Biblioteca biblioteca = new Libro.Biblioteca();
            //bool continuar = true;
            //while (continuar) {
            //    Console.WriteLine("Ingresa una opcion:");
            //    Console.WriteLine("1. Agregar Libro");
            //    Console.WriteLine("2. Mostrar Libros");
            //    Console.WriteLine("3. Salir del Programa");
            //    int opcion = int.Parse(Console.ReadLine());
            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("Escogiste la Opcion Agregar Libros");
            //            biblioteca.AgregarLibro();
            //            break;
            //        case 2:
            //            Console.WriteLine("Escogiste la Opcion Mostrar Libros");
            //            biblioteca.ListarLibros();
            //            break;
            //    }
            //    Console.WriteLine("Deseas Continuar? True (si) - False (no)");
            //    bool seguir = bool.Parse(Console.ReadLine());
            //    continuar = seguir;
            //    if (continuar == false) {
            //        Console.WriteLine("Has Salido de la Aplicacion, Vuelve Pronto!");
            //    }
            //}*/

            // Ejercicio 5
            /*
             Una universidad requiere analizar el proceso de matrícula para el tercer período
            académico del 2020 de cada uno de los estudiantes. La universidad consta de cinco (5)
            programas académicos. Cada programa académico tiene un número de créditos
            asociados. El valor de cada crédito académico es de $200.000.
            La siguiente Tabla muestra cada uno de los programas académicos con su número de
            créditos. Adicionalmente, muestra el descuento que se le puede aplicar al estudiante si
            realiza el pago en Efectivo. Por ejemplo, si el estudiante va a estudiar Administración
            de Empresas y paga en Efectivo, entonces se le aplica un descuento del 15%. Si paga en
            línea, NO se le aplicael descuento.
            Las dos formas de pago que acepta la universidad son Efectivo y pago en línea.
            Se requiere desarrollar una solución básica de programación que permita matricular  un número X de estudiantes.

            Programas Académicos / Nro. de Créditos por período académico / Descuentos 
            Ingeniería de sistemas / 20 / 18%
            Psicología / 16 / 12%
            Economía / 18 / 10%
            Comunicación Social / 18 / 5%
            Administración de Empresas / 20 / 15%


            Al finalizar, la solución de programación debe mostrar los
            siguientes resultados:
            3
            a. Cantidad de estudiantes inscritos por programa académico.
            b. Total de créditos inscritos en el tercer período académico del 2020.
            c. Valor total pagado por los estudiantes sin tener en cuenta el
            descuento.
            d. Valor total de descuentos aplicados por la universidad a los
            estudiantes.
            e. Valor neto de las inscripciones del primer semestre del 2020
             */
            //            int ingenieriaSistemas = 0, psicologia = 0, economia = 0, comunicacionSocial = 0, administracionEmpresas = 0;
            //            int creditosTotales = 0;
            //            decimal totalSinDescuento = 0, totalDescuento = 0, totalConDescuento = 0;
            //            int ProgramaAcademico, MetodoPago;

            //            const decimal valorCredito = 200000m;

            //            while (true)
            //            {
            //                Console.WriteLine(@"
            //Ingrese su programa académico:
            //1) Ingeniería de Sistemas
            //2) Psicología
            //3) Economía
            //4) Comunicación Social
            //5) Administración de Empresas
            //6) Salir
            //");
            //                ProgramaAcademico = int.Parse(Console.ReadLine());

            //                if (ProgramaAcademico == 6)
            //                {
            //                    Console.WriteLine("Has salido del programa...");
            //                    break;
            //                }

            //                int creditos = 0;
            //                decimal descuento = 0;

            //                switch (ProgramaAcademico)
            //                {
            //                    case 1:
            //                        creditos = 20;
            //                        descuento = 0.18m;
            //                        ingenieriaSistemas++;
            //                        break;

            //                    case 2:
            //                        creditos = 16;
            //                        descuento = 0.12m;
            //                        psicologia++;
            //                        break;

            //                    case 3:
            //                        creditos = 18;
            //                        descuento = 0.10m;
            //                        economia++;
            //                        break;

            //                    case 4:
            //                        creditos = 18;
            //                        descuento = 0.05m;
            //                        comunicacionSocial++;
            //                        break;

            //                    case 5:
            //                        creditos = 20;
            //                        descuento = 0.15m;
            //                        administracionEmpresas++;
            //                        break;

            //                    default:
            //                        Console.WriteLine("Opción no válida, intenta nuevamente.");
            //                        continue;
            //                }

            //                decimal precio = creditos * valorCredito;
            //                totalSinDescuento += precio;

            //                Console.WriteLine(@"
            //Seleccione su método de pago: 
            //1) Efectivo 
            //2) En línea
            //");
            //                MetodoPago = int.Parse(Console.ReadLine());

            //                if (MetodoPago == 1)
            //                {
            //                    decimal descuentoAplicado = precio * descuento;
            //                    precio -= descuentoAplicado;
            //                    totalDescuento += descuentoAplicado;
            //                }

            //                Console.WriteLine($"El valor a pagar es de: ${precio:N0}");
            //                totalConDescuento += precio;
            //                creditosTotales += creditos;

            //                Console.WriteLine("Estudiante matriculado correctamente.\n");
            //            }

            //            // Mostrar resumen
            //            Console.WriteLine("\n=== Resumen de inscripciones ===");
            //            Console.WriteLine($"Ingeniería de Sistemas: {ingenieriaSistemas}");
            //            Console.WriteLine($"Psicología: {psicologia}");
            //            Console.WriteLine($"Economía: {economia}");
            //            Console.WriteLine($"Comunicación Social: {comunicacionSocial}");
            //            Console.WriteLine($"Administración de Empresas: {administracionEmpresas}");

            //            Console.WriteLine($"\nTotal de créditos inscritos: {creditosTotales}");
            //            Console.WriteLine($"Valor total sin descuentos: ${totalSinDescuento:N0}");
            //            Console.WriteLine($"Total de descuentos aplicados: ${totalDescuento:N0}");


            //
            //            Console.WriteLine($"Valor neto pagado por los estudiantes: ${totalConDescuento:N0}");
            //            La empresa de tecnología “COMPUTRONIC”, es una empresa líder en venta y
                        //distribución de equipos tecnológicos en la ciudad de Bogotá y cuenta en su única sede
                        //con un N cantidad de empleados quienes realizanN ventas durante el día. La empresa
                        //requiere identificar cuántas de las ventas fueron menores o iguales a $300.000,
                        //cuántas ventas fueron mayores a $
                        //300.000 y menores a $800.000 y cuántas fueron mayores o iguales a
                        //$800.000 por cada empleado.
                        //También se necesita conocer monto total por la venta realizada por empleado y las
                        //bonificaciones a pagar según la venta realizada.Para el pago de la bonificación es
                        //necesario tener en cuenta la siguiente tabla:
                        //Venta Realizada
                        //% Pago
                        //Bonificación
                        //Ventas superiores o iguales a $400.000 3 %
                        //Ventas entre $400.001 a $800.000 5 %
                        //Ventas superiores a $800.000 10 %
                        //Al finalizar el día, se debe calcular el valor a pagar por empleado, especificando: pago
                        //básico y el valor de la bonificación recibida.Tenga en cuenta que el pago básico para
                        //todos los empleados es de $500.000
                        //Desarrolle una solución básica de programación que le permita a la empresa
                        //COMPUTRONIC conocer toda la información que es de su interés. Los valores para
                        //ingresar deben ser números positivos.




        }
    }
}