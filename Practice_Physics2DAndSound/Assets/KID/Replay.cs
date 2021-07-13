using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    /// <summary>
    /// 場景名稱
    /// </summary>
    private string nameScene;

    /// <summary>
    /// 重新開始遊戲
    /// </summary>
    /// <param name="scene">要重新開始的場景</param>
    public void ReplayGame(string scene)
    {
        nameScene = scene;
        Invoke("DelayReplay", 1.5f);
    }

    /// <summary>
    /// 延遲重新遊戲
    /// </summary>
    private void DelayReplay()
    {
        SceneManager.LoadScene(nameScene);
    }
}
