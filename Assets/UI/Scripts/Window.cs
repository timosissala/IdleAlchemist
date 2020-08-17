using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Mask))]
public class Window : MonoBehaviour
{
    [SerializeField]
    public ResourceData resourceData;

    private RectTransform viewPort;
    private RectTransform content;

    public void OnEnable()
    {
        viewPort = GetComponent<RectTransform>();
        content = transform.GetChild(0).GetComponent<RectTransform>();
    }

    public void OnDisable()
    {

    }

    public RectTransform GetViewport()
    {
        return viewPort;
    }

    public RectTransform GetContent()
    {
        return content;
    }
}
