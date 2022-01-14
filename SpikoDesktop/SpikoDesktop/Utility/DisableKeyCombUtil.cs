using SpikoDesktop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Utility
{
    class DisableKeyCombUtil
    {
        private static DisableKeyCombUtil _instance;
        private DisableKeyCombUtil()
        {
            Logger.log.Info("prohibited keys are disabled");
            AddDisableKeys();
        }
        public static DisableKeyCombUtil GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DisableKeyCombUtil();
            }
            return _instance;
        }

        private Keys[] DisabledKeys;
        private void AddDisableKeys()
        {
            Keys copyCmd = Keys.Control | Keys.C;
            Keys cutCmd = Keys.Control | Keys.X;
            Keys pasteCmd = Keys.Control | Keys.V;
            Keys lStartBtn = Keys.LWin;
            Keys rStartBtn = Keys.RWin;
            Keys altF4Cmd = Keys.Alt | Keys.F4;
            DisabledKeys = new Keys[] { copyCmd, cutCmd, pasteCmd, lStartBtn, rStartBtn, altF4Cmd };
        }

        public Keys[] GetKeys()
        {
            return DisabledKeys;
        }
    }
}
