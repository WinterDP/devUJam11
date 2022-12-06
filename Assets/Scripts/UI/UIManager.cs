using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.AI;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    #region Sticker Amount Variables
        [Header ("Sticker amount")]
        //armazena o valor da quantidade de figurinhas que será mostrado na tela
        [SerializeField] private TextMeshProUGUI _stickerAmountText;
    #endregion

    #region Name
        [Header ("Player Title")]

        [SerializeField] private TextMeshProUGUI _playerTitleText;
    #endregion


    #region Clicker Upgrade Variables
        [Header ("Variaveis relacionadas a UI do upgrade do clicker")]
        //armazena o valor da quantidade de figurinhas que será mostrado na tela
        [SerializeField] private TextMeshProUGUI _upgradeLVLText;
        [SerializeField] private TextMeshProUGUI _upgradePriceText;
        [SerializeField] private GameObject _upgradeButton;

    #endregion

    #region Generator Variables
        [Header ("Variaveis relacionadas a UI do upgrade do clicker")]
        [SerializeField] private List<GeneratorUISample> _generatorList = new List<GeneratorUISample>();
    #endregion


    private void Awake() {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject, 2f);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    #region Sticker Amount Methods
        public void UpdateStickerAmount(long StickerAmount){
            string aux =  StickerAmount.ToString();
            this._stickerAmountText.text = aux;
        }
    #endregion

    #region player title
        public void UpdatePlayerTitle(string newTitle){
            this._playerTitleText.SetText(newTitle);
        }
    #endregion
    
    #region Clicker Upgrade Methods
        public void CanLVLUp(bool state){
            this._upgradeButton.SetActive(state);
        }

        public void UpdateLVLText(int newLvl){
            this._upgradeLVLText.SetText("NV:" + newLvl);
        }

        public void UpdatePriceText(long newPrice){
            this._upgradePriceText.SetText("Preço:\n" + newPrice);
        }

        public void SetPriceText(bool state){
            this._upgradePriceText.enabled = state;
        }

    #endregion

    #region Generator Methods
        #region Generator Whithdraw Methods
            public void CanWithdrawGenerator(bool state, int index){
                this._generatorList[index].WithdrawStickerButton.SetActive(state);
            }

            public void UpdateGeneratorWithdrawSlider(float newCurrentStickers, int index){
                this._generatorList[index].CurrentStickersSlider.value = newCurrentStickers;
            }
        #endregion

        #region Generator upgrade Methods
            public void CanUpgradeGenerator(bool state, int index){
                this._generatorList[index].BuyUpgradeButton.SetActive(state);
            }

            public void UpdateGeneratorLVLText(int newLvl, int index){
                this._generatorList[index].GeneratorLVLText.SetText("NV:" + newLvl);
            }

            public void UpdateGeneratorPriceText(long newPrice, int index){
                this._generatorList[index].GeneratorPriceText.SetText("Preço:\n" + newPrice);
            }

            public void SetGeneratorPriceText(bool state, int index){
                this._generatorList[index].GeneratorPriceText.enabled = state;
            }

        #endregion

        #region Generator Manager Methods
            public void CanBuyManagerGenerator(bool state, int index){
                this._generatorList[index].BuyManagerButton.SetActive(state);
            }

            public void UpdateManagerPriceText(long newPrice, int index){
                this._generatorList[index].ManagerPriceText.SetText("Preço:\n" + newPrice);
            }
            
            public void SetManagerPriceText(bool state, int index){
                this._generatorList[index].ManagerPriceText.enabled = state;
            }

        #endregion  
    #endregion
}
