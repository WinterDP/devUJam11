using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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

}
