using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagePlus : Image
{
    public string languageKey;
    protected override void Awake()
    {
        base.Awake();
        if (!string.IsNullOrEmpty(languageKey))
        {
            var sp = LanguageManager.Instance.KeyToLanguageImage(languageKey);
            if (sp != null)
                this.sprite = sp;
        }
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        if (!string.IsNullOrEmpty(languageKey))
        {
            var sp = LanguageManager.Instance.KeyToLanguageImage(languageKey);
            if (sp != null)
                this.sprite = sp;
        }
    }
    public void OnRefresh()
    {
        if (!string.IsNullOrEmpty(languageKey))
        {
            var sp = LanguageManager.Instance.KeyToLanguageImage(languageKey);
            if (sp != null)
                this.sprite = sp;
        }
    }
    
}
