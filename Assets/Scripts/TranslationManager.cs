using UnityEngine;
using UnityEngine.UI;

public class TranslationManager : MonoBehaviour
{
    public static TranslationManager Instance;

    void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public ScriptableItem[] items;
    public Text[] itemsNames;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Translation(int indexTranslation)
    {
        for (int i = 0; i < items.Length; i++)
        {
            itemsNames[i].text = items[i].Translations[indexTranslation].ToString();
        }
    }


}
