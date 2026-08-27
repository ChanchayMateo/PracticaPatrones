using UnityEngine;
public class PlayerPrefsManager_Ab : PreferencesService
{
    public override void SaveVolume(float volume)
    {
        UnityEngine.PlayerPrefs.SetFloat("Volume", volume);
        UnityEngine.PlayerPrefs.Save();
    }

    public override float LoadVolume()
    {
        return UnityEngine.PlayerPrefs.GetFloat("Volume", 1f);
    }

    public override void SavePlayerName(string name)
    {
        UnityEngine.PlayerPrefs.SetString("PlayerName", name);
        UnityEngine.PlayerPrefs.Save();
    }

    public override string LoadPlayerName()
    {
        return UnityEngine.PlayerPrefs.GetString("PlayerName", "Default Name");
    }
} 