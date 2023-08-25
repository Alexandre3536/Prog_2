using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Atendimento
    {
        public DateTime Data {get;set;}
        public string? Animal {get;set;}
        public string? Veterinario {get;set;}
        public string? Observacao {get;set;}      
       

         public Atendimento()
        {

        }
    }

     public Client(DateTime data, string? animal, decimal veterinario, string? observacao)
    { 
          data = data;
          Animal = animal;
          veterinario = veterinario;
          observacao = observacao;

    }

    public void salvar()
    {

    }
    
    public void retornar()
    {

    }
}