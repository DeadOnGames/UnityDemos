using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionStatePattern : MonoBehaviour, IMissionContext
{
    IMissionState currentState = new MissionLockedState();

    public virtual void StartMission() => currentState.StartMission(this);
    public virtual void RestartMission() => currentState.RestartMission(this);
    public virtual void CompleteMission() => currentState.CompleteMission(this);
    public virtual void FailMission() => currentState.FailMission(this);

    void IMissionContext.SetState(IMissionState newState)
    {
        currentState = newState;
    }
}
