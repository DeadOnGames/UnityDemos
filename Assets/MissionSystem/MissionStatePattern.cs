using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionStatePattern : MonoBehaviour, IMissionContext
{
    IMissionState currentState = new MissionLockedState();

    [ContextMenu("StartMission()")]
    public virtual void StartMission() => currentState.StartMission(this);
    [ContextMenu("RestartMission()")]
    public virtual void RestartMission() => currentState.RestartMission(this);
    [ContextMenu("CompleteMission()")]
    public virtual void CompleteMission() => currentState.CompleteMission(this);
    [ContextMenu("FailMission()")]
    public virtual void FailMission() => currentState.FailMission(this);

    void IMissionContext.SetState(IMissionState newState)
    {
        currentState = newState;
    }
}
