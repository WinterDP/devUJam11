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


    #region Clicker Upgrade Variables
        [Header ("Variaveis relacionadas a UI do upgrade do clicker")]
        //armazena o valor da quantidade de figurinhas que será mostrado na tela
        [SerializeField] private TextMeshProUGUI _upgradeLVLText;
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
    
    #region Clicker Upgrade Methods
        public void CanLVLUp(bool state){
            _upgradeButton.SetActive(state);
        }

        public void UpdateLVLText(int newLvl){
            this._upgradeLVLText. text = "NV:" + newLvl;
        }
    #endregion

    #region Generator Methods
        #region Generator Whithdraw Methods
            public void CanWithdrawGenerator(bool state, int index){
                this._generatorList[index]._withdrawStickerButton.SetActive(state);
            }

            public void UpdateGeneratorWithdrawSlider(float newCurrentStickers, int index){
                this._generatorList[index]._currentStickersSlider.value = newCurrentStickers;
            }
        #endregion

        #region Generator upgrade Methods
            public void CanUpgradeGenerator(bool state, int index){
                this._generatorList[index]._buyUpgradeButton.SetActive(state);
            }

            public void UpdateGeneratorLVLText(int newLvl, int index){
                this._generatorList[index]._generatorLVLText.text = "NV:" + newLvl;
            }
        #endregion

        #region Generator Manager Methods
            public void CanBuyManagerGenerator(bool state, int index){
                this._generatorList[index]._buyManagerButton.SetActive(state);
            }

        #endregion  
    #endregion
}
