using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClickerLVLUp
{ 


    public ClickerLVLUp(int Level, long Step , long StickersNeededToLVLUP)
    {
        this.Level = Level;
        this.Step = Step;
        this.StickersNeededToLVLUP = StickersNeededToLVLUP;
    }


    [Header ("Variáveis referentes ao upgrade")]
    public int Level;
    public long Step;
    public long StickersNeededToLVLUP;

}
