using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

using Twilio;
using Twilio.Rest.Api.V2010.Account;

using Discord;
using Discord.Webhook;

namespace Time_Sheet
{
    public partial class Form1 : Form
    {
        private const string accoundSid = "AC94a7bed8ef46325ab91fc8fc37be6fee";
        private const string authToken = "9bad01731849d921be57d4ed0d27ccc8";

        private DateTime startTime;
        private DateTime endTime;

        private System.Windows.Forms.TextBox[] dailyHourTotals = new System.Windows.Forms.TextBox[7];
        private System.Windows.Forms.TextBox[] dailyTimes = new System.Windows.Forms.TextBox[7];
        private System.Windows.Forms.TextBox[] dailyEndTimes = new System.Windows.Forms.TextBox[7];

        public Form1()
        {
            InitializeComponent();

            ThursdayTimes.Text = "00:00:00 AM";
            FridayTimes.Text = "00:00:00 AM";
            SaturdayTimes.Text = "00:00:00 AM";
            SundayTimes.Text = "00:00:00 AM";
            MondayTimes.Text = "00:00:00 AM";
            TuesdayTimes.Text = "00:00:00 AM";
            WednesdayTimes.Text = "00:00:00 AM";

            ThursdayEndTimes.Text = "00:00:00 AM";
            FridayEndTimes.Text = "00:00:00 AM";
            SaturdayEndTimes.Text = "00:00:00 AM";
            SundayEndTimes.Text = "00:00:00 AM";
            MondayEndTimes.Text = "00:00:00 AM";
            TuesdayEndTimes.Text = "00:00:00 AM";
            WednesdayEndTimes.Text = "00:00:00 AM";

            ThursdayTotal.Text = "00:00:00";
            FridayTotal.Text = "00:00:00";
            SaturdayTotal.Text = "00:00:00";
            SundayTotal.Text = "00:00:00";
            MondayTotal.Text = "00:00:00";
            TuesdayTotal.Text = "00:00:00";
            WednesdayTotal.Text = "00:00:00";

            TotalWeeklyHours.Text = "00:00:00";

            dailyTimes[0] = ThursdayTimes;
            dailyTimes[1] = FridayTimes;
            dailyTimes[2] = SaturdayTimes;
            dailyTimes[3] = SundayTimes;
            dailyTimes[4] = MondayTimes;
            dailyTimes[5] = TuesdayTimes;
            dailyTimes[6] = WednesdayTimes;

            dailyEndTimes[0] = ThursdayEndTimes;
            dailyEndTimes[1] = FridayEndTimes;
            dailyEndTimes[2] = SaturdayEndTimes;
            dailyEndTimes[3] = SundayEndTimes;
            dailyEndTimes[4] = MondayEndTimes;
            dailyEndTimes[5] = TuesdayEndTimes;
            dailyEndTimes[6] = WednesdayEndTimes;

            dailyHourTotals[0] = ThursdayTotal;
            dailyHourTotals[1] = FridayTotal;
            dailyHourTotals[2] = SaturdayTotal;
            dailyHourTotals[3] = SundayTotal;
            dailyHourTotals[4] = MondayTotal;
            dailyHourTotals[5] = TuesdayTotal;
            dailyHourTotals[6] = WednesdayTotal;

            loadContentFromFile();
            startTime = DateTime.Parse(WednesdayTimes.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTimeDayPicker();
        }
        
        private void startTimeDayPicker()
        {
            startTime = DateTime.Now;
            string startTimeText = startTime.ToString("T");
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Thursday":
                    ThursdayTimes.Text = startTimeText;
                    break;
                case "Friday":
                    FridayTimes.Text = startTimeText;
                    break;
                case "Saturday":
                    SaturdayTimes.Text = startTimeText;
                    break;
                case "Sunday":
                    SundayTimes.Text = startTimeText;
                    break;
                case "Monday":
                    MondayTimes.Text = startTimeText;
                    break;
                case "Tuesday":
                    TuesdayTimes.Text = startTimeText;
                    break;
                case "Wednesday":
                    WednesdayTimes.Text = startTimeText;
                    break;
                default:
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            endTimeDayPicker();
            dayTotalCalculator();
            updateTotalWeeklyHours();
            updateLoadFile();
        }

        private void endTimeDayPicker()
        {
            endTime = DateTime.Now;
            string endTimeText = endTime.ToString("T");
            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Thursday":
                    ThursdayEndTimes.Text = endTimeText;
                    break;
                case "Friday":
                    FridayEndTimes.Text = endTimeText;
                    break;
                case "Saturday":
                    SaturdayEndTimes.Text = endTimeText;
                    break;
                case "Sunday":
                    SundayEndTimes.Text = endTimeText;
                    break;
                case "Monday":
                    MondayEndTimes.Text = endTimeText;
                    break;
                case "Tuesday":
                    TuesdayEndTimes.Text = endTimeText;
                    break;
                case "Wednesday":
                    WednesdayEndTimes.Text = endTimeText;
                    break;
                default:
                    break;
            }
        }

        private void dayTotalCalculator()
        {
            TimeSpan duration = endTime - startTime;
            TimeSpan durationFormatted = new TimeSpan(duration.Hours, duration.Minutes, duration.Seconds);

            switch (DateTime.Today.DayOfWeek.ToString())
            {
                case "Thursday":
                    ThursdayTotal.Text = durationFormatted.ToString();
                    break;
                case "Friday":
                    FridayTotal.Text = durationFormatted.ToString();
                    break;
                case "Saturday":
                    SaturdayTotal.Text = durationFormatted.ToString();
                    break;
                case "Sunday":
                    SundayTotal.Text = durationFormatted.ToString();
                    break;
                case "Monday":
                    MondayTotal.Text = durationFormatted.ToString();
                    break;
                case "Tuesday":
                    TuesdayTotal.Text = durationFormatted.ToString();
                    break;
                case "Wednesday":
                    WednesdayTotal.Text = durationFormatted.ToString();
                    break;
                default:
                    break;
            }
        }

        private void updateTotalWeeklyHours()
        {
            TimeSpan thursdayHours = TimeSpan.Parse(ThursdayTotal.Text);
            TimeSpan fridayHours = TimeSpan.Parse(FridayTotal.Text);
            TimeSpan saturdayHours = TimeSpan.Parse(SaturdayTotal.Text);
            TimeSpan sundayHours = TimeSpan.Parse(SundayTotal.Text);
            TimeSpan mondayHours = TimeSpan.Parse(MondayTotal.Text);
            TimeSpan tuesdayHours = TimeSpan.Parse(TuesdayTotal.Text);
            TimeSpan wednesdayHours = TimeSpan.Parse(WednesdayTotal.Text);

            TimeSpan duration = TimeSpan.Zero;
            duration += thursdayHours + fridayHours + saturdayHours + sundayHours + mondayHours + tuesdayHours + wednesdayHours;
            double hours = Math.Truncate(duration.TotalHours);
            string[] spltDuration = duration.ToString().Split(':');
            string minutes = spltDuration[1];
            string seconds = spltDuration[2];
            TotalWeeklyHours.Text = hours.ToString() + ":" + minutes + ":" + seconds;
        }

        private void updateLoadFile()
        {
            File.WriteAllText("../load.txt", String.Empty);
            using (StreamWriter writer = new StreamWriter("../load.txt"))
            {
                for (int i = 0; i < dailyTimes.Length; i++)
                {
                    writer.WriteLine(dailyTimes[i].Text.ToString());
                }

                for (int i = 0; i < dailyEndTimes.Length; i++)
                {
                    writer.WriteLine(dailyEndTimes[i].Text.ToString());
                }

                for (int i = 0; i < dailyHourTotals.Length; i++)
                {
                    writer.WriteLine(dailyHourTotals[i].Text.ToString());
                }

                writer.WriteLine(TotalWeeklyHours.Text.ToString());
            }
        }

        private void loadContentFromFile()
        {
            string[] linesInFile = File.ReadAllLines("../load.txt");
            for (int i = 0; i < dailyTimes.Length; i++)
            {
                dailyTimes[i].Text = linesInFile[i];
            }
            for (int i = 0; i < dailyEndTimes.Length; i++)
            {
                dailyEndTimes[i].Text = linesInFile[i + 7];
            }
            for (int i = 0; i < dailyHourTotals.Length; i++)
            {
                dailyHourTotals[i].Text = linesInFile[i + 14];
            }

            TotalWeeklyHours.Text = linesInFile[21];
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaturdayTimes_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            string desctiption = richTextBox1.Text;
            string formattedMessage = "Thursday: " + ThursdayTimes.Text + " - " + ThursdayEndTimes.Text +
                                        "\nFriday: " + FridayTimes.Text + " - " + FridayEndTimes.Text +
                                        "\nSaturday: " + SaturdayTimes.Text + " - " + SaturdayEndTimes.Text +
                                        "\nSunday: " + SundayTimes.Text + " - " + SundayEndTimes.Text +
                                        "\nMonday: " + MondayTimes.Text + " - " + MondayEndTimes.Text +
                                        "\nTuesday: " + TuesdayTimes.Text + " - " + TuesdayEndTimes.Text +
                                        "\nWednesday: " + WednesdayTimes.Text + " - " + WednesdayEndTimes.Text +
                                        "\n\nTOTAL HOURS WORKED: " + TotalWeeklyHours.Text +
                                        "\n\nDescription: " + desctiption;
            DiscordWebhookClient webhook = new DiscordWebhookClient("https://discord.com/api/webhooks/1205028106151268383/_zb0qb8_vBISYwJXaRH19ZJyegk9s6OGl7ix3urvGguGrweaLDmME-DoR8i75CooAyiX");
            webhook.SendMessageAsync(formattedMessage);
            //TwilioClient.Init(accoundSid, authToken);
            //var message = MessageResource.Create(
            //    body: "Hello, World!",
            //    from: new Twilio.Types.PhoneNumber("+18888517279"),
            //    to: new Twilio.Types.PhoneNumber("+18434331418"));
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
