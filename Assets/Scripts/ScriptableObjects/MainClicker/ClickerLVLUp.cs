using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClickerLVLUp
{ 


    public ClickerLVLUp(int Level, int ClickerStep , long StickersNeededToLVLUP)
    {
        this.Level = Level;
        this.ClickerStep = ClickerStep;
        this.StickersNeededToLVLUP = StickersNeededToLVLUP;
    }

    [Header ("Variáveis referentes ao upgrade 1")]
    public int Level;
    public int ClickerStep;
    public long StickersNeededToLVLUP;
}
