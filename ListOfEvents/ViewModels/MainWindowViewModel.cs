using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using Avalonia.Controls;
using ListOfEvents.Models;
using ReactiveUI;

namespace ListOfEvents.ViewModels
{
    public class MainWindowViewModel : ReactiveObject
    {
        private ObservableCollection<CityEvent> _events;
        
        public List<CityEvent> Events_for_children
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Для детей")).ToList(); }
        }

        public List<CityEvent> Events_sport
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Спорт")).ToList(); }
        }

        public List<CityEvent> Events_culture
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Культура")).ToList(); }
        }

        public List<CityEvent> Events_tours
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Экскурсии")).ToList(); }
        }

        public List<CityEvent> Events_lifestyle
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Образ жизни")).ToList(); }
        }

        public List<CityEvent> Events_parties
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Вечеринки")).ToList(); }
        }

        public List<CityEvent> Events_education
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Образование")).ToList(); }
        }

        public List<CityEvent> Events_online
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Онлайн")).ToList(); }
        }

        public List<CityEvent> Events_show
        {
            get { return _events.Where(e => e.Categories.Any(item => item == "Шоу")).ToList(); }
        }
        
        public ObservableCollection<CityEvent> Events
        {
            get { return _events; }
            set => this.RaiseAndSetIfChanged(ref _events, value);
        }

        public MainWindowViewModel()
        {
            Events = EventParser.ParseEvents("Events.xml");
        }

    }
}