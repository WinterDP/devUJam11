using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
    #region Upgrade 1 Variables
        [Header ("Variáveis referentes ao upgrade 1")]
        [SerializeField] private int _upgrade1LVL;
        [SerializeField] private int _clickerStep;
        [SerializeField] private long _stickersNeededToLVLUpU1;
        [SerializeField] private ClickerLVLUpTable _upgrade1Data;
        [SerializeField] private GameObject _upgrade1Button;
    #endregion


    //[SerializeField] private float ClickerCriticalChance;
    //[SerializeField] private ClickerLVLUpTable upgrade2Data;


    private void Awake() {
        //Recebendo as variaveis da tabela de lvl up do upgrade 1
        this._upgrade1LVL = _upgrade1Data.table[0].Level;
        this._clickerStep = _upgrade1Data.table[0].ClickerStep;
        this._stickersNeededToLVLUpU1 = _upgrade1Data.table[0].StickersNeededToLVLUP;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfU1CanLVLUpU1();
        //CheckIfU1CanLVLUpU2();
    }

    #region Clicker main methods

        public void OnClickerClick(){
            PlayerData.instance.AddStickersToAmount(this._clickerStep);
        }
    #endregion

    #region upgrade 1 methods

        public void CheckIfU1CanLVLUpU1(){
            if(PlayerData.instance.GetStickersAmount() >= _stickersNeededToLVLUpU1){
                _upgrade1Button.SetActive(true);
            }
        }

        public void LevelUpU1(){
            PlayerData.instance.AddStickersToAmount(-(this._stickersNeededToLVLUpU1));
            this._upgrade1LVL ++;
            this._clickerStep = _upgrade1Data.table[_upgrade1LVL].ClickerStep;
            this._stickersNeededToLVLUpU1 = _upgrade1Data.table[_upgrade1LVL].StickersNeededToLVLUP;
        }
    #endregion


}
