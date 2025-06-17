using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIColourPicker : MonoBehaviour
{
    public GameObject target;
    private Material targetMaterial;
    private GraphicRaycaster raycaster;
    private PointerEventData pointerEventData;
    private EventSystem eventSystem;

    // Start is called before the first frame update
    void Start()
    {
        if (target != null)
        {
            targetMaterial = target.GetComponent<Renderer>().material;
        }

        raycaster = GetComponent<GraphicRaycaster>();
        eventSystem = GetComponent<EventSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        pointerEventData = new PointerEventData(eventSystem);
        pointerEventData.position = Input.mousePosition;

        List<RaycastResult> results = new List<RaycastResult>();
        raycaster.Raycast(pointerEventData, results);

        foreach (RaycastResult result in results)
        {
            if (result.gameObject.GetComponent<Image>().color != null)
            {
                ChangeColour(result.gameObject.GetComponent<Image>().color);
            }
        }
    }

    private void ChangeColour(Color col)
    {
        targetMaterial.color = col;
    }
}
