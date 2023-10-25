using UnityEngine;

public static class Pause 
{
    public static bool IsPause { get; private set; }

    public static void SetPause(bool CurrentState) => IsPause = CurrentState;
    
}
