using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IJampBuf
{
    event Action<int> OnTriggerEnterChange;
}
