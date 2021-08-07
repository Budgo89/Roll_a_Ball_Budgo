using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace Assets.Scripts.Editor
{
    public class MenuItems
    {
        [MenuItem("Budgo/Пункт меню №1 ")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "Budgo");
        }
    }

}
