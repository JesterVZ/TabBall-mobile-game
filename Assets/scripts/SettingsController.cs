
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Toggle SpawnLivesCheckbox;
    public Toggle SpawnBonusCheckbox;
    public static bool CanSpawnLives, CanSpawnBonus;
    void Start()
    {

    }
    void Update()
    {
        if(SpawnLivesCheckbox.isOn == true)
        {
            CanSpawnLives = !CanSpawnLives;
        }
        if(SpawnBonusCheckbox.isOn == true)
        {
            CanSpawnBonus = !CanSpawnBonus;
        }
    }
}
