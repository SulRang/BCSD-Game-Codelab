# BCSD-Game-Codelab
?BCSD Game Codelab 입니다.
Unity를 이용하여 간단한 게임을 제작해보는 프로젝트입니다.
이를 통해서 게임 제작에 흥미를 가지게 되셨으면 좋겠습니다!
## 목차
1. install unity
0. add project
0. make player move
0. make player animation
0. make monster
0. make monster animation
0. make camera move
0. health system + collision
0. spawn system
0. attack and hit system

## 개발 환경 준비
### 1. Unity 설치
<https://unity3d.com/kr/get-unity/download>
위 사이트에 들어갑니다.

![Alt text](./image/unityinstall1.png)
Unity Hub 다운로드 다 클릭
(**Unity Hub** 는 여러 버전의 **Unity**를 보다 편하게 사용할 수 있도록 도와주는 **관리 툴**입니다.)

![Alt text](./image/unityinstall2.png)
동의 클릭

![Alt text](./image/unityinstall3.png)
설치 클릭

![Alt text](./image/unityinstall4.png)
체크를 한후 마침을 눌러 Unity Hub 실행

![Alt text](./image/Unity1.png)
왼쪽의 설치 탭을 눌러 이동한 뒤 오른쪽 상단의 추가를 눌러줍니다.

![Alt text](./image/Unity2.png)
Unity 2018.4.14f1 (LTS)를 체크한 후 다음을 눌러 진행합니다.

![Alt text](./image/Unity3.png)
Android Build Support를 체크한 후 완료를 눌러 설치를 진행합니다.

![Alt text](./image/Unity4.png)
설치가 완료 될 때까지 기다려줍니다...

### 2. 프로젝트 생성

프로젝트 생성 탭으로 이동해줍니다.


![Alt text](./image/Project0.png)
![Alt text](./image/Project1.png)
추가를 누른 뒤 Clone한 폴더를 선택해 줍니다.

자 그럼 이제 본격적으로 프로젝트를 진행해보겠습니다!

## 프로젝트 개발

### 0. 유니티 엔진
왼쪽에 hierarchy라고 써있는 창은 게임을 구성하는 요소들이 나타나는 창입니다. 저희가 화면에 무엇인가를 보이고 싶다고 할 때 이곳에 만들어서 보이게 할 수 있습니다.

하단의 Project는 단순한 Explorer입니다. 이곳에서 저희가 만든 Script나 Image등을 가져와서 Hierachy에 드래그해서 사용할 수 있습니다.

오른쪽의 Inspector창은 저희가 마우스로 클릭한 것의 상세한 정보를 알려주는 창입니다. 이곳에 나오는 정보를 수정하여서 저희가 원하는 기능을 구현할 수 있습니다.

가운데의 창에는 **Scene**과 **Game**이 있습니다.
여기서 **Scene**은 저희가 조작할 화면입니다. 캐릭터를 놓고 배경화면을 놓는 등의 보여지는 작업을 진행할 화면입니다.
**Game**은 게임을 실행했을 때의 모습을 보여주는 화면입니다. 가운데 상단을 보면 오른쪽 삼각형 버튼이 있는데 이 버튼을 누르면 Game화면에서 저희가 만든 게임을 테스트 해볼 수 있습니다

### 1. 플레이어 생성 및 움직이기
처음으로 플레이어를 생성해서 움직여 보도록하죠.

![Alt text](./image/Player1.png)
왼쪽 hierarchy창에 우클릭을 한 뒤 Create Empty 를 클릭하여 오브젝트를 생성해줍니다.
(**오브젝트**는 여러 기능들을 모아서 가질 수 있는 객체입니다.)

![Alt text](./image/Player2.png)
오른쪽 Inspector창의 상단에 있는 이름을 Player로 바꾸고 그 밑에 있는 Tag도 Player로 바꿔줍니다.
(**Tag**는 해당 **오브젝트가 무엇인지 확인**  또는 해당 **오브젝트를 찾기** 위한 용도로 쓰입니다.)

![Alt text](./image/Player3.png)
다음은 하단의 Project창으로 넘어가 보겠습니다.
Projcet창에 원하는 위치로 이동합니다.
(우클릭을 해서 폴더를 만드는 것을 추천합니다.)
우클릭을 한뒤 Script생성을 눌러 PlayerController.cs 라는 파일을 만듭니다.

그 후 다음에 따라 코드를 작성합니다.
(복붙합니다.)

![Alt text](./image/Player4.png)
다시 아까 만든 Player GameObject로 가서 방금 작업한 Script를 드래그 앤 드롭을 통해 넣어줍니다.

![Alt text](./image/Player4.png)
Inspector창에 보면 Script가 보일텐데 이곳에 원하는 Speed를 넣어줍니다.

![Alt text](./image/Player4.png)
그럼 플레이 버튼을 누른 후 방향키를 통해 움직여 봅시다.
(플레이 버튼은 상단 중앙에 있습니다. [오른쪽 삼각형])

### 2. 플레이어 애니메이션 넣기
![Alt text](./image/Animation1.png)
Player GameObject에 우클릭을 한 뒤 Create Empty를 눌러 줍니다.

![Alt text](./image/Animation2.png)
Inspector창으로 가서 new Component를 눌러준뒤 SpriteRenderer를 추가해 줍니다.
(이미지를 보여주는 오브젝트를 만듭니다.)

![Alt text](./image/Animation3.png)
Project창에 있는 PlayerAnimation을 이 Object에 드래그 앤 드롭을 통해 추가해 줍니다.

![Alt text](./image/Animation4.png)

![Alt text](./image/Animation5.png)
다음의 Code들을 PlayerController.cs에 추가해 줍니다.

### 3. 몬스터 생성 및 움직이기
이번에는 플레이어를 따라다니는 몬스터를 추가해 보겠습니다.

![Alt text](./image/Monster1.png)
먼저 Create Empty를 한 후 이름을 Monster로 바꿔줍니다.
(자세한 설명은 1에 있습니다.)

![Alt text](./image/Monster2.png)
MonsterController.cs 스크립트를 만든 후
다음의 Code들을 작성해 줍니다.
Monster GameObject에 Script를 추가한 후 Play버튼을 통해 확인해 봅니다.

![Alt text](./image/Monster3.png)
잘 움직인다면 다음은 Monster에게 Animation을 넣어주겠습니다.
Project 창에서 MonsterAnimation을 찾아서 Monster에게 드래그 앤 드롭을 통해 추가해 줍니다.
아까와 같이 New Component를 통해 SpriteRender를 추가해 줍니다.
(이번에는 따로 Create Empty를 안해주어도 됩니다.)

![Alt text](./image/Monster4.png)
자 그럼 다시 Play 버튼으로 확인해 봅니다.

### 5. 플레이어를 따라다니는 카메라 만들기
이번에는 플레이어가 움직이는 것에 따라서 같이 움직이는 카메라를 만들어 보겠습니다.

Project창에 우클릭으로 Script를 만들어 줍니다.
이름은 CameraController.cs로 하겠습니다.

![Alt text](./image/Camera.png)
다음의 Code들을 넣어 준 다음에

왼쪽의 Hierachy 창에 MainCamera에 Script를 넣어줍니다.

이번에도 Play버튼으로 확인해 봅니다.

### 6. HP바 만들기
이번에는 플레이어와 몬스터에게 HP를 만들어 주고 그것을 보여줄 HP바를 만들어 보겠습니다.
추가로 플레이어와 몬스터가 부딪히면 서로가 HP가 달도록 해보겠습니다.

우선 HP를 만들어 주기위해서 PlayerController와 MonsterController에 아래의 Code를 추가해 줍니다.

다음 HealthController.cs Script를 만들어서 다음의 Code들을 넣어줍니다.

다음 Prefabs폴더에 있는 HealthBar를 Hierachy에 옮겨주고 Script를 추가해 줍니다. 그리고 HealthBar를 Player나 Monster에게 드래그 앤 드롭으로 아래 들어가도록 넣어줍니다.
(HealthBar를 두개 가져와서 각각 넣어주면 됩니다.)

이번에도 역시 Play버튼으로 확인해 봅니다.
