using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame() 
    {
        print("�}�l�C��");

        SceneManager.LoadScene("���d1");
    }

    public void QuitGame() 
    {
        print("���}�C��");

        Application.Quit();    
    }
}
