using System;
using System.Drawing;
using System.Windows.Forms;

namespace FullScreenMode
{
    public class FullScreen
    {
        private readonly Form targetForm;

        private FormWindowState lastWindowState;

        private FormBorderStyle lastBorderStyle;

        private Rectangle lastBounds;

        private bool isFullScreen = false;

        public FullScreen(Form form)
            => targetForm = form;

        private void ToggleScreenMode()
        {
            if (!isFullScreen)
            {
                lastBorderStyle = targetForm.FormBorderStyle;
                lastBounds = targetForm.Bounds;
                lastWindowState = targetForm.WindowState;

                targetForm.Visible = false;

                HandleTaskBar.HideTaskBar();

                targetForm.FormBorderStyle = FormBorderStyle.None;
                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.Visible = true;
                isFullScreen = true;
            }
            else
            {
                targetForm.Visible = false;
                targetForm.WindowState = lastWindowState;
                targetForm.FormBorderStyle = lastBorderStyle;
                targetForm.Bounds = lastBounds;

                HandleTaskBar.ShowTaskBar();

                targetForm.Visible = true;
                isFullScreen = false;
            }
        }

        public void ToggleFullScreen() => ToggleScreenMode();

        public void ResetTaskBar() => HandleTaskBar.ShowTaskBar();
    }
}
