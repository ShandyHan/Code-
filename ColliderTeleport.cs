
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ColliderTeleport : UdonSharpBehaviour
{
    // 텔레포트 시키고 싶은 위치
    public GameObject teleportTarget;

    // 플레이어가 트리거 들어갈 시 들어간 플레이어 teleportTarget으로 텔레포트 시키는 코드
    public override void OnPlayerTriggerEnter(VRCPlayerApi player)
    {
        Networking.LocalPlayer.TeleportTo(teleportTarget.transform.position, teleportTarget.transform.rotation);
    }
}
