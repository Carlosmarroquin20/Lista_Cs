using System;

namespace Lista_en_c_
{
    
    class Student //Clase del estudiante
    {
        public string Name;
        public int Age;
        public string Carnet;
        public Boolean Solvencia;
        
        public Student(string Name, int Age, string Carnet, Boolean Solvencia)
        {
            this.Name = Name;
            this.Age = Age;
            this.Carnet = Carnet;
            this.Solvencia = Solvencia;
           
        }
    }

    class Course{ //Clase del curso
        public string CursoNombre; //Nombre del curso
        public int NotaP1; //Nota del primer parcial
        public int NotaP2; //Nota del segundo parcial
        public int NotaF0; //Nota Examen final


        public Course(string CursoNombre, int NotaP1, int NotaP2, int NotaF0)
        {
            this.CursoNombre = CursoNombre;
            this.NotaP1 = NotaP1;
            this.NotaP2 = NotaP2;
            this.NotaF0 = NotaF0;
        }
    }
}
