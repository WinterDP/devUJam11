using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FILENAME", menuName = "MENUNAME", order = 0)]
public class ClickerLVLUpTable : ScriptableObject
{
    [Header ("Lista de crescimento do upgrade da lambidinha")]
    public List<ClickerLVLUp> table = new List<ClickerLVLUp>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}