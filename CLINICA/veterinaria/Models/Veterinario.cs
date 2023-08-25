using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace veterinaria.Models
{
    public class Veterinario
    {
        public int Id {get;set;}
        public string? FirstName {get;set;}
        public string? LastName {get;set;}
        public string? Telefone {get;set;}      
        public string? CRM {get;set;} 

         public Veterinario()
        {

        }
    }

    public Client(int id, string? firstName, string? lastName, string? telefone, string? CRM)
    { 
            Id = id;
            FirstName = firstName;
            lastName = lastName;
            Telefone = telefone;
            CRM = cRM;
            
    }


    public void salvar ()
    {

    }

    public void retornar ()
    {
        
    }
}

       