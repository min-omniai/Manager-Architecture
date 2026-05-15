using UnityEngine;

public class Poolable : MonoBehaviour
{
    [SerializeField, Header("Pool 사용 여부")]
    private bool _isUsing = false;
    public bool IsUsing
    {
        get => _isUsing;
        set => _isUsing = value;
    }

    // Pool에서 꺼낼 때 자동 호출
    public virtual void OnPopFromPool()
    {
        _isUsing = true;
    }

    // Pool에 반납할 때 자동 호출
    public virtual void OnPushToPool()
    {
        _isUsing = false;
    }
}