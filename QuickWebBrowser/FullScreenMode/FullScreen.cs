using System;
using System.Drawing;
using System.Windows.Forms;

namespace FullScreenMode
{
    public class FullScreen
    {
        public FullScreen(Form form)
        {
            _Form = form;
            _FullScreen = false;
        }

        private void ScreenMode()
        {
            if (!_FullScreen)
            {
                _cBorderStyle = _Form.FormBorderStyle;
                _cBounds = _Form.Bounds;
                _cWindowState = _Form.WindowState;
                _Form.Visible = false;
                HandleTaskBar.HideTaskBar();
                _Form.FormBorderStyle = FormBorderStyle.None;
                _Form.WindowState = FormWindowState.Maximized;
                _Form.Visible = true;
                _FullScreen = true;
                return;
            }
            _Form.Visible = false;
            _Form.WindowState = _cWindowState;
            _Form.FormBorderStyle = _cBorderStyle;
            _Form.Bounds = _cBounds;
            HandleTaskBar.ShowTaskBar();
            _Form.Visible = true;
            _FullScreen = false;
        }

        public void ShowFullScreen()
        {
            ScreenMode();
        }

        public void ResetTaskBar()
        {
            HandleTaskBar.ShowTaskBar();
        }

        private Form _Form;

        private FormWindowState _cWindowState;

        private FormBorderStyle _cBorderStyle;

        private Rectangle _cBounds;

        private bool _FullScreen;
    }
}
