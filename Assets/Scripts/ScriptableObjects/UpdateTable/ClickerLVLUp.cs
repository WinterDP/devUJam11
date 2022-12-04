using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ClickerLVLUp
{ 
    [Header ("Variáveis referentes ao upgrade 1")]
    public int Level;
    public int ClickerStep;
    public long StickersNeededToLVLUP;

    public ClickerLVLUp(int Level, long Step , long StickersNeededToLVLUP)
    {
        this.Level = Level;
        this.Step = Step;
        this.StickersNeededToLVLUP = StickersNeededToLVLUP;
    }
<<<<<<< Updated upstream:Assets/Scripts/ScriptableObjects/MainClicker/ClickerLVLUp.cs
=======

    [Header ("Variáveis referentes ao upgrade 1")]
    public int Level;
    public long Step;
    public long StickersNeededToLVLUP;
>>>>>>> Stashed changes:Assets/Scripts/ScriptableObjects/UpdateTable/ClickerLVLUp.cs
}
