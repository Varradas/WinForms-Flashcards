using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcard_WinForm_App.Functions
{
    public interface INavigation
    {
        void ShowPage(UserControl page);
        void ResizeHost(int width, int height);
        void LockSize(bool lockSize);
    }
}
