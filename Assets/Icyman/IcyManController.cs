using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class IcyManController : MonoBehaviour
{
    [SerializeField] private GameObject icyMan;
    [SerializeField] private bool lightEnabled = true;
    [SerializeField] private List<Light> lightSourcesIgnoringSwitchMode;
    private List<Light> lightSources;
        
    void Start()
    {
        lightSources = FindObjectsOfType<Light>().ToList();
        lightSourcesIgnoringSwitchMode.ForEach(ignoringSource => lightSources.Remove(ignoringSource));
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            SwitchMode();
        }
    }

    public void SwitchMode()
    {
        lightEnabled = !lightEnabled;
        lightSources.ForEach(lightSource => lightSource.gameObject.SetActive(lightEnabled));
        icyMan.SetActive(!lightEnabled);
    }
}
