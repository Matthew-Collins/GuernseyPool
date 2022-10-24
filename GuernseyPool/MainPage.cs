using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls.Shapes;

namespace GuernseyPool
{
    public class MainPage : ContentPage
    {

        readonly List<StackLayout> OrientedItems = new();
        
        public MainPage()
        {
            Content = new ScrollView
            {
                Content = new StackLayout
                {

                    BackgroundColor = Colors.Green,
                    Spacing = 10,
                    Padding = 10,

                    Children =
                    {

                        new StackLayout()
                        {
                            Children = 
                            {
                                new Label() { TextColor = Colors.White }
                                    .Text("Guernsey Pool" )
                                    .Font(bold:true, size:40)
                                    .CenterHorizontal(),

                                new Label() { TextColor = Colors.White }
                                    .Text("Captains Challenge")
                                    .Font(bold:true, size:28)
                                    .CenterHorizontal(),
                            }
                        }
                            .CenterHorizontal(),

                        new Border()
                        {

                            StrokeShape = new RoundRectangle() { CornerRadius = 15 },

                            Content = new StackLayout()
                            {

                                new Image() { HeightRequest = 200 }
                                    .Source("international_leisure.jpg"),

                                new Image() { HeightRequest = 110 }
                                    .Source("randalls.jpg"),

                                new Image() { HeightRequest = 150 }
                                    .Source("liberation_group.jpg")

                            }
                                .Paddings(10)
                                .Invoke(x => { 

                                                x.BackgroundColor = Colors.White;
                                                x.Spacing = 20;

                                                if (DeviceDisplay.Current.MainDisplayInfo.Orientation == DisplayOrientation.Portrait)
                                                { 
                                                    x.Orientation = StackOrientation.Vertical;
                                                }
                                                else
                                                {
                                                    x.Orientation = StackOrientation.Horizontal;
                                                }

                                                OrientedItems.Add(x);
                                                DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
                                    
                                            })
                        }
                            .CenterHorizontal(),

                        new Button()
                            .Text("Winter League Pool Score Card")
                            .Invoke(x => x.Clicked += OnScoreCardWinterClicked)
                            .CenterHorizontal(),

                        new Button()
                            .Text("Summer League Pool Score Card")
                            .Invoke(x => x.Clicked += OnScoreCardSummerClicked)
                            .CenterHorizontal(),

                    }
                }
            };
        }

        private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            if (e.DisplayInfo.Orientation == DisplayOrientation.Portrait)
            {
                OrientedItems.ForEach(x => x.Orientation = StackOrientation.Vertical);
            }
            else 
            {
                OrientedItems.ForEach(x => x.Orientation = StackOrientation.Horizontal);
            }
        }

        private void OnScoreCardWinterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ScoreCardPage(new Model.ScoreCard(true)));
        }

        private void OnScoreCardSummerClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.ScoreCardPage(new Model.ScoreCard(false)));
        }

    }

}