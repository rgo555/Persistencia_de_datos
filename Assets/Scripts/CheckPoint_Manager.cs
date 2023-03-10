using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint_Manager : MonoBehaviour
{
    public static Vector3 checkPoint;
    public Text checkPointText;

    void Start()
    {
        checkPointText.text = checkPoint.ToString();

    }

    public void CheckPointData(Vector3 data)
    {
        checkPoint = data;
        PlayerPrefs.SetFloat("posX", data.x);
        PlayerPrefs.SetFloat("posY", data.y);
        PlayerPrefs.SetFloat("posZ", data.z);
    }

    public void LoadDataCP()
    {
        checkPointText.text = checkPoint.ToString();
    }
}
