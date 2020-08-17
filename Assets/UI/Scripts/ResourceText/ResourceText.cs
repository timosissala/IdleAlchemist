using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ResourceText : MonoBehaviour
{
    [SerializeField]
    Resource trackedResource;

    private TextMeshProUGUI textMesh;

    private void Start()
    {
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText()
    {
        textMesh.text = "" + trackedResource.amount;
    }
}
