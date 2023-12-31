using TMPro;
using UnityEngine;

public class TextProPlus : TextMeshProUGUI
{
    public string languageKey;

    protected override void Awake()
    {
        base.Awake();
        if (!string.IsNullOrEmpty(languageKey))
            this.text = LanguageManager.Instance.KeyToLanguageText(languageKey);
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        if (!string.IsNullOrEmpty(languageKey))
            this.text = LanguageManager.Instance.KeyToLanguageText(languageKey);
    }
    public void OnRefresh()
    {
        if (!string.IsNullOrEmpty(languageKey))
            this.text = LanguageManager.Instance.KeyToLanguageText(languageKey);
    }
    public void OnRefresh(params object[] datas)
    {
        if (!string.IsNullOrEmpty(languageKey))
            this.text = LanguageManager.Instance.KeyToLanguageText(languageKey, datas);
    }
}
