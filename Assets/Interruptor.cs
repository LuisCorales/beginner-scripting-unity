using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interruptor : MonoBehaviour
{
    [SerializeField] GameObject lightbulb;
    [SerializeField] GameObject interruptorSwitch;

    // Rota el flip del switch
    public void FlipSwitch(bool isOn)
    {
        int value;

        if(isOn)
            value = 55;
        else
            value = -55;

        interruptorSwitch.transform.eulerAngles = new Vector3(
            value,
            interruptorSwitch.transform.eulerAngles.y,
            interruptorSwitch.transform.eulerAngles.z
        );
    }

    // Cuando el interruptor es clickeado, apaga o prende la luz
    private void OnMouseDown() {
        var light = lightbulb.GetComponent<Light>();
        
        light.enabled = !light.enabled;

        Debug.Log("Light is on: " + light.enabled);
        
        FlipSwitch(light.enabled);
    }
}
