using Unity.VisualScripting;
using UnityEngine;

public class CloseChangeCharacterButton: ChangeCharacterButton
{
    int idx = (int)Character.Lizard; //캐릭터 초기 값은 Lizard로 설정
    Vector3 currentPos;
    
    public void CloseChangeCharacterUI()
    {
        if (SetSelectCharacter.Instance.player != null)
        {
            if (DataManager.instance != null)
                idx = (int)DataManager.instance.currentCharacter;

            currentPos = SetSelectCharacter.Instance.player.transform.position;

            Destroy(SetSelectCharacter.Instance.player);
            SetSelectCharacter.Instance.player = Instantiate(SetSelectCharacter.Instance.characters[idx]);
            SetSelectCharacter.Instance.player.transform.position = currentPos;
        }

        changeCharacterMenu.SetActive(false);
    }
}
