using UnityEngine;
using UnityEngine.VFX;

public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect footStepVFX;

    public void BurstFootStep()
    {
        footStepVFX.SendEvent("OnPlay");
    }
}
