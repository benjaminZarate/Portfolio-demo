using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Stand : MonoBehaviour
{
    [SerializeField] private RectTransform[] _projects;
    public void __ShowProjects() 
    {
        foreach (RectTransform project in _projects)
        {
            LeanTween.move(project, new Vector2(project.anchoredPosition.x, 0), 0.5f).setEaseOutBounce();
        }
    }

    public void __HideProjects() 
    {
        foreach (RectTransform project in _projects)
        {
            LeanTween.move(project, new Vector2(project.anchoredPosition.x, -1), 0.2f).setEaseInCubic();
        }
    }
}
