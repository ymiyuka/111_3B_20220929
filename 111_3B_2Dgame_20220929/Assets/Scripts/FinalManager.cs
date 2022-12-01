using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

namespace yo
{
    /// <summary>
    /// 結束管理氣
    /// </summary>
    public class FinalManager : MonoBehaviour
    {
        public static FinalManager instance;

        /// <summary>
        /// 結束畫布
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 結束標題
        /// </summary>
        private TextMeshProUGUI textTiele;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("結束畫布").GetComponent<CanvasGroup>();
            textTiele = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// 遊戲結束
        /// </summary>
        /// <param name="title"></param>
        public void GameOver(string title)
        {
            textTiele.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// 淡入
        /// </summary>
        /// <returns></returns>
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.2f);
            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;
        }

        /// <summary>
        /// 開頭選單
        /// </summary>
        private void Replay()
        {
            SceneManager.LoadScene("開頭選單");
        }
    }
}
