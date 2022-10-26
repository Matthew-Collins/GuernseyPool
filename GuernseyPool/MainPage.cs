using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using CommunityToolkit.Maui.Markup;

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
                    Children =
                    {

                        new StackLayout()
                        {
                            Children = 
                            {
                                new Label()
                                    .Text("Guernsey Pool", Colors.White)
                                    .Font(bold:true, size:40)
                                    .CenterHorizontal(),

                                new Label()
                                    .Text("Captains Challenge", Colors.White)
                                    .Font(bold:true, size:28)
                                    .CenterHorizontal(),
                            }
                        }
                            .CenterHorizontal(),

                        new Border()
                        {
                            Content = new StackLayout()
                            {

                                new Image()
                                    .Source("international_leisure.jpg")
                                    .Height(200),

                                new Image()
                                    .Source("randalls.jpg")
                                    .Height(110),

                                new Image()
                                    .Source("liberation_group.jpg")
                                    .Height(150),

                            }
                                .BackgroundColor(Colors.White)
                                .Spacing(20)
                                .Padding(10) 
                                .OrientationOfDisplay()
                                .AddToList(OrientedItems)
                        }
                            .RoundCorners(15)
                            .CenterHorizontal(),

                        new Button()
                            .Text("Winter League Pool Score Card")
                            .OnClicked(OnScoreCardWinterClicked)
                            .CenterHorizontal(),

                        new Button()
                            .Text("Summer League Pool Score Card")
                            .OnClicked(OnScoreCardSummerClicked)
                            .CenterHorizontal(),

                        new Label()
                            .Text($"Built: {new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime:d MMM yyyy HH:mm:ss}")
                            .CenterHorizontal()
                    }
                }
                    .BackgroundColor(Colors.Green)
                    .Spacing(10)
                    .Padding(10)
            };

            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;

        }
        
        private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            OrientedItems.ForEach(x => x.OrientationOfDisplay(e.DisplayInfo));
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