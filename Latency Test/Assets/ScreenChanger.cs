using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenChanger : MonoBehaviour
{
    public Image testImage1,testImage2;
    public Text testText1, testText2, centerText;
    public float zKeyTime, mKeyTime;

    public bool zKey, mKey;
    // Start is called before the first frame update
    void Start()
    {
        zKey = false;
        mKey = false;
    }

    // Update is called once per frame
    void Update()
    {
        testImage1.color = Color.black;
        testImage2.color = Color.black;
        if(Input.GetKey(KeyCode.Z))
        {
            testImage1.color = Color.red;
            zKey = true;
        }
        else
        {
            zKey = false;
        }
        if(Input.GetKey(KeyCode.M))
        {
            testImage2.color = Color.blue;
            mKey = true;
        }
        else
        {
            mKey = false;
        }

        if ((zKey&&!mKey))
        {
            zKeyTime += Time.deltaTime;
        }
        else if ((!zKey&&mKey))
        {
            mKeyTime += Time.deltaTime;
        }
        else if (mKey && zKey)
        {
            
        }
        else
        {
            zKeyTime = 0;
            mKeyTime = 0;
        }

        testText1.text = zKeyTime.ToString("F4");
        testText2.text = mKeyTime.ToString("F4");
        if (Input.anyKey)
        {
            EventSystem.current.currentInputModule.
        }

    }
}
