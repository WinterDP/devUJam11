using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{

    #region Upgrade Variables
        [Header ("Variáveis referentes ao upgrade")]
        [SerializeField] private int _upgradeLVL;
        [SerializeField] private int _maxLVL = 50;
        [SerializeField] private long _clickerStep;
        [SerializeField] private long _stickersNeededToLVLUp;
        [SerializeField] private ClickerLVLUpTable _upgradeData;
        
    #endregion

    private void Awake() {
       //Recebendo as variaveis da tabela de lvl up do upgrade
        this._upgradeLVL = _upgradeData.table[0].Level;
        this._clickerStep = _upgradeData.table[0].Step;
        this._stickersNeededToLVLUp = _upgradeData.table[0].StickersNeededToLVLUP; 

    }

    // Update is called once per frame
    void Update()
    {
        CheckIfCanLVLUp();
    }

    #region Clicker main methods

        public void OnClickerClick(){
            PlayerData.instance.AddStickersToAmount(this._clickerStep);
        }
    #endregion

    #region upgrade methods

        public void CheckIfCanLVLUp(){
            if(PlayerData.instance.GetStickersAmount() >= _stickersNeededToLVLUp && (_upgradeLVL < _maxLVL)){
                UIManager.instance.CanLVLUp(true);
            }else{
                UIManager.instance.CanLVLUp(false);
            }
        }


        public void LevelUp(){
            if((PlayerData.instance.GetStickersAmount() >= _stickersNeededToLVLUp) && (_upgradeLVL < _maxLVL) ){
                PlayerData.instance.AddStickersToAmount(-(this._stickersNeededToLVLUp));
                this._upgradeLVL ++;
                this._clickerStep = _upgradeData.table[_upgradeLVL].Step;
                this._stickersNeededToLVLUp = _upgradeData.table[_upgradeLVL].StickersNeededToLVLUP;
                UIManager.instance.UpdateLVLText(_upgradeLVL);
                UIManager.instance.CanLVLUp(false);
            }
        }
    #endregion


}
