using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMissionContext
{
    void SetState(IMissionState newState);
}
