using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinsController : MonoBehaviour {

    private GameObject _coinsText;
    public float _coinsValue;

	// Use this for initialization
	void Start () 
    {
        _coinsValue = 1000f;
        _coinsText = GameObject.Find("CoinsValue");

        _coinsText.GetComponent<Text>().text = " " + _coinsValue;
	}
	
	// Update is called once per frame
	void Update () 
    {
	
	}
}
