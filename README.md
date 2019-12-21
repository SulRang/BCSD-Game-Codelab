# BCSD-Game-Codelab
?BCSD Game Codelab �Դϴ�.
Unity�� �̿��Ͽ� ������ ������ �����غ��� ������Ʈ�Դϴ�.
�̸� ���ؼ� ���� ���ۿ� ��̸� ������ �Ǽ����� ���ڽ��ϴ�!
## ����
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

## ���� ȯ�� �غ�
### 1. Unity ��ġ
<https://unity3d.com/kr/get-unity/download>
�� ����Ʈ�� ���ϴ�.

![Alt text](./image/unityinstall1.png)
Unity Hub �ٿ�ε� �� Ŭ��
(**Unity Hub** �� ���� ������ **Unity**�� ���� ���ϰ� ����� �� �ֵ��� �����ִ� **���� ��**�Դϴ�.)

![Alt text](./image/unityinstall2.png)
���� Ŭ��

![Alt text](./image/unityinstall3.png)
��ġ Ŭ��

![Alt text](./image/unityinstall4.png)
üũ�� ���� ��ħ�� ���� Unity Hub ����

![Alt text](./image/Unity1.png)
������ ��ġ ���� ���� �̵��� �� ������ ����� �߰��� �����ݴϴ�.

![Alt text](./image/Unity2.png)
Unity 2018.4.14f1 (LTS)�� üũ�� �� ������ ���� �����մϴ�.

![Alt text](./image/Unity3.png)
Android Build Support�� üũ�� �� �ϷḦ ���� ��ġ�� �����մϴ�.

![Alt text](./image/Unity4.png)
��ġ�� �Ϸ� �� ������ ��ٷ��ݴϴ�...

### 2. ������Ʈ ����

������Ʈ ���� ������ �̵����ݴϴ�.


![Alt text](./image/Project0.png)
![Alt text](./image/Project1.png)
�߰��� ���� �� Clone�� ������ ������ �ݴϴ�.

�� �׷� ���� ���������� ������Ʈ�� �����غ��ڽ��ϴ�!

## ������Ʈ ����

### 0. ����Ƽ ����
���ʿ� hierarchy��� ���ִ� â�� ������ �����ϴ� ��ҵ��� ��Ÿ���� â�Դϴ�. ���� ȭ�鿡 �����ΰ��� ���̰� �ʹٰ� �� �� �̰��� ���� ���̰� �� �� �ֽ��ϴ�.

�ϴ��� Project�� �ܼ��� Explorer�Դϴ�. �̰����� ���� ���� Script�� Image���� �����ͼ� Hierachy�� �巡���ؼ� ����� �� �ֽ��ϴ�.

�������� Inspectorâ�� ���� ���콺�� Ŭ���� ���� ���� ������ �˷��ִ� â�Դϴ�. �̰��� ������ ������ �����Ͽ��� ���� ���ϴ� ����� ������ �� �ֽ��ϴ�.

����� â���� **Scene**�� **Game**�� �ֽ��ϴ�.
���⼭ **Scene**�� ���� ������ ȭ���Դϴ�. ĳ���͸� ���� ���ȭ���� ���� ���� �������� �۾��� ������ ȭ���Դϴ�.
**Game**�� ������ �������� ���� ����� �����ִ� ȭ���Դϴ�. ��� ����� ���� ������ �ﰢ�� ��ư�� �ִµ� �� ��ư�� ������ Gameȭ�鿡�� ���� ���� ������ �׽�Ʈ �غ� �� �ֽ��ϴ�

### 1. �÷��̾� ���� �� �����̱�
ó������ �÷��̾ �����ؼ� ������ ����������.

![Alt text](./image/Player1.png)
���� hierarchyâ�� ��Ŭ���� �� �� Create Empty �� Ŭ���Ͽ� ������Ʈ�� �������ݴϴ�.
(**������Ʈ**�� ���� ��ɵ��� ��Ƽ� ���� �� �ִ� ��ü�Դϴ�.)

![Alt text](./image/Player2.png)
������ Inspectorâ�� ��ܿ� �ִ� �̸��� Player�� �ٲٰ� �� �ؿ� �ִ� Tag�� Player�� �ٲ��ݴϴ�.
(**Tag**�� �ش� **������Ʈ�� �������� Ȯ��**  �Ǵ� �ش� **������Ʈ�� ã��** ���� �뵵�� ���Դϴ�.)

![Alt text](./image/Player3.png)
������ �ϴ��� Projectâ���� �Ѿ ���ڽ��ϴ�.
Projcetâ�� ���ϴ� ��ġ�� �̵��մϴ�.
(��Ŭ���� �ؼ� ������ ����� ���� ��õ�մϴ�.)
��Ŭ���� �ѵ� Script������ ���� PlayerController.cs ��� ������ ����ϴ�.

�� �� ������ ���� �ڵ带 �ۼ��մϴ�.
(�����մϴ�.)

![Alt text](./image/Player4.png)
�ٽ� �Ʊ� ���� Player GameObject�� ���� ��� �۾��� Script�� �巡�� �� ����� ���� �־��ݴϴ�.

![Alt text](./image/Player4.png)
Inspectorâ�� ���� Script�� �����ٵ� �̰��� ���ϴ� Speed�� �־��ݴϴ�.

![Alt text](./image/Player4.png)
�׷� �÷��� ��ư�� ���� �� ����Ű�� ���� ������ ���ô�.
(�÷��� ��ư�� ��� �߾ӿ� �ֽ��ϴ�. [������ �ﰢ��])

### 2. �÷��̾� �ִϸ��̼� �ֱ�
![Alt text](./image/Animation1.png)
Player GameObject�� ��Ŭ���� �� �� Create Empty�� ���� �ݴϴ�.

![Alt text](./image/Animation2.png)
Inspectorâ���� ���� new Component�� �����ص� SpriteRenderer�� �߰��� �ݴϴ�.
(�̹����� �����ִ� ������Ʈ�� ����ϴ�.)

![Alt text](./image/Animation3.png)
Projectâ�� �ִ� PlayerAnimation�� �� Object�� �巡�� �� ����� ���� �߰��� �ݴϴ�.

![Alt text](./image/Animation4.png)

![Alt text](./image/Animation5.png)
������ Code���� PlayerController.cs�� �߰��� �ݴϴ�.

### 3. ���� ���� �� �����̱�
�̹����� �÷��̾ ����ٴϴ� ���͸� �߰��� ���ڽ��ϴ�.

![Alt text](./image/Monster1.png)
���� Create Empty�� �� �� �̸��� Monster�� �ٲ��ݴϴ�.
(�ڼ��� ������ 1�� �ֽ��ϴ�.)

![Alt text](./image/Monster2.png)
MonsterController.cs ��ũ��Ʈ�� ���� ��
������ Code���� �ۼ��� �ݴϴ�.
Monster GameObject�� Script�� �߰��� �� Play��ư�� ���� Ȯ���� ���ϴ�.

![Alt text](./image/Monster3.png)
�� �����δٸ� ������ Monster���� Animation�� �־��ְڽ��ϴ�.
Project â���� MonsterAnimation�� ã�Ƽ� Monster���� �巡�� �� ����� ���� �߰��� �ݴϴ�.
�Ʊ�� ���� New Component�� ���� SpriteRender�� �߰��� �ݴϴ�.
(�̹����� ���� Create Empty�� �����־ �˴ϴ�.)

![Alt text](./image/Monster4.png)
�� �׷� �ٽ� Play ��ư���� Ȯ���� ���ϴ�.

### 5. �÷��̾ ����ٴϴ� ī�޶� �����
�̹����� �÷��̾ �����̴� �Ϳ� ���� ���� �����̴� ī�޶� ����� ���ڽ��ϴ�.

Projectâ�� ��Ŭ������ Script�� ����� �ݴϴ�.
�̸��� CameraController.cs�� �ϰڽ��ϴ�.

![Alt text](./image/Camera.png)
������ Code���� �־� �� ������

������ Hierachy â�� MainCamera�� Script�� �־��ݴϴ�.

�̹����� Play��ư���� Ȯ���� ���ϴ�.

### 6. HP�� �����
�̹����� �÷��̾�� ���Ϳ��� HP�� ����� �ְ� �װ��� ������ HP�ٸ� ����� ���ڽ��ϴ�.
�߰��� �÷��̾�� ���Ͱ� �ε����� ���ΰ� HP�� �޵��� �غ��ڽ��ϴ�.

�켱 HP�� ����� �ֱ����ؼ� PlayerController�� MonsterController�� �Ʒ��� Code�� �߰��� �ݴϴ�.

���� HealthController.cs Script�� ���� ������ Code���� �־��ݴϴ�.

���� Prefabs������ �ִ� HealthBar�� Hierachy�� �Ű��ְ� Script�� �߰��� �ݴϴ�. �׸��� HealthBar�� Player�� Monster���� �巡�� �� ������� �Ʒ� ������ �־��ݴϴ�.
(HealthBar�� �ΰ� �����ͼ� ���� �־��ָ� �˴ϴ�.)

�̹����� ���� Play��ư���� Ȯ���� ���ϴ�.
