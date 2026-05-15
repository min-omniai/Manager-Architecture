using UnityEngine;

public class DataManager : ISubManager
{
    bool _useSound = true;
    public bool UseSound
    {
        get => _useSound;
        set
        {
            _useSound = value;
            Managers.Audio.BgmState(_useSound);
        }
    }

    bool _useHaptic = true;
    public bool UseHaptic
    {
        get => _useHaptic;
        set => _useHaptic = value;
    }

    public bool Tutorial
    {
        get => System.Convert.ToBoolean(PlayerPrefs.GetInt("EndTutorial"));
        set => PlayerPrefs.SetInt("EndTutorial", value ? 1 : 0);
    }

    public void Init()
    {
        Load();
    }

    public void Clear()
    {
        Save();
    }

    void Save()
    {
        PlayerPrefs.SetInt("UseSound", _useSound ? 1 : 0);
        PlayerPrefs.SetInt("UseHaptic", _useHaptic ? 1 : 0);
        PlayerPrefs.Save();
    }

    void Load()
    {
        _useSound = PlayerPrefs.GetInt("UseSound", 1) == 1;
        _useHaptic = PlayerPrefs.GetInt("UseHaptic", 1) == 1;
    }

    // 실제 게임 데이터 Save/Load 는 별도 구현 필요
    // ex) JSON 직렬화, 서버 연동 등등
    public void SaveData() {}
    public void GetData() {}
}
