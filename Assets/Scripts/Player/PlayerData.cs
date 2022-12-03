using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    #region stickersAmountVariables
        private long _stickerAmount;
    #endregion

    public static PlayerData instance;

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
        
    }

    #region StickersAmountMethods

        public long GetStickersAmount() => this._stickerAmount;

        public void SetStickersAmount(long NewStickersAmount){
            this._stickerAmount = NewStickersAmount;
            UIManager.instance.UpdateStickerAmount(this._stickerAmount);
        }

        public void AddStickersToAmount(long NewStickers){
            this._stickerAmount += NewStickers;
            UIManager.instance.UpdateStickerAmount(this._stickerAmount);
        }

    #endregion
}
