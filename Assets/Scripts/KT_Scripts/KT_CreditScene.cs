using UnityEngine;
using UnityEngine.SceneManagement;

public class KT_CreditScene : MonoBehaviour
{
    public void playCredits()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Credits", LoadSceneMode.Additive);
    }
}
