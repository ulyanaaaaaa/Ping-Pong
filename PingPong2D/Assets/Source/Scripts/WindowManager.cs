using UnityEngine;

[RequireComponent(typeof(BlockManager))]
public class WindowManager : MonoBehaviour
{
   [SerializeField] private FailTrigger _failTrigger;
   private BlockManager _blockManager;

   [SerializeField] private GameObject _winPanel;
   [SerializeField] private GameObject _failPanel;
   
   private void Awake()
   {
      _blockManager = GetComponent<BlockManager>();
   }

   private void OnEnable()
   {
      _failTrigger.OnFail += Fail;
      _blockManager.OnWin += Win;
   }

   private void OnDisable()
   {
      _failTrigger.OnFail -= Fail;
      _blockManager.OnWin -= Win;
   }

   private void Win()
   {
      _winPanel.SetActive(true);
   }

   private void Fail()
   {
      _failPanel.SetActive(true);
   }
}
