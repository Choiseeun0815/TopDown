## 스파르타 탑뷰 게임
1. Unity를 이용해 Zep과 같은 시점의 게임을 모방해 만드는 과제
---
### 🚨 필수 요구 사항 (👍 → 모두 구현 완료)
* **캐릭터 만들기** - 외부 그림 파일을 추가하여 2D 캐릭터를 추가한다.
* **캐릭터 이동** - 키보드 WASD를 이용하여 캐릭터를 움직인다. 캐릭터는 마우스 방향을 바라본다.
* **방 만들기** - 타일 맵을 이용하여 맵을 만들고 콜라이더를 이용해 벽을 넘어가지 못하게 한다.
* **카메라 따라가기** - 카메라는 움직임에 따라 캐릭터를 따라간다.
* **캐릭터 애니메이션 추가** - 게임을 실행하면 캐릭터가 애니매이션을 반복한다.
* **이름 입력 시스템** - 실행시 이름을 입력 받을 수 있는 UI를 만든다. 
  * 입력 받은 이름이 2~10자 사이가 아니라면 Join 버튼이 눌리지 않는다
  * Join을 누르면 맵으로 이동하여 캐릭터 위에 이름표가 나타난다.
  * 이름표는 캐릭터가 움직이면 따라다닌다. 
* **캐릭터 선택 시스템** - 맵으로 들어가기 전 캐릭터가 표시되는 UI가 나타난다.
  * 캐릭터를 클릭하면 캐릭터 선택 팝업이 나타난다.
  * 캐릭터를 선택하면 팝업이 닫힌다.
  * 선택했던 캐릭터가 표시된다.
---
### ❄️ 선택 요구 사항 (👍 → 모두 구현 완료)
* **시간 표시** - 왼쪽 상단에 현재 시간을 표시하는 UI를 만든다.
* **인게임 이름 바꾸기** - 하단 메뉴 오른쪽에 이름 바꾸기 버튼을 만든다.
 * 입력하면 캐릭터 위쪽 이름과 오른쪽 메뉴 이름이 변경된다.
* **참석 인원 UI** - 화면 오른쪽에 현재 맵에 있는 사람의 목록을 보여준다.
  * X 버튼을 누르면 UI가 꺼지며 참석 인원 아래에 버튼을 부르면 목록이 다시 생긴다.
* **인게임 캐릭터 선택** - 하단 메뉴 오른쪽에 캐릭터 선택 버튼을 만든다.
  * 캐릭터 선택시 게임화면의 캐릭터가 바로 반영된다.
* **NPC 대화** - npc에게 가까이 다가가면 대화 걸기 버튼이 생긴다
  * npc로부터 멀어지면 버튼이 다시 사라진다.
  * 버튼을 누르면 대화가 시작된다.
---
### ✨ 시연 영상
https://github.com/Choiseeun0815/C-SimpleGame/assets/103297048/fcfaf3c4-80b2-4ad2-bd05-45d680097f5f

---
### ❗ 추후 개선 사항
* 이름을 변경할 때 참석자 버튼을 누르지 않으면 List가 생성되지 않아 오류가 생기는 현상
* 여러개의 npc를 관리하기 용이하도록 변경 
