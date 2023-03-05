﻿using System.ComponentModel.DataAnnotations;

namespace DesignPatternsAsp.Models.ViewModels; 
public class FormBeerViewModel {
    [Required]
    [Display(Name="Nombre")]
    public string Name { get; set; }
    [Display(Name = "Estilo")]
    public string Style { get; set; }
    [Display(Name = "Marca")]
    public Guid? BrandId { get; set; }
    [Display(Name = "Otra marca")]
    public string OtherBrand { get; set; }
}