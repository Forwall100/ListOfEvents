using System;
using System.Collections.Generic;
using Avalonia.Controls;

namespace ListOfEvents.Models;

public class CityEvent
{
    public CityEvent(string header, string description, string imagePath, string date, List<string> categories, string price)
    {
        Header = header;
        Description = description;
        ImagePath = imagePath;
        Date = date;
        Categories = categories;
        Price = price;
    }

    public CityEvent()
    {
        Header = string.Empty;
        Description = string.Empty;
        ImagePath = string.Empty;
        Date = string.Empty;
        Categories = new List<string>();
        Price = string.Empty;
    }

    public string Header { get; set; }
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public string Date { get; set; }
    public List<string> Categories { get; set; }
    public string Price { get; set; }
    
    
}