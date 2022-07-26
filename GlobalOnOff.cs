
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class GlobalOnOff : UdonSharpBehaviour
{
    // 온오프 시키고 싶은 게임 오브젝트
    public GameObject globalObject;

    // 게임 오브젝트 인터렉트 시 글로벌로 토글 시키는 이벤트
    public override void Interact()
    {
        // 글로벌로 토글 시키는 코드
        SendCustomNetworkEvent(NetworkEventTarget.All, nameof(ToggleObjectGlobal));
    }

    // 글로벌로 토글 시키는 메서드
    public void ToggleObjectGlobal()
    {
        globalObject.SetActive(!globalObject.activeInHierarchy);
    }
}
