
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;
using VRC.Udon.Common.Interfaces;

public class GlobalParticleOnOff : UdonSharpBehaviour
{
    public ParticleSystem particle;
    public bool isTriggered = false;

    public override void Interact()
    {
        if(isTriggered == true)
        {
            isTriggered = false;
            SendCustomNetworkEvent(NetworkEventTarget.All, nameof(GlobalParticleOn));
        }
        else
        {
            isTriggered = true;
            SendCustomNetworkEvent(NetworkEventTarget.All, nameof(GlobalParticleOff));
        }
    }

    public void GlobalParticleOn()
    {
        particle.Play();
    }

    public void GlobalParticleOff()
    {
        particle.Stop();
    }
}
