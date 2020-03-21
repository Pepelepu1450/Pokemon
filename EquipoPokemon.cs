using System;

namespace Pokemon
{
    public enum Genero
    {
        Masculino,
        Femenino,
    }
    class EquipoPokemon : Pokemon
    {
        Genero genero;

        public EquipoPokemon(string nombre, int id, Genero genero) : base (nombre, id){
            this.genero = genero;
        }
         
        public override string ToString(){
            return $"{this.nombre} - {this.genero}";
        }
    }
}