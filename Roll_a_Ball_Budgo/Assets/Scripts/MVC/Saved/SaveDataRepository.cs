using Assets.Scripts.MVC.RollerBalls;
using System.Data;
using System.IO;
using UnityEngine;

namespace Assets.Scripts.MVC.Saved
{
    public sealed class SaveDataRepository : ISaveDataRepository
    {
        private readonly IData<SavedData> _data;

        private const string _folderName = "dataSave";
        private const string _fileName = "data.bat";
        private readonly string _path;

        public SaveDataRepository()
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                _data = new PlayerPrefsData();
            }
            else
            {
                _data = new XMLData();
            }
            _path = Path.Combine(Application.dataPath, _folderName);
        }

        public void Save(RollerBall player)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }
            var savePlayer = new SavedData
            {
                Position = player.transform.position,
                Name = "Roman",
                IsEnabled = true
            };

            _data.Save(savePlayer, Path.Combine(_path, _fileName));
            Debug.Log("Save");
        }

        public void Load(RollerBall player)
        {
            var file = Path.Combine(_path, _fileName);
            if (!File.Exists(file))
            {
                throw new DataException($"File {file} not found");
            }
            var newPlayer = _data.Load(file);
            player.transform.position = newPlayer.Position;
            player.name = newPlayer.Name;
            player.gameObject.SetActive(newPlayer.IsEnabled);

            Debug.Log(newPlayer);
        }
    }
}
