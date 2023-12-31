﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public enum Race { Asiático, Branco, Indio, Negro, Pardo, Outros }
    
    public class Pacient
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome requerido")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data de Nascimento requerido.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Peso requerido")]
        [Display(Name = "Peso")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Altura requerida.")]
        [Display(Name = "Altura")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Raça requerida.")]
        [Display(Name = "Raça")]
        public Race Race { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }  
        public AppUser? User { get; set; }


    }
}
