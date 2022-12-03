using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    #region StickerAmountVariables
        [Header ("Sticker amount")]
        //armazena o valor da quantidade de figurinhas que será mostrado na tela
        [SerializeField] private long testStickerAmountValue = 20;
        [SerializeField] private TextMeshProUGUI _stickerAmountText;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStickerAmount(testStickerAmountValue);
    }

    public void UpdateStickerAmount(long StickerAmount){
        string aux =  StickerAmount.ToString();
        this._stickerAmountText.text = aux;
    }
}
