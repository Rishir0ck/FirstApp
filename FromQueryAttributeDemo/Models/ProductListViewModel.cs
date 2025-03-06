using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FromQueryAttributeDemo.Models;

public class ProductListViewModel
{
    public IEnumerable<Product>? Products { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int Totalpages { get; set; }
    public string? SearchTerm { get; set; }
    public string? Category { get; set; }
    public string? SortBy { get; set; }
    public bool SortAscending { get; set; }
    public IEnumerable<SelectListItem>? Categories { get; set; }
    public IEnumerable<SelectListItem>? SortOptions { get; set; }   
    public IEnumerable<SelectListItem>? PageSizeOptions { get; set; }



}
