using cityevent.Models;
using DynamicData;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace cityevent.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private CityEvent cItem;
        private CityEvent[] sourceArray;
        private SourceList<CityEvent> sourceList;
        private readonly ReadOnlyObservableCollection<CityEvent> items1;
        private readonly ReadOnlyObservableCollection<CityEvent> items2;
        private readonly ReadOnlyObservableCollection<CityEvent> items3;
        private readonly ReadOnlyObservableCollection<CityEvent> items4;
        private readonly ReadOnlyObservableCollection<CityEvent> items5;
        private readonly ReadOnlyObservableCollection<CityEvent> items6;
        private readonly ReadOnlyObservableCollection<CityEvent> items7;
        private readonly ReadOnlyObservableCollection<CityEvent> items8;
        private readonly ReadOnlyObservableCollection<CityEvent> items9;

        public MainWindowViewModel()
        {
            sourceList = new SourceList<CityEvent>();
            sourceArray = Serializer<CityEvent[]>.Load("../../../Assets/data.xml");
            sourceList = new SourceList<CityEvent>();
            System.Diagnostics.Debug.WriteLine(sourceArray[0].Header, "\n");
            foreach (CityEvent cityEvent in sourceArray)
            {
                sourceList.Add(cityEvent);
            }
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 1).ObserveOn(RxApp.MainThreadScheduler).Bind(out items1).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 2).ObserveOn(RxApp.MainThreadScheduler).Bind(out items2).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 3).ObserveOn(RxApp.MainThreadScheduler).Bind(out items3).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 4).ObserveOn(RxApp.MainThreadScheduler).Bind(out items4).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 5).ObserveOn(RxApp.MainThreadScheduler).Bind(out items5).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 6).ObserveOn(RxApp.MainThreadScheduler).Bind(out items6).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 7).ObserveOn(RxApp.MainThreadScheduler).Bind(out items7).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 8).ObserveOn(RxApp.MainThreadScheduler).Bind(out items8).Subscribe();
            sourceList.Connect().AutoRefresh(x => x.Category).Filter(x => x.Category == 9).ObserveOn(RxApp.MainThreadScheduler).Bind(out items9).Subscribe();
        }

        public CityEvent CItem
        {
            get => cItem;
            set => cItem = value;
        }
        public SourceList<CityEvent> SourceList
        {
            get => sourceList;
            set => this.RaiseAndSetIfChanged(ref sourceList, value);
        }

        public ReadOnlyObservableCollection<CityEvent> CustomItems1 => items1;
        public ReadOnlyObservableCollection<CityEvent> CustomItems2 => items2;
        public ReadOnlyObservableCollection<CityEvent> CustomItems3 => items3;
        public ReadOnlyObservableCollection<CityEvent> CustomItems4 => items4;
        public ReadOnlyObservableCollection<CityEvent> CustomItems5 => items5;
        public ReadOnlyObservableCollection<CityEvent> CustomItems6 => items6;
        public ReadOnlyObservableCollection<CityEvent> CustomItems7 => items7;
        public ReadOnlyObservableCollection<CityEvent> CustomItems8 => items8;
        public ReadOnlyObservableCollection<CityEvent> CustomItems9 => items9;
    }
}
