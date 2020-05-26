using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class ShowImage : MonoBehaviour
{
    public GameObject icon;
    public void OnClicked()
    {
        string func = new StackFrame(1).GetMethod().Name;
        UnityEngine.Debug.Log(func);
    }
}
