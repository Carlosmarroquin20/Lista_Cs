using System;

namespace Lista_en_c_
{
    class Program
    {
        static void Main()
        {
            Student[] ListaEstudiantes = new Student [5];
            Course[] ListaCurso = new Course[5];

            int MaxE = 0;

            /*Se empiezan a pedir y a ingresar datos
            de los alumnos, los cuales se almacenan 
            en variables para su uso despues*/

            while (MaxE < 5){ //Maximo de alumnos que se pueden soportar = 5
                Console.WriteLine("Nombre del Estudiante: ");
                string Name = Console.ReadLine();

                Console.WriteLine("Edad del Estudiante");
                int Age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Carnet de Identificacion: ");
                string Carnet = Console.ReadLine();

                Console.WriteLine(" El alumno " + Name + " es solvente de pago?");
                Boolean Solvencia = Convert.ToBoolean(Console.ReadLine());

                Console.WriteLine("Nombre del curso: ");
                string CursoNombre = Console.ReadLine();

                Console.WriteLine("Nota del primer parcial: ");
                int NotaP1 = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Nota del segundo parcial:  ");
                int NotaP2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Nota final del curso de " + CursoNombre);
                int NotaF0 = Convert.ToInt32(Console.ReadLine());

                Student Estudiante = new Student(Name, Age, Carnet, Solvencia);
                ListaEstudiantes[MaxE] = Estudiante;

                Course Curso = new Course(CursoNombre, NotaP1, NotaP2, NotaF0);
                ListaCurso[MaxE] = Curso;
                MaxE++;
            }

            //Datos unidos en lista

            Console.WriteLine("");
            Console.WriteLine("Lista de datos de alumnos UMG");
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < 5; i++){
                Student Estudiante = ListaEstudiantes[i];

                Course Curso = ListaCurso[i];

                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("                                                                    DATOS UMG                                                                                                                            ");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine(" Nombre del estudiante: " + Estudiante.Name + "-- Edad del Estudiante: " + Estudiante.Age + "-- Carnet del Estudiante: " + Estudiante.Carnet + "-- Solvencia del Estudiante: " + Estudiante.Solvencia + "");
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine(" Nombre del Curso:" + Curso.CursoNombre + "-- Nota del Primer Parcial: " + Curso.NotaP1 + "-- Nota del Seguundo Parcial: " + Curso.NotaP2 + "-- Nota Final del Curso:" + Curso.NotaF0);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("------------------------------------------------GRACIAS--------------------------------------------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("");
            }
        }
    }
}