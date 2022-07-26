using System;
using System.Collections.Generic;
using System.ComponentModel;
using Todo.Models;
using Todo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}