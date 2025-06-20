using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionLockedState : IMissionState
{
    public override void StartMission(IMissionContext context)
    {
        context.SetState(new MissionActiveState()); //Start mission
    }
}

public class MissionActiveState : IMissionState
{
    public override void CompleteMission(IMissionContext context)
    {
        context.SetState(new MissionCompleteState()); //Complete mission
    }

    public override void FailMission(IMissionContext context)
    {
        context.SetState(new MissionFailedState()); //Complete mission
    }

    public override void RestartMission(IMissionContext context)
    {
        context.SetState(new MissionActiveState()); //Play the mission again
    }
}

public class MissionCompleteState : IMissionState
{
    public override void RestartMission(IMissionContext context)
    {
        context.SetState(new MissionActiveState()); //Play the mission again
    }
}

public class MissionFailedState : IMissionState
{
    public override void RestartMission(IMissionContext context)
    {
        context.SetState(new MissionActiveState()); //Play the mission again
    }
}

