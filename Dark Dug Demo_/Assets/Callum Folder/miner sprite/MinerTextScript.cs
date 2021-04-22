using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinerTextScript : MonoBehaviour
{
    Text minerText;
    public static int minerAmount = 0;

    // Start is called before the first frame update
    void Start()
    {
        minerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        minerText.text = minerAmount.ToString();


    }
}
