using System.Collections;
using UnityEngine;
using TMPro;

public class TitleScreen : Menu
{
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI copyrightText;
    [SerializeField] private int releaseYear;
    [SerializeField] private float visibilityTime;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            menuManager.Show<MainMenu>();
    }

    public override void Initialize()
    {
        int currentYear = System.DateTime.Now.Year;
        string copyright = currentYear <= releaseYear ? $"©{currentYear}" : $"©{releaseYear}-{currentYear}";
        copyrightText.text = $"{copyright} {Application.companyName}";
    }

    public override void Show()
    {
        base.Show();
        StartCoroutine(FadePromptText());
    }

    public override void Hide()
    {
        base.Hide();
        StopCoroutine(FadePromptText());
    }

    private IEnumerator FadePromptText()
    {
        while (true)
        {
            promptText.gameObject.SetActive(false);
            yield return new WaitForSeconds(visibilityTime);
            promptText.gameObject.SetActive(true);
            yield return new WaitForSeconds(visibilityTime);
        }
    }
}