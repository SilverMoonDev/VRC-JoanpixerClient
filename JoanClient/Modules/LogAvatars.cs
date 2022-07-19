using PasteBin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenClient.Modules
{
    internal class LogAvatars
    {
        internal static string lastavi;
        internal static void Upload()
        {
            var client = new PasteBinClient("KDvoxygNoZS-ljwI082K5iejw0RJObMB");

            // Optional; will publish as a guest if not logged in
            client.Login("Joanpixel", "123redjoanCOB");

            var entry = new PasteBinEntry
            {
                Title = "PasteBin client test",
                Text = "Console.WriteLine(\"Hello PasteBin\");",
                Expiration = PasteBinExpiration.Never,
                Private = true,
                Format = "text"
            };

            string pasteUrl = client.Paste(entry);
            Console.WriteLine("Your paste is published at this URL: " + pasteUrl);
            LogAvatars.lastavi = Utils.CurrentUser.prop_Player_0.prop_ApiAvatar_0.id;
        }
    }
}
