using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace ListOfEvents.Models
{
    public class EventParser
    {
        public static ObservableCollection<CityEvent> ParseEvents(string xmlFilePath)
        {
            var events = new ObservableCollection<CityEvent>();

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlFilePath);

            var eventNodes = xmlDoc.SelectNodes("//CityEvent");

            foreach (XmlNode eventNode in eventNodes)
            {
                var cityEvent = new CityEvent();
                cityEvent.Header = eventNode.SelectSingleNode("Header")?.InnerText;
                cityEvent.Description = eventNode.SelectSingleNode("Description")?.InnerText;
                if (cityEvent.Description.Length > 135)
                {
                    cityEvent.Description = cityEvent.Description.Substring(0, 135);
                    cityEvent.Description += "...";
                }
                cityEvent.ImagePath = eventNode.SelectSingleNode("Image")?.InnerText;
                cityEvent.Date = DateTime.Parse(eventNode.SelectSingleNode("Date")?.InnerText).ToString("d");
                cityEvent.Categories = new List<string>();
                var categoryNodes = eventNode.SelectNodes("Category/CategoryItem");
                foreach (XmlNode categoryNode in categoryNodes)
                {
                    cityEvent.Categories.Add(categoryNode.InnerText);
                }
                cityEvent.Price = eventNode.SelectSingleNode("Price")?.InnerText;

                events.Add(cityEvent);
            }

            return events;
        }
    }
}