using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.MVC.Controllers
{
    [CreateAssetMenu(menuName = "Data/Input", fileName = nameof(InputData))]
    public sealed class InputData : ScriptableObject
    {
        public KeyCode SavePlayer = KeyCode.C;
        public KeyCode LoadPlayer = KeyCode.V;
    }
}
