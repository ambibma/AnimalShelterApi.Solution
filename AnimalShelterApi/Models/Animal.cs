using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AnimalShelterApi.Models
{
  public class Animal
  {
    public int AnimalId {get;set;}
    public string Name {get;set;}
    [Required]
    public string Species {get;set;}
    public string Sex {get;set;}
    [Required]
    public string Type {get;set;}
    public float Weight {get;set;}

    public string Note {get;set;}


  }
}