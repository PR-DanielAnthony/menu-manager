using UnityEngine;

public abstract class Menu : MonoBehaviour
{
    protected MenuManager menuManager;

    public void SetMenuManager(MenuManager menuManager)
    {
        this.menuManager = menuManager;
    }

    public abstract void Initialize();

    public virtual void Show()
    {
        gameObject.SetActive(true);
    }

    public virtual void Hide()
    {
        gameObject.SetActive(false);
    }
}