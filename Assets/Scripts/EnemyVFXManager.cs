using UnityEngine;
using UnityEngine.VFX;

public class EnemyVFXManager : MonoBehaviour
{
    public VisualEffect footStepVFX;
    public VisualEffect attackVFX;

    public void PlayAttackVFX()
    {
        attackVFX.SendEvent("OnPlay");
    }

    public void BurstFootStep()
    {
        footStepVFX.SendEvent("OnPlay");
    }
}
