using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using Table.Models;

namespace Table.ViewModels;

public class MainViewModel : ViewModelBase
{
    private Random _random { get; } = new Random();
    public ObservableCollection<Detail> Materials { get; set; } 

    public MainViewModel()
    {
        Materials = new ObservableCollection<Detail>();
        Mock();
        
    }

    private void Mock()
    {
        for (int i = 0; i < 50; i++)
        {
            var obj = new Detail
            {
                Name = "Secret object № " + i + 20,
                Weight = Math.Round(_random.NextDouble(), 5),
                Material = "Secret Material " + _random.Next(500, 2000).ToString(),
                Count = _random.Next(15, 999)
            };
            Materials.Add(obj);
        }
    }

}
