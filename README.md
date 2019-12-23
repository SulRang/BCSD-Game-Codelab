
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


![UnityEngine](./image/UnityEngine.png)
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
![Alt text](./image/Player4.png)
�� �� Resources������ topdown_shooter/charater�� �ִ� 2�� �巡�� �� ������� Player���� �־��ݴϴ�.

![Alt text](./image/Player5.png)
������ �ϴ��� Projectâ���� �Ѿ ���ڽ��ϴ�.
Projcetâ�� Scripts ������ �̵��մϴ�.
(���� ������ ����ŵ� �˴ϴ�.)

![Alt text](./image/Player6.png)
��Ŭ���� �ѵ� Script������ ���� PlayerController.cs ��� ������ ����ϴ�.


������ ��� �Ʒ��� Code���� �־��ݴϴ�.
![Alt text](./image/Player7.png)
``` 
public class PlayerController : MonoBehaviour
{
    public float m_MoveSpeed;
    private Rigidbody2D m_Rigidbody = null;
    private float hori, vert;
    // Start is called before the first frame update
    void Start()
    {
        this.m_Rigidbody = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        this.m_Rigidbody.velocity = new Vector2(hori, vert) * m_MoveSpeed;
    }
}
```
�ٽ� �Ʊ� ���� Player GameObject�� ���� ��� �۾��� Script�� �巡�� �� ����� ���� �־��ݴϴ�.

![Alt text](./image/Player8.png)
Inspectorâ�� ���� Script�� �����ٵ� �̰��� ������ Move Speed�� ���ϴ� Speed�� �־��ݴϴ�.

![Alt text](./image/Player9.png)
�÷��̾ �ʹ� �����ϱ� Scale�� �ٲ� ����. (Inspectorâ�� Transform�� �ֽ��ϴ�.)

![Alt text](./image/Player10.png)
�������δ� Add Component�� ������ RigidBody2D�� �־��ݴϴ�.

![Alt text](./image/Player11.png)
�׸��� Body Type�� Kinematic���� �ٲ��ݴϴ�.

�׷� �÷��� ��ư�� ���� �� ����Ű�� ���� ������ ���ô�.
(�÷��� ��ư�� ��� �߾ӿ� �ֽ��ϴ�. [������ �ﰢ��])

### 2. �÷��̾� �ִϸ��̼� �ֱ�
![Alt text](./image/Animation1.png)
Projectâ�� �Ʊ� character�� ���� animations ������ �ִ� PlayerAnimation�� �Ʊ� ���� �̹����� �巡�� �� ����� ���� �߰��� �ݴϴ�.

![Alt text](./image/Animation2.png)
![Alt text](./image/Animation3.png)
![Alt text](./image/Animation4.png)
![Alt text](./image/Animation5.png)
![Alt text](./image/Animation6.png)
PlayerController.cs�� ������ ���� ������ �ݴϴ�.
```
public class PlayerController : MonoBehaviour
{
    public float m_MoveSpeed;
    private Rigidbody2D m_Rigidbody = null;
    private float hori, vert;

    private Transform m_ChildTransform;
    private Animator m_Animator = null;
    private SpriteRenderer m_SpriteRenderer = null;
    private bool m_isright = true;
    // Start is called before the first frame update
    void Start()
    {
        this.m_Rigidbody = this.GetComponent<Rigidbody2D>();

        this.m_ChildTransform = this.transform.GetChild(0);
        this.m_Animator = m_ChildTransform.GetComponent<Animator>();
        this.m_SpriteRenderer = m_ChildTransform.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");

        this.UpdateAnimations();
    }

    void FixedUpdate()
    {
        this.m_Rigidbody.velocity = new Vector2(hori, vert) * m_MoveSpeed;
    }

    private void UpdateAnimations()
    {
        Vector3 dir = m_ChildTransform.localScale;
        if (vert > 0.0f)
            this.SetBool("up", true);

        else if (vert < -0.0f)
            this.SetBool("down", true);

        else
        {
            this.SetBool("up", false);
            this.SetBool("down", false);
        }

        if (hori > 0.0f)
        {
            this.SetBool("side", true);
            if (!this.m_isright)
            {
                this.m_ChildTransform.localScale = new Vector3(-1 * dir.x, dir.y);
                this.m_isright = true;
            }
        }
        else if (hori < -0.0f)
        {
            this.SetBool("side", true);
            if (this.m_isright)
            {
                this.m_ChildTransform.localScale = new Vector3(-1 * dir.x, dir.y);
                this.m_isright = false;
            }
        }
        else
            this.SetBool("side", false);
    }

    private void SetBool(string Name, bool Value)
    {
        this.m_Animator.SetBool(Name, Value);
    }
}

```

### 3. ���� ���� �� �����̱�
�̹����� �÷��̾ ����ٴϴ� ���͸� �߰��� ���ڽ��ϴ�.

![Alt text](./image/Monster1.png)
���� Create Empty�� �� �� �̸��� tag�� Monster�� �ٲ��ݴϴ�.
RigidBody2D�� �߰��ϰ� Gravity Scale�� 0���� �������ݴϴ�.
(Body Type�� Dynamic)
(�ڼ��� ������ 1�� �ֽ��ϴ�.)


![Alt text](./image/Monster2.png)
add Component�� Sprite Renderer��
�߰��Ѵ��� Monster������ �ִ� Slime�̹�����  Sprite�� �巡�� �� ������� �߰��� �ݴϴ�.
(�� ���̵��� Scale�� ������ �ݴϴ�.)

MonsterController.cs ��ũ��Ʈ�� ���� ��
������ Code���� �ۼ��� �ݴϴ�.
Monster GameObject�� Script�� �߰��� �� Play��ư�� ���� Ȯ���� ���ϴ�.
```

public class MonsterController : MonoBehaviour
{
    GameObject target;
    Rigidbody2D m_RigidBody2D;
    public float m_MoveSpeed = 3.0f;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        this.target = GameObject.FindGameObjectWithTag("Player");
        this.m_RigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (target.transform != null)
        {
            dir = target.transform.position - this.transform.position;
            this.m_RigidBody2D.MovePosition(this.transform.position + Vector3.Normalize(dir) * this.m_MoveSpeed * Time.deltaTime);
            
        }
    }
}

```

![Alt text](./image/Monster3.png)
�� �����δٸ� ������ Monster���� Animation�� �־��ְڽ��ϴ�.
Project â���� MonsterAnimation(slime1_front)�� ã�Ƽ� Monster���� �巡�� �� ����� ���� �߰��� �ݴϴ�.

������ Code���� �߰��� �ְ�
(Update�� �����Դϴ�.)
```
	void Update()
    {
        if (target.transform != null)
        {
            dir = target.transform.position - this.transform.position;
            this.m_RigidBody2D.MovePosition(this.transform.position + Vector3.Normalize(dir) * this.m_MoveSpeed * Time.deltaTime);

            if (dir.y > 0.0f)
            {
                this.SetBool("back", true);
            }
            else
            {
                this.SetBool("back", false);
            }
        }
    }
    
    private void SetBool(string Name, bool Value)
    {
        this.GetComponent<Animator>().SetBool(Name, Value);
    }

```
�ٽ� Play ��ư���� Ȯ���� ���ϴ�.

### 5. �÷��̾ ����ٴϴ� ī�޶� �����
�̹����� �÷��̾ �����̴� �Ϳ� ���� ���� �����̴� ī�޶� ����� ���ڽ��ϴ�.

Projectâ�� ��Ŭ������ Script�� ����� �ݴϴ�.
�̸��� CameraController.cs�� �ϰڽ��ϴ�.

������ Code���� �־� �� ������
```
public class CameraController : MonoBehaviour
{
    public float follow_speed = 4.0f;
    public float z = -20.0f;
    public GameObject Target;

    Transform this_transform;
    Transform Target_transform;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        this_transform = GetComponent<Transform>();
        Target_transform = Target.GetComponent<Transform>();
    }
    void Update()
    {
        this_transform.position = Vector2.Lerp(this_transform.position, Target_transform.position, follow_speed * Time.deltaTime);
        this_transform.Translate(0, 0, z);
    }
}

```

![Alt text](./image/Camera.png)
������ Hierachy â�� MainCamera�� Script�� �־��ݴϴ�.
�߰������� Size�� �ٿ�(2~3����) ȭ���� Ȯ���� �ݴϴ�.

�̹����� Play��ư���� Ȯ���� ���ϴ�.

### 6. HP�� �����
�̹����� �÷��̾�� ���Ϳ��� HP�� ����� �ְ� �װ��� ������ HP�ٸ� ����� ���ڽ��ϴ�.
�߰��� �÷��̾�� ���Ͱ� �ε����� ���ΰ� HP�� �޵��� �غ��ڽ��ϴ�.

�켱 HP�� ����� �ֱ����ؼ� PlayerController�� MonsterController�� class ���� �Ʒ��� Code�� �߰��� �ݴϴ�.
```
    private float m_MaxHealth = 5.0f;//����� ������� �����ּ���(�÷��̾�� ������ ������?)
```

���� HealthBarController.cs Script�� ��� ������ Code���� �־��ݴϴ�.
```

public class HealthBarController : MonoBehaviour
{
    private Transform target = null;
    private float m_health;
    private float m_max_health;
    private bool is_init = false;
    private Transform bar = null;
    // Start is called before the first frame update
    void Start()
    {
        bar = this.transform.GetChild(0);
        m_health = m_max_health;
        target = this.transform.parent;
    }

    // Update is called once per frame
    void Update()
    {
        bar.localScale = new Vector3(m_health / m_max_health, 1);
        this.transform.position = new Vector3(target.position.x, target.position.y + 0.5f);

    }
    public void Damaged(float damage)
    {
        m_health -= damage;
    }
    public float getCurrentHealth()
    {
        return m_health;
    }
    public void setMaxHealth(float targetMaxHealth)
    {
        m_max_health = targetMaxHealth;
        if (!is_init)
            m_health = m_max_health;
    }
}

```
![Alt text](./image/HealthBar1.png)
���� Prefabs������ �ִ� HealthBar�� Hierachy�� Player�� Monster���� �巡�� �� ������� �Ʒ� ������ �־��ݴϴ�.
(HealthBar�� �ΰ� �����ͼ� ���� �־��ָ� �˴ϴ�. + �ٷ� �־��ּ���.)

![Alt text](./image/HealthBar2.png)
![Alt text](./image/HealthBar3.png)

�������� MonsterController�� PlayerController Class ���� �ؿ�
```
    private HealthBarController m_HealthController;
```
MonsterController�� Start()�� 
![Alt text](./image/HealthBar4.png)
```
        this.m_HealthController = this.transform.GetChild(0).GetComponent<HealthBarController>();
        this.m_HealthController.setMaxHealth(this.m_MaxHealth);
```
PlayerController�� Start()�� 
![Alt text](./image/HealthBar5.png)
```
        this.m_HealthController = this.transform.GetChild(1).GetComponent<HealthBarController>();
        this.m_HealthController.setMaxHealth(this.m_MaxHealth);
```
�� �־��ݴϴ�. (Start�Լ��� �ִ� �ڵ��� ���̴� GetChile(����) ���Դϴ�.


![Alt text](./image/HealthBar6.png)
�̹����� ���� Play��ư���� Ȯ���� ���ϴ�.

### 7. ���� ���� ���� ��Ű��
���͸� ���� ���� ��ġ���� �������� ���ڽ��ϴ�.

![Alt text](./image/Spawn1.png)
�켱 GameObject�� �ϳ� ����ϴ�.(���� SpawnManager��� ��������ϴ�.)

SpawnController.cs Script�� ����� ���� Code �� �־��ݴϴ�.

```
public class SpawnController : MonoBehaviour
{
    // Start is called before the first frame update
    private int m_MonsterCount = 0;
    private float m_SpawnVertical, m_SpawnHorizontal;
    private float m_Distance = 5.0f;
    public GameObject m_MonsterObject = null;
    public int m_MaxMonsterCount = 1;

    // Update is called once per frame
    void Update()
    {
        this.m_SpawnHorizontal = Random.Range(-m_Distance, m_Distance);
        this.m_SpawnVertical = Mathf.Sqrt(Mathf.Pow(this.m_Distance, 2.0f) - Mathf.Pow(this.m_SpawnHorizontal, 2.0f));
        this.m_MonsterCount = this.transform.childCount;
        if (m_MonsterCount < m_MaxMonsterCount)
        {
            GameObject.Instantiate(m_MonsterObject, new Vector3(this.m_SpawnHorizontal, this.m_SpawnVertical, -1.0f), new Quaternion(0, 0, 0, 0)).transform.parent = this.transform;
        }
    }
}
```

![Alt text](./image/Spawn2.png)
SpawnManger GameObject�� �巡�� �� ������� �־� �ְ�
Monster Object�κп� Monster GameObject�� �־��ݴϴ�.
�׸��� ���ϴ� ��ŭ MonsterMaxCount�� �־��ݴϴ�.

### 8. Ÿ��, �ǰ� �����ϱ�
���ݱ��� �� ����� �ּż� �����մϴ�!
���������� Ÿ�ݰ� �ǰ��� �����غ����� �ϰڽ��ϴ�.
�켱 Player�� Monster���� add Component�� ���� BoxCollider2D�� �־��ݴϴ�.
�� ���� Edit Collider�� ���� ĳ���� ũ�⿡ �°� Colliderũ�⸦ ������ �ݴϴ�.
�������� RigidBody2D�� Constraints�� ������ Freeze Rotation Z�� üũ���ݴϴ�.

���� MonsterController�� �Ʒ��� Code���� �߰����ݴϴ�.
```
    private void OnCollisionEnter2D(Collision2D Collider)
    {
        if (Collider.transform.tag == "Player" || Collider.transform.tag == "Bullet")
        {
            this.m_HealthController.Damaged(1.0f);

            if (this.m_HealthController.getCurrentHealth() <= 0)
            {
                this.Dead();
            }
            this.KnockBack(Collider);
        }
    }
    void Dead()
    {
        Destroy(this.gameObject);
    }
    void KnockBack(Collision2D target)
    {
        this.transform.position -= (target.transform.position - this.transform.position) * 30 * Time.deltaTime;
    }
```
�׸��� PlayerController.cs ��

```
public class PlayerController : MonoBehaviour
{
    public float m_MoveSpeed;

    private float hori, vert, m_MaxHealth = 100.0f;
    private Rigidbody2D m_Rigidbody = null;
    private Animator m_Animator = null;
    private SpriteRenderer m_SpriteRenderer = null;
    private bool m_isright = true;
    private Vector2 m_ForceUpdate = Vector2.zero;
    private HealthBarController m_HealthController;
    private Transform m_ChildTransform;
    private GunController m_GunController;
    void Start()
    {
        this.m_Rigidbody = this.GetComponent<Rigidbody2D>();
        this.m_HealthController = this.transform.GetChild(1).GetComponent<HealthBarController>();
        this.m_ChildTransform = this.transform.GetChild(0);
        this.m_Animator = m_ChildTransform.GetComponent<Animator>();
        this.m_SpriteRenderer = m_ChildTransform.GetComponent<SpriteRenderer>();
        this.m_HealthController.setMaxHealth(m_MaxHealth);
        this.m_GunController = this.transform.GetChild(2).GetComponent<GunController>();
    }

    void Update()
    {
        hori = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");
        this.UpdateAnimations();
        if (Input.GetKeyDown("space"))
            this.m_GunController.shoot();
    }

    void FixedUpdate()
    {
        this.m_Rigidbody.velocity = new Vector2(hori, vert) * m_MoveSpeed;
    }
    private void UpdateAnimations()
    {
        Vector3 dir = m_ChildTransform.localScale;
        if (vert > 0.0f)
            this.SetBool("up", true);

        else if (vert < -0.0f)
            this.SetBool("down", true);

        else
        {
            this.SetBool("up", false);
            this.SetBool("down", false);
        }

        if (hori > 0.0f)
        {
            this.SetBool("side", true);
            if (!this.m_isright)
            {
                this.m_ChildTransform.localScale = new Vector3(-1 * dir.x, dir.y);
                this.m_isright = true;
            }
        }
        else if (hori < -0.0f)
        {
            this.SetBool("side", true);
            if (this.m_isright)
            {
                this.m_ChildTransform.localScale = new Vector3(-1 * dir.x, dir.y);
                this.m_isright = false;
            }
        }
        else
            this.SetBool("side", false);
    }

    private void SetBool(string Name, bool Value)
    {
        this.m_Animator.SetBool(Name, Value);
    }

    private void OnCollisionEnter2D(Collision2D Collider)
    {
        if (Collider.transform.tag == "Monster")
        {
            this.m_HealthController.Damaged(1.0f);
            if (this.m_HealthController.getCurrentHealth() <= 0)
                this.Dead();
        }
    }

    private void Dead()
    {
        Destroy(this.gameObject);
    }

    public int getDir()
    {
        if (this.m_Animator.GetBool("up"))
        {
            if (this.m_Animator.GetBool("side"))
                return 1;
            else
                return 4;
        }
        else if (this.m_Animator.GetBool("down"))
        {
            if (this.m_Animator.GetBool("side"))
                return 0;
            else
                return 2;
        }
        else
            return 3;
    }
    public Vector3 getDirection()
    {
        return new Vector3(hori, vert, 0);
    }
}
```
�̷��� ������ �ݴϴ�. (�״�� ���� �ٿ��ֱ⸦ �ϼŵ� �˴ϴ�.

�׸���
GameObject�� ���� Gun�̶�� �̸����� ������� ��
GunController.cs�� ����� ������ Script�� �־��ݴϴ�.
```

public class GunController : MonoBehaviour
{
    public Sprite[] Gun;
    private PlayerController m_PlayerController;
    private SpriteRenderer m_SpriteRenderer;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        this.m_PlayerController = this.transform.parent.GetComponent<PlayerController>();
        this.m_SpriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        int dir = this.m_PlayerController.getDir();
        this.m_SpriteRenderer.sprite = this.Gun[dir];

    }

    public void shoot()
    {
        Instantiate(Bullet, this.transform.parent.position, new Quaternion(0, 0, 0, 0));
    }
}
```
![Alt text](./image/Collider2.png)
Gun Object�� Script�� Sprite Renderer�� �ְ� ������ ���� �������ݴϴ�.
bullet�� prefabs������ �ְ�,
�� �̹������� topdown_shooter/guns/mg�� �ֽ��ϴ�.
�������� BulletController.cs�� ��� ������ Script�� �־��ݴϴ�.
```

public class BulletController : MonoBehaviour
{
    private float m_livetime;
    private Vector2 dir;
    public float m_BulletSpeed = 1.0f;
    private PlayerController m_PlayerController;
    // Start is called before the first frame update
    void Start()
    {
        m_PlayerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        m_livetime = 0.0f;
        dir = m_PlayerController.getDirection();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * m_BulletSpeed * Time.deltaTime);
        m_livetime += Time.deltaTime;
        if (m_livetime > 5.0f ||dir == new Vector2(0, 0))
            Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D Collider)
    {
        if (Collider.transform.tag == "Monster")
            Destroy(this.gameObject);
    }
}
```

![Alt text](./image/Collider3.png)
Gun Object�� Player�� �־��ְ� ���� �Ʒ� ��ġ�ϵ���
Inspectorâ�� Position�� ĳ���Ͱ� ��� �ִ� ��ó�� �� �����ֽø� �˴ϴ�!

![Alt text](./image/Collider4.png)
![Alt text](./image/Collider5.png)
���������� Monster������Ʈ�� Prefabs������ �巡�� ���� �� hieracht���� ���ְ� SpawnManager�� Script�� Prefabs������ Monster�� �־��ֽø� �˴ϴ�!


![Alt text](./image/Collider6.png)
�׷��� �ϼ��Դϴ�!

����Ű�� Space�� ������ ��ܺ�����!