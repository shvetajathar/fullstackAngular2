using System.ComponentModel.DataAnnotations;
namespace ProdMvc.Models;
public class Product
{
    [Display(Name="Product Id")]
    [Key]
    [Required(ErrorMessage="Id is Compulsory")]
    public int Id{get;set;}
    [Required(ErrorMessage="cannot be blank")]
    public string ?Name{get;set;}
    [Range(100,900,ErrorMessage="price should be between 100 and 900")]
    public int Price{get;set;}
    public int Stock{get;set;}


}