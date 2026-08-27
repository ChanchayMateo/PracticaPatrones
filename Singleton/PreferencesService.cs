using UnityEngine;

public abstract class PreferencesService : MonoBehaviour
{
    public static PreferencesService Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public abstract void SaveVolume(float volume);
    public abstract float LoadVolume();

    public abstract void SavePlayerName(string name);

    public abstract string LoadPlayerName();

    
}