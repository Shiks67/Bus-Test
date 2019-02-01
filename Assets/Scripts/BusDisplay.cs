using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusDisplay : MonoBehaviour
{
    public Material poles, polesMarker, stopButtonPlastic, stopButtonButton;

    public void DisplayBus()
    {
        if (GameObject.FindGameObjectWithTag("Bus") != null)
        {
            foreach (var bus in GameObject.FindGameObjectsWithTag("Bus"))
            {
                bus.SetActive(false);
            }
        }
        gameObject.SetActive(!gameObject.activeSelf);
    }

    /// <summary>
    /// set model A colors
    /// </summary>
    public void ModelA()
    {
        poles.color = new Color32(166, 192, 227, 255);
        stopButtonPlastic.color = new Color32(246, 241, 134, 255);
        stopButtonButton.color = new Color32(0, 126, 255, 255);
    }

    /// <summary>
    /// set model B colors
    /// </summary>
    public void ModelB()
    {
        poles.color = new Color32(246, 241, 134, 255);
        stopButtonPlastic.color = new Color32(246, 241, 134, 255);
        stopButtonButton.color = new Color32(0, 126, 255, 255);
    }

    /// <summary>
    /// set model Bv.2 colors
    /// </summary>
    public void ModelB2()
    {
        poles.color = new Color32(246, 241, 134, 255);
        stopButtonPlastic.color = new Color32(110, 110, 110, 255);
        stopButtonButton.color = new Color32(255, 0, 0, 255);
    }

    /// <summary>
    /// set model C colors
    /// </summary>
    public void ModelC()
    {
        poles.color = new Color32(110, 110, 110, 255);
        polesMarker.color = new Color32(246, 241, 134, 255);
        stopButtonPlastic.color = new Color32(246, 241, 134, 255);
        stopButtonButton.color = new Color32(166, 192, 227, 255);
    }

    /// <summary>
    /// set model D colors
    /// </summary>
    public void ModelD()
    {
        poles.color = new Color32(110, 110, 110, 255);
        polesMarker.color = new Color32(246, 241, 134, 255);
        stopButtonPlastic.color = new Color32(110, 110, 110, 255);
        stopButtonButton.color = new Color32(255, 0, 0, 255);
    }
}
