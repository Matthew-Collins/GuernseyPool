using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Maui.Markup;

namespace GuernseyPool.View
{
    public class ScoreCardPage : ContentPage
    {
        public ScoreCardPage(Model.ScoreCard Model)
        {
            new StackLayout
            {
                Children =
                {

                    new Label()
                        .Text("The Captains Challenge")
                        .Font(bold: true)                    
                        .CenterHorizontal(),

                    new Label()
                        .Text("Pool League")
                        .CenterHorizontal(),

                    new Label()
                        .Text("Result Card")
                        .CenterHorizontal()

                }
            };
        }
    }
}
