﻿using SupryzeClothingCo.Helpers;
using SupryzeClothingCo.Model;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SupryzeClothingCo.UWP.Views
{
    public sealed partial class AddItems : Page
    {
        public AddItems()
        {
            this.InitializeComponent();
        }

        private void SaveItem_Click(object sender, RoutedEventArgs e)
        {
            var _item = new Item();
            _item.Text = txtText.Text;
            _item.Description = txtDesc.Text;
            MessagingCenter.Send(this, "AddItem", _item);
            MessagingCenter.ClearSubscribers();
            this.Frame.GoBack();
        }
    }
}