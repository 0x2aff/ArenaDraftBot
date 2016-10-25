using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaDraftBot
{
    class Util
    {
        public void loadSettings(mainWindow mainWindow)
        {
            mainWindow.tbBotUsername.Text = Properties.Settings.Default.botUsername;
            mainWindow.tbOAuth.Text = Properties.Settings.Default.botOAuth;
            mainWindow.tbTwitchChannel.Text = Properties.Settings.Default.TwitchChannel;
            mainWindow.timePick.TimeSpan = Properties.Settings.Default.timePick;
            mainWindow.checkAutoPick.Checked = Properties.Settings.Default.autoPick;
        }

        public void saveSettings(mainWindow mainWindow)
        {
            Properties.Settings.Default.botUsername = mainWindow.tbBotUsername.Text;
            Properties.Settings.Default.botOAuth = mainWindow.tbOAuth.Text;
            Properties.Settings.Default.TwitchChannel = mainWindow.tbTwitchChannel.Text;
            Properties.Settings.Default.timePick = mainWindow.timePick.TimeSpan;
            Properties.Settings.Default.autoPick = mainWindow.checkAutoPick.Checked;

            Properties.Settings.Default.Save();
        }
    }
}
