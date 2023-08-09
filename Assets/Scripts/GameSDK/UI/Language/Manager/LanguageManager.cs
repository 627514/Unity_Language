using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageManager 
{
    private static LanguageManager instance;    
    public static LanguageManager Instance
    {
        get
        {
            if (instance == null)
                instance = new LanguageManager();
            return instance;
        }
    }
    List<LanguageData> languageList;
    const string loadPath = "Language/Sheet1";
    public LanguageManager()
    {
        if (languageList == null)
        {
            languageList= new List<LanguageData>();
            var data = Resources.Load<TextAsset>(loadPath).text;
            var js= LitJson.JsonMapper.ToObject<LanguageData[]>(data);
            foreach (var item in js)
            {
                languageList.Add(item);
            }
        }
    }

    public string KeyToLanguageText(string key)
    {
        if (languageList == null)
        {
            Debug.LogError("languageList Is Null ");
            return $"Null {key}";
        }
        foreach (LanguageData item in languageList)
        {
            if(item.Key== key)
                return GetSystemLanguageText(item);
        }
        Debug.LogError("Find Key Is Null -->" + key);
        return $"Null {key}";
    }
    public string KeyToLanguageText(string key, params object[] args)
    {
        if (languageList == null)
        {
            Debug.LogError("languageList Is Null ");
            return $"Null {key}";
        }
        foreach (LanguageData item in languageList)
        {
            if (item.Key == key)
            {
                string str = GetSystemLanguageText(item);
                str = string.Format(str, args);
                return str;
            }
        }
        Debug.LogError("Find Key Is Null -->" + key);
        return $"Null {key}";
    }
    public Sprite KeyToLanguageImage(string key)
    {
        //if (languageList == null)
        //{
        //    Debug.LogError("languageList Is Null ");
        //    return $"Null {key}";
        //}
        //foreach (LanguageData item in languageList)
        //{
        //    if (item.Key == key)
        //        return GetSystemLanguageText(item);
        //}
        //Debug.LogError("Find Key Is Null -->" + key);
        //return $"Null {key}";

        return null;

    }

    private string GetSystemLanguageText(LanguageData data)
    {
        switch (Application.systemLanguage)
        {
            case SystemLanguage.Afrikaans:
                return data.English;
            case SystemLanguage.Arabic:
                return data.English;
            case SystemLanguage.Basque:
                return data.English;
            case SystemLanguage.Belarusian:
                return data.English;
            case SystemLanguage.Bulgarian:
                return data.English;
            case SystemLanguage.Catalan:
                return data.English;
            case SystemLanguage.Chinese:
                return data.ChineseSimplified;
            case SystemLanguage.Czech:
                return data.English;
            case SystemLanguage.Danish:
                return data.English;
            case SystemLanguage.Dutch:
                return data.English;
            case SystemLanguage.English:
                return data.English;
            case SystemLanguage.Estonian:
                return data.English;
            case SystemLanguage.Faroese:
                return data.English;
            case SystemLanguage.Finnish:
                return data.English;
            case SystemLanguage.French:
                return data.French;
            case SystemLanguage.German:
                return data.German;
            case SystemLanguage.Greek:
                return data.English;
            case SystemLanguage.Hebrew:
                return data.English;
            case SystemLanguage.Icelandic:
                return data.English;
            case SystemLanguage.Indonesian:
                return data.English;
            case SystemLanguage.Italian:
                return data.Italian;
            case SystemLanguage.Japanese:
                return data.Japanese;
            case SystemLanguage.Korean:
                return data.English;
            case SystemLanguage.Latvian:
                return data.English;
            case SystemLanguage.Lithuanian:
                return data.English;
            case SystemLanguage.Norwegian:
                return data.English;
            case SystemLanguage.Polish:
                return data.English;
            case SystemLanguage.Portuguese:
                return data.Portuguese;
            case SystemLanguage.Romanian:
                return data.English;
            case SystemLanguage.Russian:
                return data.Russian;
            case SystemLanguage.SerboCroatian:
                return data.English;
            case SystemLanguage.Slovak:
                return data.English;
            case SystemLanguage.Slovenian:
                return data.English;
            case SystemLanguage.Spanish:
                return data.Spanish;
            case SystemLanguage.Swedish:
                return data.English;
            case SystemLanguage.Thai:
                return data.English;
            case SystemLanguage.Turkish:
                return data.English;
            case SystemLanguage.Ukrainian:
                return data.English;
            case SystemLanguage.Vietnamese:
                return data.English;
            case SystemLanguage.ChineseSimplified:
                return data.ChineseSimplified;
            case SystemLanguage.ChineseTraditional:
                return data.ChineseTraditional;
            case SystemLanguage.Unknown:
                return data.English;
            case SystemLanguage.Hungarian:
                return data.English;
            default:
                return data.English;
        }
    }
    

}
public class LanguageData
{
    /// <summary>
    /// Œ®“ª±‡∫≈
    /// </summary>
    public string Key;
    /// <summary>
    /// ”¢”Ô
    /// </summary>
    public string English;
    /// <summary>
    /// ÷–ŒƒºÚÃÂ
    /// </summary>
    public string ChineseSimplified;
    /// <summary>
    /// »’”Ô
    /// </summary>
    public string Japanese;
    /// <summary>
    /// µ¬”Ô
    /// </summary>
    public string German;
    /// <summary>
    /// ∑®”Ô
    /// </summary>
    public string French;
    /// <summary>
    /// Œ˜∞‡—¿”Ô
    /// </summary>
    public string Spanish;
    /// <summary>
    /// ∆œÃ——¿”Ô
    /// </summary>
    public string Portuguese;
    /// <summary>
    /// “‚¥Û¿˚”Ô
    /// </summary>
    public string Italian;
    /// <summary>
    /// ∂Ì”Ô
    /// </summary>
    public string Russian;
    /// <summary>
    /// ”°µÿ”Ô
    /// </summary>
    public string Hindi;
    /// <summary>
    /// ∑±ÃÂ÷–Œƒ
    /// </summary>
    public string ChineseTraditional;
    /// <summary>
    /// ∞¢¿≠≤Æ”Ô
    /// </summary>
    public string Arabic;
    /// <summary>
    /// “¡¿ ”Ô
    /// </summary>
    public string Iran;

    public LanguageData()
    {

    }
}
