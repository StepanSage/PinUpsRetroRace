using UnityEngine;

public class ExsportSoundVolume : MonoBehaviour
{
    private GatVoumeSound _gatVoumeSound;

    private void Awake()
    {
        _gatVoumeSound = GetComponent<GatVoumeSound>();
    }
    public void ChangeVolume( bool IsActive)
    {
        PlayerPrefs.SetString("IsActive", IsActive.ToString());
        _gatVoumeSound.Set(IsActive);


       

    }

    
}
