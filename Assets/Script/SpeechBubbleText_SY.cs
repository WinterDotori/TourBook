using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbleText_SY : MonoBehaviour
{
    public List<string> npcTexts = null;
    public bool isTalking = false;
    [SerializeField] private BoogiAction_SY boogiAction = null;

    public void SetNpcText(string _language, string _where)              // NPC ��ġ�� ���� ���� ��� ����
    {
        if (npcTexts.Count > 0) npcTexts.Clear();

        if (_language == "KOR")
        {
            switch (_where)
            {
                case "�α�":
                    npcTexts.Add("�ȳ�?");
                    npcTexts.Add("���� �α��� ��! �λ��� ������Ʈ��!");
                    npcTexts.Add("�ʿ� �Բ� �����ϸ鼭 ���� ���ȸ��� ���� �Ұ����ٰž�.");
                    npcTexts.Add("��ħ ��� ������ ���Ⱦ�.");
                    npcTexts.Add("�������� ������ ���� ���� �μӹ�ȭ ������.");
                    npcTexts.Add("��մ� �� �����״ϱ� ������ ���ƴٴϵ��� ��!");
                    break;
                case "�λ���忢����������":
                    npcTexts.Add("���κ��尡 ���� ������?");
                    npcTexts.Add("2030�⿡ �λ꿡�� ���忢������ ���� �� �ֵ��� ����ϴ� �������̾�!");
                    npcTexts.Add("���ֵȴٸ� ����ڶ�ȸ�� �ø���, ������, �� �� ������ �ް� �̺�Ʈ�� ��� �����ϴ� 7��° ������ �� �� �ִ�!");
                    npcTexts.Add("�Ӹ� �ƴ϶� ������ �����ϴ� ��Ⱑ �� �� �ִٰ� �����.");
                    npcTexts.Add("�ް� ����� ������ �̷� ������ ���밡 �λ��� �ȴٸ� ���� ���� �� ����!");
                    break;
                case "��������":
                    npcTexts.Add("���ζ� ���� ���� ������?");
                    npcTexts.Add("�̰� Ư���� ��ü��, ������ ���̾�!");
                    npcTexts.Add("������ ������ǰ���μ� ��Ư�� �����⸦ ������ �� �ƴ϶� �̰��� ������ ������ 1��ڿ� �߼۵� ����!");
                    npcTexts.Add("1�� ���� �ʿ��� ���� ���� �ִٸ� �����غ�!");
                    break;
                case "�ȳ籤�ȸ�������":
                    npcTexts.Add("���ȸ��� ���� ���縦 ���ϰ� �־�.");
                    npcTexts.Add("����ô���� ���ȸ� �ϴ�� ���̸����̾��µ� 1960������ �������� �����ϱ� �����߾�.");
                    npcTexts.Add("�̶����� �ؼ������ �ްԽü��� �����ư�, �����ֹε�� �������鿡�� �α��ִ� �޾����� �Ǿ���.");
                    npcTexts.Add("1970��� �Ĺݿ��� ���ȴ뱳�� �Ǽ��ư� ���ȸ��� ��¡�� �Ǿ���.");
                    npcTexts.Add("1980��� ���Ŀ� ��������� ����ȭ�� ������ �޾� ȣ��, ����Ʈ, ����ü� ���� �Ǽ��ư�");
                    npcTexts.Add("�غ������� �پ��� �������, ī��, �������� �����Ǿ� ������ ���ȸ��� �Ǿ���.");
                    npcTexts.Add("���� ����� �Բ� �޾��� ���Ե� �ŷ����� �����̶� �λ���� ��ǥ���� ���� ��ҷ� �˷�����.");
                    break;
                case "�¼���������":
                    npcTexts.Add("���~! ������� ��� ���̸� �ϰ� �־�!");
                    npcTexts.Add("�����̴� ���� ������������ ���µǴ� �����ε� ��� �۾������� �뵿�並 ����ȭ �Ѱž�");
                    npcTexts.Add("���ظ� �����ؼ� �ٴٿ� ������ ���� �°� ���̸� �ϸ鼭 �������� ���ƿ��⸦ ����ϴ� ���̿���");
                    npcTexts.Add("�츮���� ������ ��������ⱸ, �¼����� ��� ������̶�� ������ ū �ǹ̸� ������ ������ȭ���");
                    break;
                case "��������Ա�":
                    npcTexts.Add("���ȸ������� �ų� ��� ������ ��.");
                    npcTexts.Add("�ѱ����� ���Ϲ����� ��������� �μӹ�ȭ�� ����� �� ������.");
                    npcTexts.Add("�����ô� ������ ����� ��� �����۾�ü�� ����桯�� ����� �ϰ��־ ������ ���� �������� ���̴� ���������� �ñ״�ó �̺�Ʈ��.");
                    npcTexts.Add("20����� 4�� ���� ��ȭ���������� ������ ������ ���뼺�� �����޾Ҿ�.");
                    npcTexts.Add("���ó� ü�� ���α׷����� �پ��ϰ� ��� �� �����ϱ� ����ġ�� ���� �� ��������� ��!");
                    break;
                case "�Ҹ����¸��Ÿ�":
                    npcTexts.Add("���� �Ҹ��� �׸��Ÿ���!");
                    npcTexts.Add("����������� ���� ������ �� ���� ���Ÿ� �� �ϳ���!");
                    npcTexts.Add("�����ֹε��� �� �� �Ҹ��� ������ ��� ����ϰ� ������ ���������� �����ϱ� ���� ��������!");
                    npcTexts.Add("�̰����� �Ƹ��ٿ� �߰��� �Բ� ��ܺ��� �� �?");
                    break;
            }
        }

        if (_language == "ENG")
        {
            switch (_where)
            {
                case "�α�":
                    npcTexts.Add("Hi!");
                    npcTexts.Add("My name is Boogi! Maskot paper in Busan!");
                    npcTexts.Add("While traveling with you, I will introduce Gwangalli here.");
                    npcTexts.Add("It's just in time for the Eobang Festival.");
                    npcTexts.Add("It is the only traditional fishing village folk culture festival in the country.");
                    npcTexts.Add("There will be a lot of fun, so go around as much as you want!");
                    break;
                case "�λ���忢����������":
                    npcTexts.Add("Isn't the surfboard cool?");
                    npcTexts.Add("It is a sculpture that wishes for the World Expo to be held in Busan in 2030!");
                    npcTexts.Add("If held, it could be the seventh country to host all three mega events: the World Expo, the Olympics, and the World Cup!");
                    npcTexts.Add("Not only that, but I heard that it can be an opportunity for the country to take off.");
                    npcTexts.Add("It would be great if the stage of future generations that will realize their dreams and hopes becomes Busan!");
                    break;
                case "��������":
                    npcTexts.Add("Isn't the aurora light really pretty?");
                    npcTexts.Add("This is a special mailbox, 'snail talk'!");
                    npcTexts.Add("Not only does it create a unique atmosphere as a kind of artwork, but if you put a postcard here, please send it a year later!");
                    npcTexts.Add("If you have anything to say to you in a year's time, join us!");
                    break;
                case "�ȳ籤�ȸ�������":
                    npcTexts.Add("Gwangalli has a long history.");
                    npcTexts.Add("Since the Goryeo Dynasty, Gwangalli has been a fishing village, and it has developed into a tourist destination since the 1960s.");
                    npcTexts.Add("Since then, beaches and rest facilities have been established, and it has become a popular resort for local residents and tourists.");
                    npcTexts.Add("Gwangandaegyo Bridge was built in the late 1970s and became a symbol of Gwangalli.");
                    npcTexts.Add("Since the 1980s, hotels, resorts, and commercial facilities have been built under the influence of the tourism industry");
                    npcTexts.Add("and urbanization, and various restaurants, cafes, and shops have been formed on the beach, making it the current Gwangalli.");
                    npcTexts.Add(" It is known as a representative tourist attraction in Busan because it is an attractive area with a long history and defective recreation.");
                    break;
                case "�¼���������":
                    npcTexts.Add("Wow! People are playing Eobang!");
                    npcTexts.Add("Eobang Nori is a game that is handed down here in Suyeong area, and it is a play of fishing process and labor songs.");
                    npcTexts.Add("Before going to the sea for the new year, it was a game to play with the gut and pray for a return to Manseon.");
                    npcTexts.Add(" It is an intangible cultural property with great significance in that it is the only fishing cooperative organization in Korea, the Eobang traditional game of Jwasuyeong.");
                    break;
                case "��������Ա�":
                    npcTexts.Add("There is an Eobang Festival every year in Gwangalli. ");
                    npcTexts.Add("It is a festival based on the folk culture of traditional fishing villages, which is unique in Korea.");
                    npcTexts.Add("It is a signature event unique to Suyeong-gu, where many domestic and foreign visitors gather, as it is based on Eobang, a fishing joint work between naval forces and fishermen in the Joseon Dynasty.");
                    npcTexts.Add("It has been recognized for its legitimacy to the extent that it has been selected as a cultural tourism festival for four consecutive years since 2020.");
                    npcTexts.Add("You can enjoy various exhibitions and experience programs, so don't miss it and make sure to stop by!");
                    break;
                case "�Ҹ����¸��Ÿ�":
                    npcTexts.Add("This is a wish light theme street!");
                    npcTexts.Add("It's one of the must-see attractions at the Eobang Festival!");
                    npcTexts.Add("It was built to gather the wishes and wishes of local residents for the year and to successfully hold the festival!");
                    npcTexts.Add("How about enjoying the beautiful night view together here?");
                    break;
            }
        }
    }

    public void PlayTyping(int num) // ������ �ؽ�Ʈ Ÿ���ν����� ��Ÿ���� ���
    {
        StartCoroutine(Typing(npcTexts[num]));
    }

    IEnumerator Typing(string text)
    {
        isTalking = true;
        boogiAction.isClickNextButton = false;

        foreach (char letter in text.ToCharArray())
        {
            print(letter);
            yield return new WaitForSeconds(1f);
            isTalking = false;
        }
    }
}
