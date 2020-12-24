using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PersonPanel : MonoBehaviour
{

    public GameObject mainPanel;
    public GameObject pingMarker;

    public Image portrait;
    public Text lastName;
    public Text age;
    public Text job;
    public Text info;

    public Text search1;
    public Text search2;
    public Text search3;


    private int _randomInt1;


    public Sprite[] nPCImage;
    public string[] nPCLastName;
    public string[] nPCFirstName;
    public int nPCAge;
    public string[] nPCJob;
    public string[] nPCInfo;
    public string[] npcSearch;


    private void Start()
    {
        mainPanel.gameObject.SetActive(false);

        RandomInfo();
    }



    public void RandomInfo()
    {
        portrait.sprite = nPCImage[Random.RandomRange(0, nPCImage.Length)];

        lastName.text = nPCLastName[Random.RandomRange(0, nPCLastName.Length)] +", "+nPCFirstName[Random.RandomRange(0, nPCFirstName.Length)];

        _randomInt1 = Random.RandomRange(20, 50);
        age.text = "Age: "+_randomInt1.ToString();

        job.text = nPCJob[Random.RandomRange(0, nPCJob.Length)];

        info.text = nPCInfo[Random.RandomRange(0, nPCInfo.Length)];

        search1.text = npcSearch[Random.RandomRange(0, npcSearch.Length)];
        search2.text = npcSearch[Random.RandomRange(0, npcSearch.Length)];
        search3.text = npcSearch[Random.RandomRange(0, npcSearch.Length)];

    }

    public void ShowInfo()
    {
        mainPanel.gameObject.SetActive(true);
        Destroy(pingMarker);
    }

}
