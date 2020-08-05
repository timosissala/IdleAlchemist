using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MainView : MonoBehaviour
{
    public static MainView instance;

    public Window activeWindow;

    private void Awake()
    {
        instance = this;
    }

    public void ChangeWindow(Window newWindow)
    {
        activeWindow?.gameObject.SetActive(false);

        if (activeWindow != newWindow)
        {
            newWindow.gameObject.SetActive(true);
            activeWindow = newWindow;
            print("Window changed to " + newWindow.name);
        }
        else
        {
            activeWindow = null;
        }
    }
}
