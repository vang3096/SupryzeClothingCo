﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using SupryzeClothingCo.Helpers;
using SupryzeClothingCo.Model;

#if __IOS__
using SupryzeClothingCo.iOS;
#elif __ANDROID__
using SupryzeClothingCo.Droid;
#else
using SupryzeClothingCo.UWP.Views;
#endif

namespace SupryzeClothingCo.ViewModel
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableRangeCollection<Item>();
            var task = ExecuteLoadItemsCommand();
            task.Wait();

#if __IOS__
            MessagingCenter.Subscribe<ItemNewViewController, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
#elif __ANDROID__
            MessagingCenter.Subscribe<Android.App.Activity, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
#else
            MessagingCenter.Subscribe<AddItems, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
#endif

        }

        public async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                Items.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
               // MessageDialog.SendMessage("Unable to load items.", "Error");
            }
            finally
            {
                IsBusy = false;
            }
        }


        //public Command<string> GoToDetailsCommand { get; }
        ItemDetailViewModel detailsViewModel;

    }
}