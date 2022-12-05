using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class GeneratorUISample
{
    [Header("Manager")]
    public GameObject BuyManagerButton;
    public TextMeshProUGUI ManagerPriceText;


    [Header("Withdraw")]
    public Slider CurrentStickersSlider;
    public GameObject WithdrawStickerButton;

    [Header("Upgrade")]
    public GameObject BuyUpgradeButton;
    public TextMeshProUGUI GeneratorLVLText;
    public TextMeshProUGUI GeneratorPriceText;
}
