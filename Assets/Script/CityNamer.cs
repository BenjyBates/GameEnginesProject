using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityNamer : MonoBehaviour
{

    public string[] cityForename;
    public string[] cityType;
    private int _sectorNum;
    public Text cityNameText;

    void Start()
    {
        _sectorNum = Random.RandomRange(0, 999);
        cityNameText.text = cityForename[Random.RandomRange(0,cityForename.Length)]+" "+cityType[Random.RandomRange(0,cityType.Length)]+" SECTOR:"+_sectorNum;
    }

}
