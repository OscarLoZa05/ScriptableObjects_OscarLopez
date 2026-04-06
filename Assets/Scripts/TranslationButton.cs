using UnityEngine;
using UnityEngine.UI;

public class TranslationButton : MonoBehaviour
{

    public int indexButton;
    private Button thisButton;

    void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(Click);
    }

    public void Click()
    {
        TranslationManager.Instance.Translation(indexButton);
    }
}
