using Assets.Scripts.MVC.RollerBalls;
using Assets.Scripts.MVC.Saved;
using UnityEngine;

namespace Assets.Scripts.MVC.Controllers
{
    public class InputController : IExecute
    {
        private readonly RollerBall _playerBase;
        private readonly InputData _inputData;
        private readonly ISaveDataRepository _saveDataRepository;
        private readonly Repository _repository;

        public InputController(RollerBall player, InputData inputData)
        {
            _playerBase = player;
            _inputData = inputData;

            _saveDataRepository = new SaveDataRepository();
            _repository = new Repository();
        }


        public void Execute(float deltaTime)
        {
            _playerBase.Move(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKeyDown(_inputData.SavePlayer))
            {
                _saveDataRepository.Save(_playerBase);
            }
            if (Input.GetKeyDown(_inputData.LoadPlayer))
            {
                _saveDataRepository.Load(_playerBase);
            }
        }
    }
}
