using System;
using System.Collections.Generic;

namespace Pokemons
{
    class Pokedex
    {
        public HashSet<Pokemon> registroPokemon = new HashSet<Pokemon>();

        //constructro vacio
        public Pokemon(){
            Pokemon Snorlax = new pokemon.Add("Snorlax", 143);
            registroPokemon.Add(Snorlax);
            Pokemon Psyduck = new pokemon.Add("Psyduck", 54);
            registroPokemon.Add(Psyduck);
            Pokemon Pichu = new pokemon.Add("Pichu", 171);
            registroPokemon.Add(Pichu);
            Pokemon Nidoran = new pokemon.Add("Nidoran", 32);
            registroPokemon.Add(Nidoran);
            //TODO: terminar los otros 6 pokemon 
        }

        public Pokemon PokemonPorNombre(string nombre){
            foreach (var pokemon in registroPokemon)
            {
                if (nombre == pokemon.nombre)
                {
                    //resultado

                    //devolver variable
                    return pokemon;
                }
            }
           foreach (var pokemon in registroPokemon)
           {
               if (id == pokemon.id)
               {
                   return pokemon;
               }
           }

            
        }
        public void ImprimePokemon(){
            System.Console.WriteLine("pokedex");
            foreach (var pokemon in registroPokemon)
            {
                System.Console.WriteLine(pokemon);
            }
        }
    }
}