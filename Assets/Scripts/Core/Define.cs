public class Define
{
    public enum eScene : byte
    {
        Unknown,
        BaseScene,
        GameScene
    }

    public enum eSound : byte
    {
        Bgm,
        SFX,
        MaxCount
    }

    public enum UIEvent : byte
    {
        Click,
        Drag
    }
}