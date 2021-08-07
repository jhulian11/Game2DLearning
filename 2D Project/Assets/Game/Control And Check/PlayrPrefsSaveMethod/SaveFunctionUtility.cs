using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gamekit2D;

public class SaveFunctionUtility : MonoBehaviour
{
    // public bool door1IsOpen = false;
    // public GameObject door1 = null;

    //Doors

    //Door1
    public static void Door1SetDesactive(bool door1Open,GameObject door1)
    {
        if (door1Open)
        { Debug.Log("aaaa"); door1.SetActive(false); }       
    }

    //Door2
    public static void Door3SetDesactive(bool door3Open, GameObject door3)
    {
        if (door3Open)
        { Debug.Log("333333"); door3.SetActive(false); }
    }

    //FinalDoor





    // Lists
    public static void ListMaker1(GameObject Parent, List<bool> Bool)
    {
        for (int i = 0; i < Parent.transform.childCount; i++)
        {
            Bool.Add(Parent);
        }
    }

    public static void ListModifier1(GameObject Parent, List<bool> Bool)
    {
        for (int i = 0; i < Bool.Count; i++)
        {
            if (Parent.transform.GetChild(i).transform.GetChild(0).gameObject.activeInHierarchy)
            {
                Bool[i] = true;
            }
            else
            {
                Bool[i] = false;
            }
        }
    }
    public static void ListLoaderModifierSceneOnStart(GameObject Parent, List<bool> Bool)
    {
        for (int i = 0; i < Bool.Count; i++)
        {
            if (!Bool[i])
            {
                Parent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public static void ListLoaderData(List<bool> data1, List<bool> Bool)
    {
        for (int i = 0; i < Bool.Count; i++)
        {
            Bool[i] = data1[i];
        }
    } 
}
