using System;

namespace Pokemon
{
    // public enum genero
    // {
    //     Masculino,
    //     Femenino,
    // }
    class Pokemon
    {
        public string nombre;

        public int id;

        // public Genero genero;
        // public enum Genero{
        //     Masculino,
        //     Femenino,
        //     Indefinido
        // }

        public Pokemon (string nombre, int id){
            this.nombre = nombre;
            this.id = id;
        }
    }
}