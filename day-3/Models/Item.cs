namespace day_3.Models;

using System;
using System.ComponentModel.DataAnnotations;
public class Item
{
    public int Id { get; set; }

    public decimal Value { get; set; }

    [Required]
    public string? Description { get; set; }
}
