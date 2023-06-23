using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubbleText_SY : MonoBehaviour
{
    public List<string> npcTexts = null;
    public bool isTalking = false;
    [SerializeField] private BoogiAction_SY boogiAction = null;

    public void SetNpcText(string _language, string _where)              // NPC 위치에 따라 말할 대사 설정
    {
        if (npcTexts.Count > 0) npcTexts.Clear();

        if (_language == "KOR")
        {
            switch (_where)
            {
                case "부기":
                    npcTexts.Add("안녕?");
                    npcTexts.Add("나는 부기라고 해! 부산의 마스코트지!");
                    npcTexts.Add("너와 함께 여행하면서 여기 광안리에 대해 소개해줄거야.");
                    npcTexts.Add("마침 어방 축제가 열렸어.");
                    npcTexts.Add("전국에서 유일한 전통 어촌 민속문화 축제야.");
                    npcTexts.Add("재밌는 게 많을테니까 마음껏 돌아다니도록 해!");
                    break;
                case "부산월드엑스포조형물":
                    npcTexts.Add("서핑보드가 아주 멋지지?");
                    npcTexts.Add("2030년에 부산에서 월드엑스포가 열릴 수 있도록 기원하는 조형물이야!");
                    npcTexts.Add("개최된다면 세계박람회와 올림픽, 월드컵, 이 세 가지의 메가 이벤트를 모두 개최하는 7번째 국가가 될 수 있대!");
                    npcTexts.Add("뿐만 아니라 국가가 도약하는 계기가 될 수 있다고 들었어.");
                    npcTexts.Add("꿈과 희망을 실현할 미래 세대의 무대가 부산이 된다면 정말 멋질 것 같아!");
                    break;
                case "달팽이톡":
                    npcTexts.Add("오로라 빛이 정말 예쁘지?");
                    npcTexts.Add("이건 특별한 우체통, 달팽이 톡이야!");
                    npcTexts.Add("일종의 예술작품으로서 독특한 분위기를 조성할 뿐 아니라 이곳에 엽서를 넣으면 1년뒤에 발송도 해줘!");
                    npcTexts.Add("1년 뒤의 너에게 해줄 말이 있다면 참여해봐!");
                    break;
                case "안녕광안리조형물":
                    npcTexts.Add("광안리는 오랜 역사를 지니고 있어.");
                    npcTexts.Add("고려시대부터 광안리 일대는 어촌마을이었는데 1960년대부터 관광지로 발전하기 시작했어.");
                    npcTexts.Add("이때부터 해수욕장과 휴게시설이 조성됐고, 지역주민들과 관광객들에게 인기있는 휴양지가 되었지.");
                    npcTexts.Add("1970년대 후반에는 광안대교가 건설됐고 광안리의 상징이 되었어.");
                    npcTexts.Add("1980년대 이후엔 관광산업과 도시화의 영향을 받아 호텔, 리조트, 상업시설 등이 건설됐고");
                    npcTexts.Add("해변가에는 다양한 레스토랑, 카페, 상점들이 형성되어 지금의 광안리가 되었어.");
                    npcTexts.Add("오랜 역사와 함께 휴양이 결함된 매력적인 지역이라서 부산시의 대표적인 관광 명소로 알려졌어.");
                    break;
                case "좌수영어방놀이":
                    npcTexts.Add("우와~! 사람들이 어방 놀이를 하고 있어!");
                    npcTexts.Add("어방놀이는 여기 수영지역에서 전승되는 놀이인데 어업 작업과정과 노동요를 놀이화 한거야");
                    npcTexts.Add("새해를 맞이해서 바다에 나가기 전에 굿과 놀이를 하면서 만선으로 돌아오기를 기원하는 놀이였대");
                    npcTexts.Add("우리나라 유일의 어업협동기구, 좌수영의 어방 전통놀이라는 점에서 큰 의미를 가지는 무형문화재야");
                    break;
                case "어방축제입구":
                    npcTexts.Add("광안리에서는 매년 어방 축제를 해.");
                    npcTexts.Add("한국에서 유일무이한 전통어촌의 민속문화를 소재로 한 축제야.");
                    npcTexts.Add("조선시대 수군과 어민의 어업 공동작업체인 ‘어방’을 소재로 하고있어서 국내외 많은 관람객이 모이는 수영구만의 시그니처 이벤트지.");
                    npcTexts.Add("20년부터 4년 연속 문화관광축제로 선정될 정도로 정통성을 인정받았어.");
                    npcTexts.Add("전시나 체험 프로그램들을 다양하게 즐길 수 있으니까 지나치지 말고 꼭 들려보도록 해!");
                    break;
                case "소망등태마거리":
                    npcTexts.Add("여긴 소망등 테마거리야!");
                    npcTexts.Add("어방축제에서 절대 빼놓을 수 없는 볼거리 중 하나지!");
                    npcTexts.Add("지역주민들의 한 해 소망과 염원을 모아 기원하고 축제를 성공적으로 개최하기 위해 세워졌어!");
                    npcTexts.Add("이곳에서 아름다운 야경을 함께 즐겨보는 건 어때?");
                    break;
            }
        }

        if (_language == "ENG")
        {
            switch (_where)
            {
                case "부기":
                    npcTexts.Add("Hi!");
                    npcTexts.Add("My name is Boogi! Maskot paper in Busan!");
                    npcTexts.Add("While traveling with you, I will introduce Gwangalli here.");
                    npcTexts.Add("It's just in time for the Eobang Festival.");
                    npcTexts.Add("It is the only traditional fishing village folk culture festival in the country.");
                    npcTexts.Add("There will be a lot of fun, so go around as much as you want!");
                    break;
                case "부산월드엑스포조형물":
                    npcTexts.Add("Isn't the surfboard cool?");
                    npcTexts.Add("It is a sculpture that wishes for the World Expo to be held in Busan in 2030!");
                    npcTexts.Add("If held, it could be the seventh country to host all three mega events: the World Expo, the Olympics, and the World Cup!");
                    npcTexts.Add("Not only that, but I heard that it can be an opportunity for the country to take off.");
                    npcTexts.Add("It would be great if the stage of future generations that will realize their dreams and hopes becomes Busan!");
                    break;
                case "달팽이톡":
                    npcTexts.Add("Isn't the aurora light really pretty?");
                    npcTexts.Add("This is a special mailbox, 'snail talk'!");
                    npcTexts.Add("Not only does it create a unique atmosphere as a kind of artwork, but if you put a postcard here, please send it a year later!");
                    npcTexts.Add("If you have anything to say to you in a year's time, join us!");
                    break;
                case "안녕광안리조형물":
                    npcTexts.Add("Gwangalli has a long history.");
                    npcTexts.Add("Since the Goryeo Dynasty, Gwangalli has been a fishing village, and it has developed into a tourist destination since the 1960s.");
                    npcTexts.Add("Since then, beaches and rest facilities have been established, and it has become a popular resort for local residents and tourists.");
                    npcTexts.Add("Gwangandaegyo Bridge was built in the late 1970s and became a symbol of Gwangalli.");
                    npcTexts.Add("Since the 1980s, hotels, resorts, and commercial facilities have been built under the influence of the tourism industry");
                    npcTexts.Add("and urbanization, and various restaurants, cafes, and shops have been formed on the beach, making it the current Gwangalli.");
                    npcTexts.Add(" It is known as a representative tourist attraction in Busan because it is an attractive area with a long history and defective recreation.");
                    break;
                case "좌수영어방놀이":
                    npcTexts.Add("Wow! People are playing Eobang!");
                    npcTexts.Add("Eobang Nori is a game that is handed down here in Suyeong area, and it is a play of fishing process and labor songs.");
                    npcTexts.Add("Before going to the sea for the new year, it was a game to play with the gut and pray for a return to Manseon.");
                    npcTexts.Add(" It is an intangible cultural property with great significance in that it is the only fishing cooperative organization in Korea, the Eobang traditional game of Jwasuyeong.");
                    break;
                case "어방축제입구":
                    npcTexts.Add("There is an Eobang Festival every year in Gwangalli. ");
                    npcTexts.Add("It is a festival based on the folk culture of traditional fishing villages, which is unique in Korea.");
                    npcTexts.Add("It is a signature event unique to Suyeong-gu, where many domestic and foreign visitors gather, as it is based on Eobang, a fishing joint work between naval forces and fishermen in the Joseon Dynasty.");
                    npcTexts.Add("It has been recognized for its legitimacy to the extent that it has been selected as a cultural tourism festival for four consecutive years since 2020.");
                    npcTexts.Add("You can enjoy various exhibitions and experience programs, so don't miss it and make sure to stop by!");
                    break;
                case "소망등태마거리":
                    npcTexts.Add("This is a wish light theme street!");
                    npcTexts.Add("It's one of the must-see attractions at the Eobang Festival!");
                    npcTexts.Add("It was built to gather the wishes and wishes of local residents for the year and to successfully hold the festival!");
                    npcTexts.Add("How about enjoying the beautiful night view together here?");
                    break;
            }
        }
    }

    public void PlayTyping(int num) // 삽입한 텍스트 타이핑식으로 나타내는 기능
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
