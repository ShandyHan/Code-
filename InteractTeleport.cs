
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class InteractTeleport : UdonSharpBehaviour
{
    // 텔레포트 시키고 싶은 위치
    public GameObject teleportTarget;

    // 누른 사람이 teleportTarget에 이동시키는 코드
    public override void Interact()
    {
        Networking.LocalPlayer.TeleportTo(teleportTarget.transform.position, teleportTarget.transform.rotation);
    }
}
