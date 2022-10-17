using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GuernseyPool.Pages
{
 
    public class ScoreCardPage : ContentPage
    {

        public Model.ScoreCard Model;

        public ScoreCardPage(Model.ScoreCard Model)
        {

            this.Model = Model;
            this.BindingContext = new ScoreCardViewModel(Model);

            Content = new StackLayout
            {
                Children =
                {

                    new Label()
                        .Text("The Captains Challenge")
                        .Font(bold: true)
                        .CenterHorizontal(),

                    new Label()
                        .Text($"{(Model.IsWinterLeague ? "Winter" : "Summer")} Pool League")
                        .CenterHorizontal(),

                    new Label()
                        .Text("Result Card")
                        .CenterHorizontal(),

                    // TODO: Grid

                    new Button()
                        .Text("Submit")
                        .BindCommand(nameof(ScoreCardViewModel.Submit)),

                    new Label()
                        .Bind<Label, DateTime, string>(Label.TextProperty, nameof(ScoreCardViewModel.Started), convert: started => $"{started:d MMMM yyyy HH:mm:ss}")

                }
            };

        }

    }

    [INotifyPropertyChanged]
    partial class ScoreCardViewModel
    {

        public Model.ScoreCard Model;

        public ScoreCardViewModel(Model.ScoreCard Model)
        {
            this.Model = Model;
        }

        [ObservableProperty]
        DateTime started = DateTime.Now;

        [RelayCommand]
        public async Task Submit()
        {
            await Model.Submit();
        }

    }

}
