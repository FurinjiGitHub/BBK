﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;

namespace BBK
{
    public partial class KickOffTable5 : PhoneApplicationPage
    {
        public KickOffTable5()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {

            Random satunnaisempi = new Random();
            int KickTableDice = satunnaisempi.Next(1, 7) + satunnaisempi.Next(1, 7);

            //int KickTableDice = new Random().Next(2, 13);
            //Pelissä heitetään tässä kohtaa kahta kuusitahoista noppaa ja lasketaan niiden summa ja verrataan sitä taulukon tulokseen
            //Tämän vuoksi jälkimmäinen koodirivi antaisi väärän todennäköisyyden vaihtoehdoille

            if (KickTableDice == 2)
            {
                KickOffTitle.Text = "2. Get the Ref";
                KickOffBlock.Text = "The fans exact gruesome revenge on the referee for some of the dubious decisions he has made. His replacement is so intimidated that he can be more easily persuaded to look the other way. Each team receives 1 additional Bribe to use during this game. A Bribe allows you to attempt to ignore one call by the referee for a player who has committed a foul to be sent off, or a player armed with a secret weapon to be banned from the match. Roll a D6: on a roll of 2-6 the bribe is effective, but on a roll of 1 the bribe is wasted and the call still stands! Each bribe may be used once per match.";
            }

            else if (KickTableDice == 3)
            {
                KickOffTitle.Text = "3. Riot";
                KickOffBlock.Text = "The trash talk between two opposing players explodes and rapidly degenerates, involving the rest of the players. If the receiving team's turn marker is on turn 7 for the half, both teams move their turn marker back  one space as the referee resets the clock back to before  the fight started. If the receiving team has not yet taken a turn this half the referee lets the clock run on during the  fight and both teams' turn markers are moved forward one space. Otherwise roll a D6. On a 1-3, both teams' turn markers are moved forward one space. On a 4-6, both team's turn markers are moved back one space.";
            }

            else if (KickTableDice == 4)
            {
                KickOffTitle.Text = "4. Perfect Defence";
                KickOffBlock.Text = "The kicking team reorganize his players - in other words he can set them up again into another legal defence. The receiving team must remain in the set-up chosen by their coach.";
            }

            else if (KickTableDice == 5)
            {
                KickOffTitle.Text = "5. High Kick";
                KickOffBlock.Text = "The ball is kicked very high, allowing a player on the receiving team time to move into the perfect position to catch it. Any one player on the receiving team who is not in an opposing player's tackle zone may be moved into the square where the ball will land no matter what their MA may be, as long as the square is unoccupied.";
            }

            else if (KickTableDice == 6)
            {
                KickOffTitle.Text = "6. Cheering Fans";
                KickOffBlock.Text = "Each coach rolls a D3 and adds their team's FAME and the number of cheerleaders on their team to the score. The team with the highest score is inspired by their fans' cheering and gets an extra re-roll this half. If both teams have the same score, then both teams get a re-roll.";

                //Lisätään käyttäjälle muistutus aikaisemmilla sivuilla saadusta tiedosta
                if (IsolatedStorageSettings.ApplicationSettings.Contains("userData"))
                {
                    KickOffBlock.Text += "\r\n \r\n (Reminder: " +
                    IsolatedStorageSettings.ApplicationSettings["userData"] as string + ")";
                }
            }

            else if (KickTableDice == 7)
            {

                KickOffTitle.Text = "7. Changing Weather";
                KickOffBlock.Text = "Make a new roll on the Weather table. Apply the new Weather roll. If the new Weather roll was a 'Nice' result, then a gentle gust of wind makes the ball scatter one extra square in a random direction before landing. (Don't worry we will remind you.) \r\n \r\n New Weather Condition: \r\n \r\n";

                //Säätila on arvottava uudelleen tämän tuloksen myötä, joten lisätään uusi tulos tekstikentän jatkoksi
                int WeatherDice = satunnaisempi.Next(1, 7) + satunnaisempi.Next(1, 7);

                IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

                //Tallennetaan noppatulos, sillä sillä voi olla vaikutusta myöhempien sivujen valintoihin
                if (!settings.Contains("userData4"))
                {
                    settings.Add("userData4", WeatherDice.ToString());
                   
                }
                else
                {
                    settings["userData4"] = WeatherDice.ToString();
                   
                }
                settings.Save();

                if (WeatherDice == 2)
                {
                    KickOffBlock.Text += "2. Sweltering Heat";
                    KickOffBlock.Text += ": It's so hot and humid some players collapse from heat exhaustion. Roll a D6 for each player on the pitch at the end of a drive. On a roll of 1 the player collapses and may not be set up for the next Kick-Off.";               
                }

                else if (WeatherDice == 3)
                {
                    KickOffBlock.Text += "3. Very Sunny";
                    KickOffBlock.Text += ": A glorious day, but the blinding sunshine causes a -1 modifier on all passing rolls";
                }

                else if (WeatherDice == 11)
                {
                    KickOffBlock.Text += "11. Pouring Rain";
                    KickOffBlock.Text += ": It's raining, making the ball slippery and difficult to hold. A -1 modifier applies to all catch, intercept, or pick-up rolls.";
                }

                else if (WeatherDice == 12)
                {
                    KickOffBlock.Text += "12. Blizzard";
                    KickOffBlock.Text += ": It's cold and snowing! The ice on the pitch means that any player attempting to move an extra square (GFI) will slip and be Knocked Down on a roll of 1-2, while the snow means that only quick or short passes can be attempted.";
                }

                else
                {
                    KickOffBlock.Text += "4-10. Nice";
                    KickOffBlock.Text += ": Perfect Blood Bowl Weather.";
                }
                
            }

            else if (KickTableDice == 8)
            {
                KickOffTitle.Text = "8. Brilliant Coaching";
                KickOffBlock.Text = "Each coach rolls a D3 and adds their FAME and the number of assistant coaches on their team to the score. The team with the highest total gets an extra team re-roll this half thanks to the brilliant instruction provided by the coaching staff. In case of a tie both teams get an extra team re-roll.";

                //Lisätään käyttäjälle muistutus aikaisemmilla sivuilla saadusta tiedosta
                if (IsolatedStorageSettings.ApplicationSettings.Contains("userData"))
                {
                    KickOffBlock.Text += "\r\n \r\n (Reminder: " +
                    IsolatedStorageSettings.ApplicationSettings["userData"] as string + ")";
                }

            }

            else if (KickTableDice == 9)
            {
                KickOffTitle.Text = "9. Quick Snap!";
                KickOffBlock.Text = "The offence start their drive a fraction of time before the defence is ready, catching the kicking team flat-footed. All of the players on the receiving team are allowed to move one square. This is a free move and may be made into any adjacent empty square, ignoring tackle zones. It may be used to enter the opposing half of the pitch.";
            }

            else if (KickTableDice == 10)
            {
                KickOffTitle.Text = "10. Blitz!";
                KickOffBlock.Text = "The defence start their drive a fraction of time before the offence is ready, catching the receiving team flat-footed tackle zone at the beginning of this free 'bonus' turn. However, players that are in an enemy tackle zone at the beginning of this free turn may not perform an Action. The kicking team may use team re-rolls during a Blitz. If any player suffers a turnover then the bonus turn ends immediately.";
            }

            else if (KickTableDice == 11)
            {
                KickOffTitle.Text = "11. Throw a Rock";
                KickOffBlock.Text = "An enraged fan hurls a large rock at one of the players on the opposing team. Each coach rolls a D6 and adds their FAME (see page 18) to the roll. The fans of the team that rolls higher are the ones that threw the rock. In the case of a tie a rock is thrown at each team! Decide randomly which player in the other team was hit (only players on the pitch are eligible) and roll for the effects of the injury straight away. No Armour roll is required.";
            }

            else if (KickTableDice == 12)
            {
                KickOffTitle.Text = "12. Pitch Invasion";
                KickOffBlock.Text = "Both coaches roll a D6 for each opposing player on the pitch and add their FAME to the roll. If a roll is 6 or more after modification then the player is Stunned (players with the Ball & Chain skill are KO'd). A roll of 1 before adding FAME will always have no effect.";

                //Lisätään käyttäjälle muistutus aikaisemmilla sivuilla saadusta tiedosta
                if (IsolatedStorageSettings.ApplicationSettings.Contains("userData"))
                {
                    KickOffBlock.Text += "\r\n \r\n (Reminder: " +
                    IsolatedStorageSettings.ApplicationSettings["userData"] as string + ")";
                }

            }

            else
            {
                KickOffBlock.Text = "Oops, Goblins broke something!";
            }
        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            //Seuraavalle sivulle liikkumisen yhteydessä tallennetaan taulukon tiedot myöhempää yhteenvetoa varten
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;

            if (!settings.Contains("userData3"))
            {
            
                settings.Add("userData3", KickOffTitle.Text + " - " + KickOffBlock.Text);
            }
            else
            {
          
                settings["userData3"] = KickOffTitle.Text + " - " + KickOffBlock.Text;
            }
            settings.Save();
        }

    }
}