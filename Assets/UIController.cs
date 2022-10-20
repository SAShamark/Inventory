using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public List<InventorySlot> Slots { get; private set; }
    public int StartSlotCount { get; private set; } = 24;
    [SerializeField] private InventorySlot _inventorySlot;
    [SerializeField] private Transform _slotContainer;

    private void Start()
    {
        Slots=new List<InventorySlot>();
        GenerateSlots(StartSlotCount);
    }

    public void GenerateSlots(int slotCount)
    {
        for (int i = 0; i < slotCount; i++)
        {
            Slots.Add(Instantiate(_inventorySlot, _slotContainer));
        }
    }
}