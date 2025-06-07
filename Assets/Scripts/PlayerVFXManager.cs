using UnityEngine;
using UnityEngine.VFX;

public class PlayerVFXManager : MonoBehaviour
{
    public VisualEffect footstepVFX;

    public void PlayFootstepVFX(bool state)
    {
        if (state)
            footstepVFX.Play();
        else
            footstepVFX.Stop();
    }
}
