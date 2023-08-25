using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextPlus : Text
{
    public string languageKey;
    private const string fontName = "Made";//默认字体名称 统一改字体
    protected override void Awake()
    {
        base.Awake();
        if (!string.IsNullOrEmpty(languageKey))
            this.text = LanguageManager.Instance.KeyToLanguageText(languageKey);
        ChangeFont();
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        if(!string.IsNullOrEmpty(languageKey))
            this.text = LanguageManager.Instance.KeyToLanguageText(languageKey);
        ChangeFont();
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
    private void ChangeFont()
    {
        if (!string.IsNullOrEmpty(fontName))
        {
            var loadfont = Resources.Load<Font>($"Font/{fontName}");
            if(loadfont!=null)
                this.font= loadfont;
        }
    }
    public TextPlus Splicing(string str)
    {
        if (!string.IsNullOrEmpty(languageKey))
            this.text =$"{LanguageManager.Instance.KeyToLanguageText(languageKey)} {str}" ;
        return this;
    }
    public TextPlus SetKey(string key)
    {
        this.text = LanguageManager.Instance.KeyToLanguageText(key);
        return this;
    }
}
