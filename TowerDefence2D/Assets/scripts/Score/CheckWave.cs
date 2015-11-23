using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckWave : MonoBehaviour
{

    private GameObject _waveText;
    private float _waveValue;

    // Use this for initialization
    void Start()
    {
        _waveValue = 0;
        _waveText = GameObject.Find("ShowWave");

        _waveText.GetComponent<Text>().text = _waveValue + " /10";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
