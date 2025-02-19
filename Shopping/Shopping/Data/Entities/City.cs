﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class City
    {

        public int Id { get; set; }
        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio ")]
        public string Name { get; set; }

        public State State { get; set; }

        public ICollection<City> Cities { get; set; }

    //    [Display(Name = "Ciudades")]
      //  public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
