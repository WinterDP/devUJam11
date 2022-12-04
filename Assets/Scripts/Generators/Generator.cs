using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    #region managing Variables

    [Header(" ordem do gerador ")]
    [SerializeField] private int _generatorOrder;

    [Header(" Variaveis do Manager do gerador ")]
    [SerializeField] private bool _hasManager;
    [SerializeField] private int _managerCost;

    [Header(" Variáveis para retirada das figurinhas ")]
    [SerializeField] private int _cooldownWithdraw = 10;
    private long _currentStickers;
    private long _maxStickersAmount;

    #endregion

    #region Upgrade Variables
        [Header ("Variáveis referentes ao upgrade")]
        [SerializeField] private int _upgradeLVL;
        [SerializeField] private int _maxLVL = 10;
        [SerializeField] private long _generatorStep;
        [SerializeField] private long _stickersNeededToLVLUp;
        [SerializeField] private ClickerLVLUpTable _upgradeData;
        
    #endregion


    private void Awake() {
        //Recebendo as variaveis da tabela de lvl up do upgrade
        this._upgradeLVL = _upgradeData.table[0].Level;
        this._generatorStep = _upgradeData.table[0].Step;
        this._stickersNeededToLVLUp = _upgradeData.table[0].StickersNeededToLVLUP;
    }


    // Start is called before the first frame update
    void Start()
    {
        this._maxStickersAmount = this._cooldownWithdraw*this._generatorStep;
    }

    // Update is called once per frame
    void Update()
    {
        LoadStickers();
        CheckIfCanWithdraw();
        CheckIfCanLVLUp();
        CheckIfCanBuyManager();
    }

    #region Withdraw Stickers methods
        //Retira as figurinhas armazenadas e coloca na quantidade total
        public void WithdrawStickers(){
            if(this._currentStickers >= _maxStickersAmount){
                PlayerData.instance.AddStickersToAmount(_maxStickersAmount);
                _currentStickers = 0;
                UIManager.instance.UpdateGeneratorWithdrawSlider(((float)_currentStickers)/((float)_maxStickersAmount), _generatorOrder);
                UIManager.instance.CanWithdrawGenerator(false, _generatorOrder);
            }

        }
        public void CheckIfCanWithdraw(){
            if(this._currentStickers >= _maxStickersAmount){
                if (_hasManager)
                {
                    WithdrawStickers();
                }else{
                    UIManager.instance.CanWithdrawGenerator(true, _generatorOrder);
                }
            }
        }
    #endregion

    #region Load Sticker methods
        //Retira as figurinhas armazenadas e coloca na quantidade total
        public void LoadStickers(){
            if(_upgradeLVL>0){
                if(this._currentStickers + this._generatorStep >= this._maxStickersAmount){
                    this._currentStickers = this._maxStickersAmount;
                    UIManager.instance.UpdateGeneratorWithdrawSlider(((float)_currentStickers)/((float)_maxStickersAmount), _generatorOrder);
                }else{
                    this._currentStickers += this._generatorStep;
                    UIManager.instance.UpdateGeneratorWithdrawSlider(((float)_currentStickers)/((float)_maxStickersAmount), _generatorOrder);
                }
            }
        }
    #endregion
    
    #region upgrade methods

        public void CheckIfCanLVLUp(){
            if((PlayerData.instance.GetStickersAmount() >= this._stickersNeededToLVLUp) && (this._upgradeLVL < this._maxLVL)){
                UIManager.instance.CanUpgradeGenerator(true, _generatorOrder);
            }else{
                UIManager.instance.CanUpgradeGenerator(false, _generatorOrder);
            }
        }

        public void LevelUp(){
            if(PlayerData.instance.GetStickersAmount() >= _stickersNeededToLVLUp){
                PlayerData.instance.AddStickersToAmount(-(this._stickersNeededToLVLUp));
                this._upgradeLVL ++;
                this._generatorStep = _upgradeData.table[_upgradeLVL].Step;
                this._stickersNeededToLVLUp = _upgradeData.table[_upgradeLVL].StickersNeededToLVLUP;
                UIManager.instance.UpdateGeneratorLVLText(_upgradeLVL, _generatorOrder);
                UIManager.instance.CanUpgradeGenerator(false, _generatorOrder);
            }
        }
    #endregion

    #region Manager methods

        public void CheckIfCanBuyManager(){
            if(((PlayerData.instance.GetStickersAmount() >= this._managerCost) && !_hasManager && this._upgradeLVL>0)){
                UIManager.instance.CanBuyManagerGenerator(true, _generatorOrder);
            }else{
                UIManager.instance.CanBuyManagerGenerator(false, _generatorOrder);
            }
        }

        public void BuyManager(){  
            if(PlayerData.instance.GetStickersAmount() >= this._managerCost){
                PlayerData.instance.AddStickersToAmount(-(this._managerCost));
                _hasManager = true;
                UIManager.instance.CanBuyManagerGenerator(false, _generatorOrder);
            }
        }
    #endregion


}
