using System.ComponentModel.DataAnnotations;
namespace MvcGames.Models;

public class Games 
{
    public int Id{get; set;}
    public string? Title { get; set; }

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set;}
    public string? Publisher { get; set;}
    public decimal Price { get; set; }

    public int Score { get; set; }
}