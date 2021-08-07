using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Assets.Scripts.Editor
{
    public class MyWindow : EditorWindow
    {
        [SerializeField] private static GameObject ObjectInstantiate;
        [SerializeField] private string _nameObject = "";
        [SerializeField] private Vector3 _position;
        private Queue<Transform> _queueRoot = new Queue<Transform>();

        private void OnGUI()
        {
            GUILayout.Label("Базовые настройки", EditorStyles.boldLabel);
            ObjectInstantiate =EditorGUILayout.ObjectField("Объект который хотим вставить", ObjectInstantiate, typeof(GameObject), true)
                  as GameObject;
            _nameObject = EditorGUILayout.TextField("Имя объекта", _nameObject);
            _position = EditorGUILayout.Vector3Field("Позиция", _position);
            var button = GUILayout.Button("Создать объекты");
            if (button)
            {
                if (ObjectInstantiate)
                {
                    GameObject root = new GameObject("Root");
                    _queueRoot.Enqueue(root.transform);
                    GameObject temp = Instantiate(ObjectInstantiate, _position, Quaternion.identity);
                    temp.name = _nameObject;
                    temp.transform.parent = root.transform;
                }
            }
            bool destroyRoot = false;
            if (_queueRoot.Count > 0)
            {
                destroyRoot = GUILayout.Button("Удалить объекты");
            }

            if (destroyRoot)
            {
                DestroyImmediate(_queueRoot.Dequeue().gameObject);
            }
        }
    }
}
