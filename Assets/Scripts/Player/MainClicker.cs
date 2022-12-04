using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
<<<<<<< Updated upstream
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
        
=======
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
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
        public void LevelUpU1(){
            PlayerData.instance.AddStickersToAmount(-(this._stickersNeededToLVLUpU1));
            this._upgrade1LVL ++;
            this._clickerStep = _upgrade1Data.table[_upgrade1LVL].ClickerStep;
            this._stickersNeededToLVLUpU1 = _upgrade1Data.table[_upgrade1LVL].StickersNeededToLVLUP;
=======
        public void LevelUp(){
            if(PlayerData.instance.GetStickersAmount() >= _stickersNeededToLVLUp){
                PlayerData.instance.AddStickersToAmount(-(this._stickersNeededToLVLUp));
                this._upgradeLVL ++;
                this._clickerStep = _upgradeData.table[_upgradeLVL].Step;
                this._stickersNeededToLVLUp = _upgradeData.table[_upgradeLVL].StickersNeededToLVLUP;
                UIManager.instance.UpdateLVLText(_upgradeLVL);
                UIManager.instance.CanLVLUp(false);
            }
>>>>>>> Stashed changes
        }
    #endregion


}
