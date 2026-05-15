using UnityEngine;

public class UI_Popup : UI_Base
{
    public override void Init() { }

    public virtual void ClosePopup()
    {
        Managers.UI.ClosePopupUI();
    }
}
