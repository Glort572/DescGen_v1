using System;
using System.IO;
//using System.Threading.Tasks;

namespace Engine
{
    public class Creator
    {
        public void youtube_description(String path, String[] info)
        {
            String content = "";

            content += "Continuum Music Network, Quality Underground Music." + "\n\n";
            content += "-------------------------- OPEN FOR MORE INFO --------------------------" + "\n\n";
            content += "\U0001f3a4 Artist: " + info[0] + "\n";
            content += "\U0001f3b5 Track: " + info[1] + "\n";
            content += "\U0001f4bd Label: " + info[2] + "\n";
            content += "\U0001f3b6 Genre: " + info[3] + "\n";
            content += "\n";
            content += "\U0001f514 Subscribe and turn on notifications to never miss an upload!" + "\n";
            content += "\n\n";
            content += "\u00A9 " + info[8] + "\n";
            content += "Royalty-free music playlist: https://www.youtube.com/playlist?list=PLKIV5ZEHZDt0q-vcmCObxiZXJMXFxJ5fo" + "\n";
            content += "\n\n";
            content += "\U0001f3a7\U0001f4be Stream / Download: " + info[4] + "\n";
            content += "\n\n";
            content += "Support me on PayPal   ➡ https://paypal.me/GlortAkaContinuum" + "\n" + "Join my Discord server ➡ https://discord.gg/TRWRhbJp6W" + "\n\n\n";
            content += info[5] + "\n";
            content += "\n\n";

/*      In case I will start uploading artwork (REMOVE // AT THE BEGINNING IF YOU WANT TO MAKE THIS SECTION WORK!)

            content += "━━━━━━━━━━━━━━━━━━━" + "\n";
            content += "\uD83C\uDFA8Art by: " + info[6] + "\n" + info[7] + "\n";
            content += "━━━━━━━━━━━━━━━━━━━" + "\n";*/
            content += "\U0001f496 Follow Continuum Music Network" + "\n";
            content += "YouTube: " + "https://www.youtube.com/channel/UCtC_W6we0xiRaRW8T-iM9NA" + "\n";
            content += "SoundCloud: " + "https://soundcloud.com/continuummusicnetwork" + "\n";
            content += "PayPal: " + "https://paypal.me/GlortAkaContinuum" + "\n";
            content += "Discord: " + "https://discord.gg/TRWRhbJp6W" + "\n";
            content += "\n\n";
            content += "_________________________________________________________________________________________________\n\n";
            content += "\U0001f310 INVERSE COMMUNITY \U0001f310" + "\n";
            content += "\u2B50 Inverse: https://www.youtube.com/user/CorseNN" + "\n";
            content += "\u2B50 Continuum: https://www.youtube.com/channel/UCtC_W6we0xiRaRW8T-iM9NA" + "\n";
            content += "\u2B50 NekoEDMvibes: https://www.youtube.com/c/NekoEDMvibes" + "\n";
            content += "\u2B50 BreakTheBounce: https://www.youtube.com/channel/UC-tUwhiWLLRhv4WJjoJ0gsQ" + "\n";
            content += "\u2B50 MusicBlast: https://www.youtube.com/channel/UCggIYs7GSgHOePiMmcqQXqA" + "\n";
            content += "\u2B50 MG5902: https://www.youtube.com/channel/UCX_iwLh1nngg4Lapfu5w4Zw" + "\n";
            content += "\n";
            content += "\U0001f4ac Discord server: https://discord.gg/uJQA3D6" + "\n";
            content += "\n";
            content += "_________________________________________________________________________________________________\n\n";
            content += "\U0001f4c4 All demo submissions go to:" + "\n" + "https://forms.gle/MfUNFi86KG4LFY1o9" + "\n\n";
            content += "_________________________________________________________________________________________________\n\n";
            content += "\u26A0 IMPORTANT NOTE:\nIf any artist or label has an issue with any of the songs or wallpapers promoted here in this channel, send us an e-mail at triokolbaser@gmail.com and the content will be removed within 48 hours. Please do not flag our channel." + "\n\n";
            content += "_________________________________________________________________________________________________\n\n";
            content += "\U0001f4e2 Tags: #"+info[0]+" #"+info[1]+" #continuum #continuumedm #continuumrecords #continuummusicnetwork #qualityundergroundmusic #undergroundmusic #undergroundedm" + "\n";


            //Console.WriteLine(content);
            File.WriteAllText("D:\\Continuum Related\\Continuum Workspace\\Upload Texts\\AutoGenerator\\" + "youtube_description.txt", content);
        }

        public void youtube_comment(String path, String genre, String playlistLink)
        {
            String content = "";

            content += "Want more " + genre + " music like this? Check this playlist out ➡ " + playlistLink + "\n";
            content += "❤️ If you love the music I upload, I'd appreciate if you could check out my PayPal page and support the development of the channel.\n";
            content += "❤️ https://paypal.me/GlortAkaContinuum";

            File.WriteAllText("D:\\Continuum Related\\Continuum Workspace\\Upload Texts\\AutoGenerator\\" + "youtube_comment.txt", content);
        }

        public void soundcloud_description(String path, String artistName, String trackName, String label, String g, String dl, String AL, String L, String l, String p)
        {
            String content = "";
            content += "Continuum Music Network, Quality Underground Music." + "\n\n";
//            content += "❤️Join the channel to get some extra perks and content!❤️\n";
//            content += "❤️https://www.youtube.com/c/yumenetwork/join\n";
//            content += "\n";
            content += "Support me on PayPal   ➡ https://paypal.me/GlortAkaContinuum" + "\n" + "Join my Discord server ➡ https://discord.gg/TRWRhbJp6W" + "\n\n";
            content += "━━━━━━━━━━━━━━━━━━━\n";
            content += "\U0001f3a4 Artist: " + artistName + "\n";
            content += "\U0001f3b5 Track: " + trackName + "\n";
            content += "\U0001f4bd Label: " + label + "\n";
            content += "\U0001f3b6 Genre: " + g + "\n";
            content += "━━━━━━━━━━━━━━━━━━━\n";
            content += "\U0001f3a7\U0001f4be Stream / Download: " + dl + "\n";
            content += "━━━━━━━━━━━━━━━━━━━\n";
            content += "\uD83C\uDFA8Art by: " + AL + "\n" + L + "\n";
            content += "━━━━━━━━━━━━━━━━━━━\n";
            content += l + "\n";
            content += "\n\n";
            content += "\U0001f496 Follow Continuum Music Network" + "\n";
            content += "YouTube: " + "https://www.youtube.com/channel/UCtC_W6we0xiRaRW8T-iM9NA" + "\n";
            content += "SoundCloud: " + "https://soundcloud.com/continuummusicnetwork" + "\n";
            content += "PayPal: " + "https://paypal.me/GlortAkaContinuum" + "\n";
            content += "Discord: " + "https://discord.gg/TRWRhbJp6W" + "\n";
            content += "━━━━━━━━━━━━━━━━━━━\n";
            content += g + " playlist: " + p + "\n";
            content += "━━━━━━━━━━━━━━━━━━━\n";
            content += "Copyright/Claims/Issues: triokolbaser@gmail.com\n";
            content += "\n";


            File.WriteAllText("D:\\Continuum Related\\Continuum Workspace\\Upload Texts\\AutoGenerator\\" + "soundcloud_description.txt", content);
        }
    }
}