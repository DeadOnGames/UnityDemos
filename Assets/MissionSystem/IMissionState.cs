using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IMissionState
{
    //Create method signatures for transitions between states
    public virtual void StartMission(IMissionContext context) { }
    public virtual void RestartMission(IMissionContext context) { }
    public virtual void CompleteMission(IMissionContext context) { }
    public virtual void FailMission(IMissionContext context) { }
}
