using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    internal static class Nav
    {
        public static MainMenu Menu;
        public static bool Switching;

        public static void Open(Form form)
        {
            form.FormClosed += (s, e) =>
            {
                if (!Switching && Menu != null && !Menu.IsDisposed)
                {
                    Menu.Show();
                }
            };
            form.Show();
        }

        public static void Go(Form from, Form to)
        {
            Open(to);
            Switching = true;
            from.Close();
            Switching = false;
        }

        public static void LogOut(Form from)
        {
            Switching = true;
            from.Close();
            Switching = false;

            if (Menu != null && !Menu.IsDisposed)
            {
                Menu.PerformLogout();
            }
        }
    }
}