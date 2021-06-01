using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public TMP_Text overheatedMessage  = null;
    public static UIController instance;
    public Slider weaponTempSlider;
    public Slider currentHPSlider;
    public GameObject deathScreen;
    public TMP_Text deathScreenText;

    [Header("Kills & Deaths Scores")]
    public TMP_Text killsText;
    public TMP_Text deathsText;
    

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        
    }

}
