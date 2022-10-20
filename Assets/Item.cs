using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item", order = 0)]
public class Item : ScriptableObject
{
    [SerializeField] private ItemType _itemType;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private ItemBehavior _itemBehavior;
    public ItemType ItemType => _itemType;
    public Sprite Sprite => _sprite;
    public ItemBehavior ItemBehavior => _itemBehavior;
}