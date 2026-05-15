using UnityEngine;
using UnityEngine.EventSystems;

public class BaseScene : MonoBehaviour
{
    void Awake() => Init();

    protected virtual void Init()
    {
        Object obj = FindFirstObjectByType(typeof(EventSystem));

        if (obj == null)
        {
            GameObject prefab = Managers.Resource.Instantiate("EventSystem");
            DontDestroyOnLoad(prefab);
        }
    }
}