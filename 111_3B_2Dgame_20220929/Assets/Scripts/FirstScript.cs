using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Yo
{
    /// <summary>
    /// �Ĥ@�Ӹ}��
    /// 2022.10.13
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region ----���Ѱϰ�----
        // �Y�� �ֱ��� : teb
        // �榡�Ƥ�r �ֱ��� : Ctrl + K D

        // ������
        /* �h��
         * ����
         */

        // A a ���ۦP���r
        #endregion

        #region ----�ƥ�ϰ�----
        //����ƥ� : �C���}�l�ɰ���@��
        private void Awake()
        {
            print("���o�A�U�w :D");
        }
        //�}�l�ƥ� : awake �����@��
        private void Start()
        {
            print("<color=yellow>�}�l�ƥ�</color>");
        }
        private void Update()
        {
            //��s�ƥ� : strat �������A����� 60 FPS
            print("<color=green>��s�ƥ�</color>");
        }
        #endregion
    }
}
