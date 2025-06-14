using UnityEngine;
using UnityEngine.VFX;

public class PlayerVFXManager : MonoBehaviour
{
    public VisualEffect footstepVFX;

    public ParticleSystem blade01;

    public void PlayFootstepVFX(bool state)
    {
        if (state)
            footstepVFX.Play();
        else
            footstepVFX.Stop();
    }
    public void PlayBlade01()
    {
        blade01.Play();
    }
}
