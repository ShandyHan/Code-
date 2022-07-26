
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class LocalOnOff : UdonSharpBehaviour
{
    // 온오프 시키고 싶은 게임 오브젝트
    public GameObject localObject;

    // 인터렉트 시
    public override void Interact()
    {
        // 온오프 시키는 코드
        localObject.SetActive(!localObject.activeInHierarchy);
    }
}
