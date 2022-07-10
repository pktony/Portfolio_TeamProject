using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;

    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    private void GenerateData()
    {

        //�Ϲ� ��ȭ
        talkData.Add(1000, new string[] { "�ȳ�?", "�ʴ�?...����־��� �Ŵ�?", "�� �װ� �߿����� �ʰ�...", "�� ������ ������ �ٶ�" });

        talkData.Add(2000, new string[] {"����� ���� �ɷ� ���� �ִ� ����", "������ �� ���� �ϵ��� ���� �Ͼ���ϴ�.", "�ֹε鵵 ������ ���� �����̴� ��ŵ� ��������."});

        talkData.Add(100, new string[] { "����� �����̴�." });

        //����Ʈ ��ȭ
        talkData.Add(10 + 1000, new string[] { "��� : �ֹε��� ���� ����?....", "��� : ��...", "��� : ���� ���� �ֺ��� ���Ͱ� ����", "��� : �װ� ���� ū �����̾���", "���� : ���͵��� óġ�ؾ߰ڱ���...�ٸ� �ֹο��� ���� �ɾ��"});
        talkData.Add(11 + 2000, new string[] { "�ֹ� : ��ΰ� �׷��� ���ߴٰ�?", "�ֹ� : �� ������ �� �޶�", "�ֹ� : ������ ���� �ٵ� ������ٰ�!", "���� : (��...������ ����)"});

        talkData.Add(20 + 2000, new string[] { "�ֹ� : �ٻ��� ������ ���� �ϳ� ������ �� �ִ�?" });
        talkData.Add(20 + 3000, new string[] { "���� : �� ���� ��������." }); //���⼭ �� �Ѿ

        talkData.Add(21 + 2000, new string[] { "�ֹ� : ������...", "�ֹ� : ���Ŵ� ������...��ο��� ����� �ִ� �� ����" });

        talkData.Add(30 + 2000, new string[] { "�ֹ� : �켱....���͵��� ��ġ��°� ���?" });
        talkData.Add(31 + 1000, new string[] { "��� : ���� óġ�� �����̾�?", "���� : �ƹ� ���ͳ� 5���� ��ƺ���..."});
    }

    public string GetTalk(int id, int talkIndex)
    {
        if(!talkData.ContainsKey(id))
        {
            if (!talkData.ContainsKey(id - id % 10))
            {
                if (talkIndex == talkData[id - id % 100].Length)
                {
                    return null;
                }
                else
                {
                    return talkData[id - id % 100][talkIndex];
                }
            }
            else
            {
                //����Ʈ ���� �� ��簡 ���� �� 
                //����Ʈ �� ó�� ��縦 ������ ��
                if (talkIndex == talkData[id - id % 10].Length)
                {
                    return null;
                }
                else
                {
                    return talkData[id - id % 10][talkIndex];
                }
            }
        }

        if (talkIndex == talkData[id].Length)
        {
            return null;
        }
        else
        {
            //id�� ��ȭ talkIndex�� ��ȭ�� �� ������ ����
            return talkData[id][talkIndex];
        }
    }
}