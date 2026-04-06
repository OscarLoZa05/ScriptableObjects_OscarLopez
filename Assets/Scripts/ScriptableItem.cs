using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Items")]
public class ScriptableItem : ScriptableObject
{

    //0 Castellano - 1 Ingles - 2 Catalan//
    public string[] Translations = new string[3];
}