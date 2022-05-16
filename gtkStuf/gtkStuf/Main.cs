using Gtk;
using Graphics;
using Engine;


namespace Main
{
    class DescGen
    {
        private static GUI gui;
        public static Creator creator;

        public static void Main()
        {
            Application.Init();
            creator = new Creator();
            gui = new GUI();
            Application.Run();
        }
    }
}
