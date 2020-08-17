using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(ScrollRect))]
public class MainView : MonoBehaviour
{
    public static MainView instance;

    public ScrollRect scrollRect;

    public Window activeWindow;
    public Window defaultWindow;

    private void Awake()
    {
        instance = this;

        scrollRect = GetComponent<ScrollRect>();
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
            defaultWindow.gameObject.SetActive(true);
            activeWindow = defaultWindow;
        }

        scrollRect.viewport = activeWindow.GetViewport();
        scrollRect.content = activeWindow.GetContent();
    }
}
