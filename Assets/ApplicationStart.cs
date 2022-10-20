using System.Collections.Generic;
using UnityEngine;

public class ApplicationStart : MonoBehaviour
{
    private void Start()
    {
        Inventory();
    }

    private void Inventory()
    {
        var uiController = new UIController();
        uiController.GenerateSlots(uiController.StartSlotCount);
    }
}