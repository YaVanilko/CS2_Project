using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI
{
    interface IUserNotify
    {
        void ShowError(string text, string header);
        void ShowWarning(string text, string header);
        void ShowInfo(string text, string header);
        bool ShowYesNo(string text, string header);
    }
}
