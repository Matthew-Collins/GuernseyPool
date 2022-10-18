using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace GuernseyPool
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Content = new ScrollView
            {
                Content = new VerticalStackLayout
                {

                    Spacing = 15,
                    Padding = 30,

                    Children =
                    {

                        new Label()
                            .Text("Captains Challenge")
                            .Font(bold:true, size:30)
                            //.SetValue(Text, Colors.Blue)
                            .CenterHorizontal(),

                        new HorizontalStackLayout()
                        {

                            new Image()
                                .Source("international_leisure.jpg")
                                .Size(-1,200),

                            new Image()
                                .Source("randalls.jpg")
                                .Size(-1,100),

                            new Image()
                                .Source("liberation_group.jpg")
                                .Size(-1,150)

                        }
                            //.SetValue(Spacing, 10)
                            .Paddings(10)
                            .CenterHorizontal(),

                        new Button()
                            .Text("Winter League Pool Score Card")
                            //.AddNavigation ?
                            .CenterHorizontal(),

                        new Button()
                            .Text("Summer League Pool Score Card")
                            //.AddNavigation ?
                            .CenterHorizontal()

                    }
                }
            };
        }
    }
}