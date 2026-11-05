
using System.Drawing;
using System.Windows.Forms;

namespace Computer_Laboratory_Equipment
{
    public static class Theme
    {
        public static readonly Color Navy =
            Color.FromArgb(30, 58, 95);

        public static readonly Color Green =
            Color.FromArgb(34, 139, 94);

        public static readonly Color Red =
            Color.FromArgb(200, 55, 55);

        public static readonly Color Grey =
            Color.FromArgb(120, 120, 120);

        public static void Apply(Form form)
        {
            form.BackColor = Color.White;
            form.Font = new Font("Segoe UI", 9F);
        }

        public static void ApplyChildren(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 1;
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                }

                if (control.HasChildren)
                {
                    ApplyChildren(control);
                }
            }
        }

        public static void Primary(Button button, Color color)
        {
            button.BackColor = color;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }

        public static void SetEnabled(
            Button button,
            bool enabled,
            Color color)
        {
            button.Enabled = enabled;
            button.BackColor = enabled ? color : Grey;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
        }
    }
}
