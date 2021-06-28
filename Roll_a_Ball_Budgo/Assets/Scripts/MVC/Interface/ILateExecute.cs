using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ILateExecute : IController
{
    void LateExecute(float deltaTime);
}
