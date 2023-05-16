using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FloatingHealthBar : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private Slider slider;

    private void Awake()
    {
        camera = FindObjectOfType<Camera>();
    }
    public void UpdateHealthBar(int currentValue, float maxValue)
    {
        slider.value = currentValue / maxValue;
    }
    private void Update()
    {
        transform.rotation = camera.transform.rotation;
    }
}
