using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TwitchLib;

namespace ArenaDraftBot
{
    public partial class mainWindow : DevExpress.XtraEditors.XtraForm
    {
        Util util = new Util();
        ConnectionCredentials connCredentials;
        TwitchClient twitchClient;

        List<int> votedUser;

        string botUsername;
        string botOAuth;
        string twitchChannel;

        bool isConnected = false;
        bool isDrafting = false;
        bool isPicking = false;

        double timeLeft;

        int currentPick = 0;
        int scoreCard1 = 0;
        int scoreCard2 = 0;
        int scoreCard3 = 0;

        public mainWindow()
        {
            InitializeComponent();
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            util.loadSettings(this);
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            util.saveSettings(this);
        }

        private void lbBotOAuth_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            e.Link = "https://twitchapps.com/tmi/";
            System.Diagnostics.Process.Start(e.Link);
        }

        private void lbCopyright_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            e.Link = "https://github.com/0x2aff/";
            System.Diagnostics.Process.Start(e.Link);
        }

        private void tbConfigs_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBotUsername.Text) || string.IsNullOrWhiteSpace(tbOAuth.Text)
                || string.IsNullOrWhiteSpace(tbTwitchChannel.Text))
                btConnect.Enabled = false;
            else
                btConnect.Enabled = true;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if(!isConnected)
            {
                botUsername = tbBotUsername.Text;
                botOAuth = tbOAuth.Text;
                twitchChannel = tbTwitchChannel.Text;

                connCredentials = new ConnectionCredentials(botUsername, botOAuth);
                twitchClient = new TwitchClient(connCredentials, twitchChannel, '!', '!', false);

                twitchClient.OnConnected += clientConnected;
                twitchClient.OnJoinedChannel += clientJoinedChannel;
                twitchClient.OnDisconnected += clientDisconnected;
                twitchClient.OnClientLeftChannel += clientLeftChannel;

                twitchClient.OnChatCommandReceived += chatCommandReceived;

                twitchClient.Connect();

                tbBotUsername.Enabled = false;
                tbOAuth.Enabled = false;
                tbTwitchChannel.Enabled = false;

                btConnect.Enabled = false;
                btConnect.Text = "Connecting";
            }
            else
            {
                isDrafting = false;
                timePick.Enabled = true;

                currentPick = 0;
                scoreCard1 = 0;
                scoreCard2 = 0;
                scoreCard3 = 0;
                lbCard1.Text = "0";
                lbCard2.Text = "0";
                lbCard3.Text = "0";

                btStopDraft.Enabled = false;
                btStartDraft.Enabled = true;

                pickTimer.Stop();
                draftTimer.Stop();

                File.WriteAllText("scoreCard1.txt", scoreCard1.ToString());
                File.WriteAllText("scoreCard2.txt", scoreCard2.ToString());
                File.WriteAllText("scoreCard3.txt", scoreCard3.ToString());
                File.WriteAllText("timeLeft.txt", timeLeft.ToString() + " Sekunde(n)");

                twitchClient.SendMessage("Ohh Neeein! Ich verliere die Verbindung ... Abstimmung beendet.");

                twitchClient.LeaveChannel(tbTwitchChannel.Text);               

                btConnect.Enabled = false;
                btConnect.Text = "Disconnecting";
            }
        }

        private void clientConnected(object sender, TwitchClient.OnConnectedArgs e)
        {
            isConnected = true;
            Console.WriteLine(e.Username + " successfully connected.");
        }

        private void clientDisconnected(object sender, TwitchClient.OnDisconnectedArgs e)
        {
            Console.WriteLine(e.Username + " successfully disconnected.");
        }

        private void clientJoinedChannel(object sender, TwitchClient.OnJoinedChannelArgs e)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                btConnect.Enabled = true;
                btConnect.Text = "Disconnect";

                btStartDraft.Enabled = true;
            }));

            Console.WriteLine("Client joined channel: " + e.Channel);
        }

        private void clientLeftChannel(object sender, TwitchClient.OnClientLeftChannelArgs e)
        {
            Console.WriteLine("Client left channel: " + e.Channel);

            this.Invoke((MethodInvoker)(() =>
            {
                tbBotUsername.Enabled = true;
                tbOAuth.Enabled = true;
                tbTwitchChannel.Enabled = true;

                btConnect.Enabled = true;
                btConnect.Text = "Connect";
            }));

            twitchClient.Disconnect();
            isConnected = false;
        }

        private void chatCommandReceived(object sender, TwitchClient.OnChatCommandReceivedArgs e)
        {
            switch(e.Command.Command)
            {
                case "vote":
                    if(isDrafting)
                    {
                        if(currentPick % 2 == 0)
                        {
                            if (e.Command.ArgumentsAsList.Count > 1 || e.Command.ArgumentsAsList.Count == 0) break;
                            switch (e.Command.ArgumentsAsList[0])
                            {
                                case "1":
                                    if (votedUser.Contains(e.Command.ChatMessage.UserId))
                                    {
                                        twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur eine Stimme pro Pick erlaubt.");
                                        break;
                                    }
                                    votedUser.Add(e.Command.ChatMessage.UserId);
                                    scoreCard1++;
                                    break;
                                case "2":
                                    if (votedUser.Contains(e.Command.ChatMessage.UserId))
                                    {
                                        twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur eine Stimme pro Pick erlaubt.");
                                        break;
                                    }
                                    votedUser.Add(e.Command.ChatMessage.UserId);
                                    scoreCard2++;
                                    break;
                                case "3":
                                    if (votedUser.Contains(e.Command.ChatMessage.UserId))
                                    {
                                        twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur eine Stimme pro Pick erlaubt.");
                                        break;
                                    }
                                    votedUser.Add(e.Command.ChatMessage.UserId);
                                    scoreCard3++;
                                    break;
                                default:
                                    twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur !vote 1, !vote 2 oder !vote 3 erlaubt.");
                                    break;
                            }
                        }
                        else
                        {
                            if (e.Command.ArgumentsAsList.Count > 1 || e.Command.ArgumentsAsList.Count == 0) break;
                            switch (e.Command.ArgumentsAsList[0])
                            {
                                case "a":
                                    if (votedUser.Contains(e.Command.ChatMessage.UserId))
                                    {
                                        twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur eine Stimme pro Pick erlaubt.");
                                        break;
                                    }
                                    votedUser.Add(e.Command.ChatMessage.UserId);
                                    scoreCard1++;
                                    break;
                                case "b":
                                    if (votedUser.Contains(e.Command.ChatMessage.UserId))
                                    {
                                        twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur eine Stimme pro Pick erlaubt.");
                                        break;
                                    }
                                    votedUser.Add(e.Command.ChatMessage.UserId);
                                    scoreCard2++;
                                    break;
                                case "c":
                                    if (votedUser.Contains(e.Command.ChatMessage.UserId))
                                    {
                                        twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur eine Stimme pro Pick erlaubt.");
                                        break;
                                    }
                                    votedUser.Add(e.Command.ChatMessage.UserId);
                                    scoreCard3++;
                                    break;
                                default:
                                    twitchClient.SendMessage("@" + e.Command.ChatMessage.DisplayName + "," + "nur !vote a, !vote b oder !vote c erlaubt.");
                                    break;
                            }
                        }
                    }
                    break;
                case "dev":
                    twitchClient.SendMessage("2016 © exceptionptr");
                    break;
                default:
                    break;
            }
        }

        private void btStartDraft_Click(object sender, EventArgs e)
        {
            isDrafting = true;
            votedUser = new List<int>();

            btStartDraft.Enabled = false;
            timePick.Enabled = false;

            timeLeft = timePick.TimeSpan.TotalSeconds;

            currentPick = 0;
            scoreCard1 = 0;
            scoreCard2 = 0;
            scoreCard3 = 0;
            lbCard1.Text = "0";
            lbCard2.Text = "0";
            lbCard3.Text = "0";

            currentPick++;
            twitchClient.SendMessage("Pick #" + currentPick + " (!vote a, !vote b oder !vote c)");

            pickTimer.Start();
            draftTimer.Start();

            btStopDraft.Enabled = true;
        }

        private void btNextPick_Click(object sender, EventArgs e)
        {
            isDrafting = true;
            votedUser = new List<int>();

            btStartDraft.Enabled = false;
            timePick.Enabled = false;

            scoreCard1 = 0;
            scoreCard2 = 0;
            scoreCard3 = 0;
            lbCard1.Text = "0";
            lbCard2.Text = "0";
            lbCard3.Text = "0";

            timeLeft = timePick.TimeSpan.TotalSeconds;
            pickTimer.Start();
            draftTimer.Start();

            currentPick++;
            if(currentPick % 2 == 0)
                twitchClient.SendMessage("Pick #:" + currentPick + " (!vote 1, !vote 2 oder !vote 3)");
            else
                twitchClient.SendMessage("Pick #:" + currentPick + " (!vote a, !vote b oder !vote c)");

            btNextPick.Enabled = false;
        }

        private void btStopDraft_Click(object sender, EventArgs e)
        {
            isDrafting = false;
            timePick.Enabled = true;

            currentPick = 0;
            scoreCard1 = 0;
            scoreCard2 = 0;
            scoreCard3 = 0;
            lbCard1.Text = "0";
            lbCard2.Text = "0";
            lbCard3.Text = "0";

            btStopDraft.Enabled = false;
            btStartDraft.Enabled = true;

            pickTimer.Stop();
            draftTimer.Stop();

            File.WriteAllText("scoreCard1.txt", scoreCard1.ToString());
            File.WriteAllText("scoreCard2.txt", scoreCard2.ToString());
            File.WriteAllText("scoreCard3.txt", scoreCard3.ToString());
            File.WriteAllText("timeLeft.txt", timeLeft.ToString() + " Sekunde(n)");

            twitchClient.SendMessage("Abstimmung beendet.");
        }

        private void pickTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft >= 0)
            {
                isPicking = true;
                lbCard1.Text = scoreCard1.ToString();
                lbCard2.Text = scoreCard2.ToString();
                lbCard3.Text = scoreCard3.ToString();

                timeLeft--;
                lbTimeLeft.Text = "Time left: " + timeLeft + "s";
            }
            else
            {
                pickTimer.Stop();
                isPicking = false;

                if(currentPick > 29)
                {
                    isDrafting = false;
                    timePick.Enabled = true;

                    currentPick = 0;
                    scoreCard1 = 0;
                    scoreCard2 = 0;
                    scoreCard3 = 0;
                    lbCard1.Text = "0";
                    lbCard2.Text = "0";
                    lbCard3.Text = "0";

                    btStopDraft.Enabled = false;
                    btStartDraft.Enabled = true;

                    draftTimer.Stop();
                }
                else
                {
                    btNextPick.Enabled = true;
                }
            }  
        }

        private void draftTimer_Tick(object sender, EventArgs e)
        {
            if(isPicking)
            {
                File.WriteAllText("scoreCard1.txt", scoreCard1.ToString());
                File.WriteAllText("scoreCard2.txt", scoreCard2.ToString());
                File.WriteAllText("scoreCard3.txt", scoreCard3.ToString());
                File.WriteAllText("timeLeft.txt", timeLeft.ToString() + " Sekunde(n)");
            }
        }
    }
}
