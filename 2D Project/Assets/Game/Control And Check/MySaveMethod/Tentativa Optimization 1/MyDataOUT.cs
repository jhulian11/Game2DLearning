using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MyDataOUT 
{
    public float[] AcidBoxPosition;

    public MyDataOUT(MyDataScript data)
    {
        AcidBoxPosition = new float[3];
        AcidBoxPosition[0] = data.BoxAcidPostion.localPosition.x;
        AcidBoxPosition[1] = data.BoxAcidPostion.localPosition.y;
        AcidBoxPosition[2] = data.BoxAcidPostion.localPosition.z;
    }


}
