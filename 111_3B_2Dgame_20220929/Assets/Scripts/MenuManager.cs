using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace MyNamespace
{
    /// <summary>
    /// 選單管理器
    /// </summary>
    public class MenuManager : MonoBehaviour
    {

        /// <summary>
        /// 遊戲開始
        /// </summary>
        private Button bntPlay;

        private void Awake()
        {
            bntPlay = GameObject.Find("開始遊戲").GetComponent<Button>();
            bntPlay.onClick.AddListener(StartGame);
        }

        /// <summary>
        /// 開始遊戲
        /// </summary>
        private void StartGame()
        {
            SceneManager.LoadScene("遊戲場景");
        }
    }
}

