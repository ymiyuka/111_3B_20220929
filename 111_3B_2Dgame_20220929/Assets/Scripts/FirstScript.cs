using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yo
{
    /// <summary>
    /// 第一個腳本
    /// 2022.10.13
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ----註解區域----
        // 縮排 快捷鍵 : teb
        // 格式化文字 快捷鍵 : Ctrl + K D

        // 單行註解
        /* 多行
         * 註解
         */

        // A a 不相同的字
        #endregion

        #region ----事件區域----
        //喚醒事件 : 遊戲開始時執行一次
        private void Awake()
        {
            print("哈囉，沃德 :D");
        }
        //開始事件 : awake 後執行一次
        private void Start()
        {
            print("<color=yellow>開始事件</color>");
        }
        private void Update()
        {
            //更新事件 : strat 之後執行，執行約 60 FPS
            print("<color=green>更新事件</color>");
        }
        #endregion
    }
}
