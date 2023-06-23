using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] Color normalColor = new(255, 255, 255, 255);
    [SerializeField] Color hoverColor = new(255, 155, 0, 255);
    public void OnPointerEnter(PointerEventData eventData)
    {
        TMP_Text buttonText = GetComponentInChildren<TMP_Text>();
        buttonText.color = hoverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        TMP_Text buttonText = GetComponentInChildren<TMP_Text>();
        buttonText.color = normalColor;
    }
}
