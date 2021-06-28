using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Data/Data")]
public class Data : ScriptableObject
{
    
    [SerializeField] private string _jampDataPath;
    [SerializeField] private string _speedDataPath;
    private JampBufData _jampBuf;
    private SpeedBufData _speedBuf;

    public JampBufData JampBuf
    {
        get
        {
            if (_jampBuf == null)
            {
                _jampBuf = Load<JampBufData>("Data/" + _jampDataPath);
            }

            return _jampBuf;
        }
    }

    public SpeedBufData SpeedBuf
    {
        get
        {
            if (_speedBuf==null)
            {
                _speedBuf = Load<SpeedBufData>("Data/" + _speedDataPath);
            }

            return _speedBuf;
        }
    }


    private T Load<T>(string resourcesPath) where T : Object =>
        Resources.Load<T>(Path.ChangeExtension(resourcesPath, null));

}
