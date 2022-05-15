using Gtk;
using Main;
using System;

namespace Graphics
{
    partial class GUI : Window
    {
        private Fixed fix;

        private Label artistLabel;
        private Entry artistField;

        private Label downloadLabel;
        private Entry downloadLinkField;

        private Label trackLabel;
        private Entry trackField;

        private Label copyrightLabel;
        private Entry copyrightField;

        private Label labelLabel;
        private Entry labelField;

        private Label artworkLinkLabel;
        private Entry artworkLinkField;

        private Label genreLabel;
        private Entry genreField;

        private Label artworkArtistLinkLabel;
        private Entry artworkArtistLinkField;

        private Label linksLabel;
        private TextView linksArea;

        private Label playlistLabel;
        private Entry playlistField;

        private Button createButton;

        private Label titleLabel;

        private FileChooserDialog fileChooser;

        public GUI() : base("Description Generator")
        {
            SetDefaultSize(500, 600);
            SetPosition(WindowPosition.Center);
            DeleteEvent += delegate { Application.Quit(); };

            fix = new Fixed();

            artistLabel = new Label("Artist");
            fix.Put(artistLabel, 30, 50);

            artistField = new Entry();
            artistField.SetSizeRequest(200, 20);
            fix.Put(artistField, 25, 75);

            downloadLabel = new Label("Download Link");
            fix.Put(downloadLabel, 280, 50);

            downloadLinkField = new Entry();
            downloadLinkField.SetSizeRequest(200, 20);
            fix.Put(downloadLinkField, 275, 75);

            trackLabel = new Label("Track");
            fix.Put(trackLabel, 30, 125);

            trackField = new Entry();
            trackField.SetSizeRequest(200, 20);
            fix.Put(trackField, 25, 150);

            copyrightLabel = new Label("Copyright");
            fix.Put(copyrightLabel, 280, 125);

            copyrightField = new Entry();
            copyrightField.SetSizeRequest(200, 20);
            fix.Put(copyrightField, 275, 150);

            labelLabel = new Label("Label");
            fix.Put(labelLabel, 30, 200);

            labelField = new Entry();
            labelField.SetSizeRequest(200, 20);
            fix.Put(labelField, 25, 225);

            artworkLinkLabel = new Label("Artwork");
            fix.Put(artworkLinkLabel, 280, 200);

            artworkLinkField = new Entry();
            artworkLinkField.SetSizeRequest(200, 20);
            fix.Put(artworkLinkField, 275, 225);

            genreLabel = new Label("Genre");
            fix.Put(genreLabel, 30, 275);

            genreField = new Entry();
            genreField.SetSizeRequest(200, 20);
            fix.Put(genreField, 25, 300);

            artworkArtistLinkLabel = new Label("Artist (artwork)");
            fix.Put(artworkArtistLinkLabel, 280, 275);

            artworkArtistLinkField = new Entry();
            artworkArtistLinkField.SetSizeRequest(200, 20);
            fix.Put(artworkArtistLinkField, 275, 300);

            linksLabel = new Label("Links (artist, label, artwork)");
            fix.Put(linksLabel, 30, 350);

            linksArea = new TextView();
            linksArea.SetSizeRequest(450, 125);
            fix.Put(linksArea, 25, 375);

            playlistLabel = new Label("Playlist link");
            fix.Put(playlistLabel, 30, 520);

            playlistField = new Entry();
            playlistField.SetSizeRequest(300, 20);
            fix.Put(playlistField, 25, 540);

            createButton = new Button("Create");
            createButton.SetSizeRequest(150, 50);
            createButton.Clicked += react;
            fix.Put(createButton, 330, 520);

            titleLabel = new Label("DESCRIPTION GENERATOR");
            titleLabel.SetSizeRequest(200, 30);
            fix.Put(titleLabel, 150, 10);

            Add(fix);
            ShowAll();
        }

        public void react(object sender, EventArgs args)
        {
            String[] info = new String[9];

            String artist = artistField.Text;
            String dl = downloadLinkField.Text;
            String track = trackField.Text;
            String copyright = copyrightField.Text;
            String label = labelField.Text;
            String artworkLinK = artworkLinkField.Text;
            String genre = genreField.Text;
            String artworkArtistLink = artworkArtistLinkField.Text;
            String links = linksArea.Buffer.Text;
            String playlist = playlistField.Text;
            String path = "";

            info[0] = artist;
            info[1] = track;
            info[2] = label;
            info[3] = genre;
            info[4] = dl;
            info[5] = links;
            info[6] = artworkArtistLink;
            info[7] = artworkLinK;
            info[8] = copyright;


            fileChooser = new FileChooserDialog("Choose filepath", this, FileChooserAction.SelectFolder, "Cancel", ResponseType.Cancel, "Open", ResponseType.Accept);

            if (fileChooser.Run() == (int)ResponseType.Accept)
            {
                //Console.WriteLine(fileChooser.Uri);
                String s = "file://";
                char[] reg = s.ToCharArray();
                String[] hoh = fileChooser.Uri.Split(reg); ;
                //Console.WriteLine(hoh[1]);
                path = hoh[1];
                Console.WriteLine(path);
            }

            fileChooser.Destroy();

            DescGen.creator.youtube_description(path, info);
            DescGen.creator.youtube_comment(path, genre, playlist);
            /*
             * artworkArtistLink = AL, artworkLinK = L, links = l, playlist = p
             */
            DescGen.creator.soundcloud_description(path, artist, track, label, genre, dl, artworkArtistLink, artworkLinK, links, playlist);
        }
    }
}