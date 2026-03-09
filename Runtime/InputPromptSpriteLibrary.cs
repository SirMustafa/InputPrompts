using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "InputPromptSpriteLibrary")]
public class InputPromptSpriteLibrary : ScriptableObject
{
    public TMP_SpriteAsset keyboardSprites;
    public TMP_SpriteAsset xboxSprites;
    public TMP_SpriteAsset playStationSprites;

    public TMP_SpriteAsset Get(InputPromptDevice device)
    {
        return device switch
        {
            InputPromptDevice.KeyboardMouse => keyboardSprites,
            InputPromptDevice.Xbox => xboxSprites,
            InputPromptDevice.PlayStation => playStationSprites,
            _ => keyboardSprites
        };
    }
}

public enum InputPromptDevice
{
    KeyboardMouse = 0,
    Xbox = 1,
    PlayStation = 2
}