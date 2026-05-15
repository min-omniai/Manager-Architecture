using UnityEngine;

public class UITest : MonoBehaviour
{
    void Start()
    {
        // 게임 씬 시작 시, 한 번만 생성
        Managers.UI.ShowSceneUI<UI_TestScene>("UI/UI_TestScene");
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
            Managers.UI.ShowPopupUI<UI_TestPopup>("UI/UI_TestPopup");    // 설정이나 인벤토리 같은 팝업
        if(Input.GetKeyDown(KeyCode.Alpha2))
            Managers.UI.ClosePopupUI();
    }
}