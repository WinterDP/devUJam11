using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "UpgradeClickerLVLUpTable", menuName = "Upgrades/upgradeClickerLVLUpTable", order = 0)]
public class ClickerLVLUpTable : ScriptableObject
{
    [Header ("Lista de crescimento do upgrade da lambidinha")]
    public List<ClickerLVLUp> table = new List<ClickerLVLUp>();

    
        private void Awake() {
        Debug.Log("teste");
                for (int i = 0; i <= 50; i++)
                {
                    if(i==0){
                        table.Add(new ClickerLVLUp(i, 1, 100));
                    }else{
                        table.Add(new ClickerLVLUp(i, (int) (1.0 * Math.Exp( (double)( 0.1385 * (double)i ))), (long) (100 * Math.Exp((double)( 0.1385 * (double)i )))));
                    }
                }
        }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}