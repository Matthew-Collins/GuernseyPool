using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace GuernseyPool.Pages
{
 
    public partial class ScoreCardPage : ContentPage
    {

        public Model.ScoreCard Model;

        enum Column { Players, PlayerTotals, HomeScore, HomePlayer, Vs, AwayPlayer, AwayScore }
        enum Row { DateVenue, HomeTeam, PlayerA, PlayerB, PlayerC, PlayerD, PlayerE, Frame6, Frame7, AwayTeam, PlayerF, PlayerG, PlayerH, PlayerI, PlayerJ, Frame14, Frame15 }

        public ScoreCardPage(Model.ScoreCard Model)
        {

            this.Model = Model;

            Content = new ScrollView
            {
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

                        new Border()
                        {

                            Content = new Grid()
                            {

                                RowDefinitions = Rows.Define(
                                    (Row.DateVenue, 25),
                                    (Row.HomeTeam, 25),
                                    (Row.PlayerA, 25),
                                    (Row.PlayerB, 25),
                                    (Row.PlayerC, 25),
                                    (Row.PlayerD, 25),
                                    (Row.PlayerE, 25),
                                    (Row.Frame6, 25),
                                    (Row.Frame7, 25),
                                    (Row.AwayTeam, 25),
                                    (Row.PlayerF, 25),
                                    (Row.PlayerG, 25),
                                    (Row.PlayerH, 25),
                                    (Row.PlayerI, 25),
                                    (Row.PlayerJ, 25),
                                    (Row.Frame14, 25),
                                    (Row.Frame15, 25)
                                ),

                                ColumnDefinitions = Columns.Define(
                                    (Column.Players, Star),
                                    (Column.PlayerTotals, 100),
                                    (Column.HomeScore, 20),
                                    (Column.HomePlayer, 20),
                                    (Column.Vs, 10),
                                    (Column.AwayPlayer, 20),
                                    (Column.AwayScore, 20)
                                ),

                                Children = {

                                    // Date Venue
                                    new Border()
                                    {
                                        Content = new Label() { Text = "Date" }
                                    }
                                        .Row(Row.DateVenue)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "Venue" }
                                    }
                                        .Row(Row.DateVenue)
                                        .Column(Column.PlayerTotals)
                                        .ColumnSpan(6),


                                    // Home Team
                                    new Border()
                                    {
                                        Content = new Label() { Text = "Home Team" }
                                    }
                                        .Row(Row.HomeTeam)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "Player Total" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.HomeTeam)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "Player Scores" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.HomeTeam)
                                        .Column(Column.HomeScore)
                                        .ColumnSpan(5),


                                    // Player A
                                    new Border()
                                    {
                                        Content = new Label() { Text = "A:" }
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "A" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "F" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerA)
                                        .Column(Column.AwayScore),


                                    // Player B
                                    new Border()
                                    {
                                        Content = new Label() { Text = "B:" }
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "B" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "G" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerB)
                                        .Column(Column.AwayScore),


                                    // Player C
                                    new Border()
                                    {
                                        Content = new Label() { Text = "C:" }
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "C" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "H" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerC)
                                        .Column(Column.AwayScore),


                                    // Player D
                                    new Border()
                                    {
                                        Content = new Label() { Text = "D:" }
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "D" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "I" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerD)
                                        .Column(Column.AwayScore),


                                    // Player E
                                    new Border()
                                    {
                                        Content = new Label() { Text = "E:" }
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "E" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "J" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerE)
                                        .Column(Column.AwayScore),


                                    // Home Sign Off / Frame 6
                                    new Border()
                                    {
                                        Content = new Label() { Text = "Captains Signature" }
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.Players)
                                        .RowSpan(2),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "Team Total" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.PlayerTotals)
                                        .RowSpan(2),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "A" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "H" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame6)
                                        .Column(Column.AwayScore),


                                    // Home Sign Off / Frame 7
                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame7)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "B" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame7)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame7)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "I" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame7)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame7)
                                        .Column(Column.AwayScore),


                                    // Away Team
                                    new Border()
                                    {
                                        Content = new Label() { Text = "Away Team" }
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "Player Total" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "C" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "J" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.AwayTeam)
                                        .Column(Column.AwayScore),


                                    // Player F
                                    new Border()
                                    {
                                        Content = new Label() { Text = "F:" }
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "D" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "F" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerF)
                                        .Column(Column.AwayScore),


                                    // Player G
                                    new Border()
                                    {
                                        Content = new Label() { Text = "G:" }
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "E" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "G" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerG)
                                        .Column(Column.AwayScore),


                                    // Player H
                                    new Border()
                                    {
                                        Content = new Label() { Text = "H:" }
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "A" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "J" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerH)
                                        .Column(Column.AwayScore),


                                    // Player I
                                    new Border()
                                    {
                                        Content = new Label() { Text = "I:" }
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "B" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "F" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerI)
                                        .Column(Column.AwayScore),


                                    // Player J
                                    new Border()
                                    {
                                        Content = new Label() { Text = "J:" }
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.Players),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.PlayerTotals),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "C" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "G" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.PlayerJ)
                                        .Column(Column.AwayScore),


                                    // Home Sign Off / Frame 14
                                    new Border()
                                    {
                                        Content = new Label() { Text = "Captains Signature" }
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.Players)
                                        .RowSpan(2),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "Team Total" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.PlayerTotals)
                                        .RowSpan(2),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "D" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "H" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame14)
                                        .Column(Column.AwayScore),


                                    // Home Sign Off / Frame 15
                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame15)
                                        .Column(Column.HomeScore),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "E" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame15)
                                        .Column(Column.HomePlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "v" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame15)
                                        .Column(Column.Vs),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "I" }
                                            .CenterHorizontal()
                                    }
                                        .Row(Row.Frame15)
                                        .Column(Column.AwayPlayer),

                                    new Border()
                                    {
                                        Content = new Label() { Text = "" }
                                    }
                                        .Row(Row.Frame15)
                                        .Column(Column.AwayScore)

                                }

                            }

                        },

                        new Button()
                            .Text("Submit")
                            .Invoke(x => x.Clicked += OnSubmitClicked)
                            .CenterHorizontal()

                    }
                }
            };
        }

        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            if (await Model.Submit())
            {
                ((Button)sender).IsEnabled = false;
            }
        }

    }

}
