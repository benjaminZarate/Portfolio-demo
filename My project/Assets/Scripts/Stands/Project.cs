using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Project : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler, IPointerClickHandler
{
    [SerializeField] private string _url;

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(_url);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.LogWarning("enter");
        LeanTween.scale(this.transform as RectTransform, new Vector3(-1.2f,1.2f,1), 0.2f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        LeanTween.scale(this.transform as RectTransform, new Vector3(-1, 1f, 1), 0.2f);
    }


}
