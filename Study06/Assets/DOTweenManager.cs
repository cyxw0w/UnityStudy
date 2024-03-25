using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UI ������Ʈ �����ϴ� ���ӽ����̽�
using TMPro; // tmpro ����ϴ� ���ӽ����̽�
using DG.Tweening; //��Ʈ���� ����ϴ� ���ӽ����̽�

public class DOTweenManager : MonoBehaviour
{
    // �ؽ�Ʈ�� ���� ���̰�.
    // �Ŵ����� �ڵ� �ۼ� �� ��� ���� ����
    // �ƿ��� �������� ����� �� ������Ʈ�� ������Ʈ��
    public GameObject DOTween_Button;
    //public GameObject dtText;
    //public TMP_Text DOTween_Text; // TMP_Text : TextMashPro�� text ������Ʈ �̸�
    public Text testText;
    public RectTransform testImage;
    // ������Ʈ�� ����� ���°ź��� ������Ʈ�� ������ ���°� �� ����.

    // �ƿ��� �������� ����� �� �����յ�
    // �Ŵ����� �����ϴµ� �ʿ��� �Ӽ���

    public void DOTweenText(Text _text) // ��Ʈ���� ����� �ؽ�Ʈ ��Ʈ��
    {
        _text.text = "";
        _text.DOText(" ���� �������̴�.",1f);// DOText(�ؽ�Ʈ, �ؽ�Ʈ ������ �ð�) -> �ѱ��ھ� ���ٴٴ� ������ִ� �޼���
        _text.DOColor(Color.red, 1f); // �ٲ� ����, ���ϴ� �ð�(���ӽð�)
        // new Color(100/255f, 0/255f, 0/255f) �̷��� �ᵵ �ȴ�.
        // ��Ʈ���� �Լ��� ���������� ������� �ʰ� ���ÿ� ����ȴ�.        
        
    }

    public void DOTweenTransform(RectTransform _rect)
    {
        // _rect.DOScale(new Vector3(2, 2, 2), 1f); // Doscale(�ٲ� ũ��, ����ð�)
        //_rect.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.FastBeyond360); //�ٲ� ����, ����ð�, ȸ�����
        //_rect.DOAnchorPos(new Vector2(0, 90), 2f);
        //_rect.DOPunchScale(new Vector3(2, 2, 2), 1f, 3, 1f); // ũ��, ����ð�
        //_rect.DOShakeAnchorPos(1f, new Vector2(1,1),100, 90); // ����ð�, ������ ũ��, ���� ����, ��������

        SequenceTest();
    }

    public void SequenceTest()
    {
        // ��Ʈ���� ��������� ���·� ���� ������ ����
        // �� �������� ����� -> ���� �������� ������ �Լ����� ������� ä���ְ�(������ ���� �ϼ�)
        // -> ���۵� �������� �÷��� -> ������� �ʴ� �������� Kill�Ѵ�. (�⺻�� AutoKill�� �ڵ����� �׿��ش�.)

        // �� ������ �����
        Sequence testSeq = DOTween.Sequence(); // testSeq��� �� �������� ���������.

        // �������� ����ִ� �������� �Լ� �ֱ�
        // Append : �������� �� ���� �Լ��� �߰�
        // Insert : Ư�� ��ġ�� ����ִ´�. (�Լ� �߰��� �����ֱ�)
        // Join : ���� �Լ��� ���ÿ� ����ǰ� �Ѵ�.
        // Prepend : �������� �� �տ� �Լ��� �߰�
        // AppendInterval : �������� �� ���� ������ �ð��� �ִ´�.
        // PrependInterval : �������� �� �տ� ������ �ð��� �ִ´�.

        testSeq.Append(testImage.DOScale(new Vector3(2, 2, 2), 1f)); // �������� �� �տ� ����
        testSeq.Append(testImage.DORotate(new Vector3(0, 0, 90), 2f, RotateMode.FastBeyond360));
        testSeq.Join(testImage.DOShakeAnchorPos(1f, new Vector2(1, 1), 100, 90));
        testSeq.Insert(0.6f, testImage.DOPunchScale(new Vector3(2, 2, 2), 1f, 3, 1f));

        testSeq.AppendCallback(() =>
        {
            print("�׽�Ʈ");
            print("�� �׽�Ʈ");
            print("�Ƕ� �׽�Ʈ");
        });
        
        /*
        testSeq.Play();
        testSeq.Pause();
        testSeq.Restart();
        testSeq.PlayBackwards();
        testSeq.Rewind();
        testSeq.Kill();
        */
    }

    public void PlaySequence()
    {
        //testSeq.Play();
    }

    void Start()
    {
        //DOTweenText(testText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
