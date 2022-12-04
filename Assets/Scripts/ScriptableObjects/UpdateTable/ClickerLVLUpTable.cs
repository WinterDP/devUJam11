using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "UpgradeClickerLVLUpTable", menuName = "Upgrades/upgradeLVLUpTable", order = 0)]
public class ClickerLVLUpTable : ScriptableObject
{
    
    private int _maxLVL = 10;
    private int _standartStep = 10;
    private int _standartPrice = 110;


    [Header ("Lista de crescimento do upgrade")]
    public List<ClickerLVLUp> table = new List<ClickerLVLUp>();


    #if UNITY_EDITOR
        private void Awake() {
            if (table != null)
            {
                for (int i = 0; i <= _maxLVL; i++)
                {
                    if(i==0){
                        table.Add(new ClickerLVLUp(i, 1, _standartPrice));
                    }else{
                        table.Add(new ClickerLVLUp(i, (long) (_standartStep * Math.Exp( (double)( 0.1385 * (double)i ))), (long) (_standartPrice * Math.Exp((double)( 0.1385 * (double)i )))));
                    }
                }
            }
        }
    #endif

}