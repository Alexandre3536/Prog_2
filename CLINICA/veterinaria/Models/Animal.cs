using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.Models
{
    public class Animal
    {
        public string?Nome {get;set;}
        public string? Raca{get;set;}
        public decimal Peso {get;set;}
        public decimal Altura {get;set;}      
        public string? Responsavel{get;set;} 
        public string? Telefone_Responsavel{get;set;}

         public Animal()
        {

        }
    }

    
    public Client(string? nome, string? raca, decimal peso, decimal altura, string? responsavel, string? telefone_Responsavel)
    { 
            Nome = nome;
            Raca = raca;
            Peso = peso;
            Altura = altura;
            Responsavel = responsavel;
            telefone_Responsavel = telefone_Responsavel;

    }

    public void salvar ()
    {

    }

    public void retornar ()
    {

    }
}