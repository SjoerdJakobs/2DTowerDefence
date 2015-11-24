using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TowerHealth : MonoBehaviour
{

    private GameObject _tHealthText;
    private float _tHealthValue;

    // Use this for initialization
    void Start()
    {
        _tHealthValue = 100f;
        _tHealthText = GameObject.Find("TowerPercentage");

        _tHealthText.GetComponent<Text>().text = _tHealthValue + "%";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
