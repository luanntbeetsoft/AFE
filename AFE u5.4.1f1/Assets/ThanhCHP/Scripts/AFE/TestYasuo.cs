using System.Linq;
using Photon.Pun;
using UnityEngine;

namespace Com.Beetsoft.AFE
{
    public class TestYasuo : MonoBehaviourPun
    {
        [SerializeField] private ChampionModel championModel;
        [SerializeField] private JoystickInputFilter joystickInputFilter;
        [SerializeField] private AnimatorHandler animatorHandler;
        [SerializeField] private HealthBarPlayer barPlayer;
        private IChampionConfig championModelCache = null;

        public IChampionConfig ChampionModel =>
            championModelCache ?? (championModelCache = Instantiate(championModel));

        private JoystickInputFilter JoystickInputFilter => joystickInputFilter;

        private AnimatorHandler AnimatorHandler => animatorHandler;



        private void Awake()
        {
            var monoPuns = GetComponents<MonoBehaviourPun>();

            // edit
            var initChampionConfigList = monoPuns.OfType<IInitialize<IChampionConfig>>().ToList();
            initChampionConfigList.ForEach(x => x.Initialize(ChampionModel));

            var initJoystick = monoPuns.OfType<IInitialize<IJoystickInputFilterObserver>>().ToList();
            initJoystick.ForEach(x => x.Initialize(JoystickInputFilter));

            var intiAnimationChecker = monoPuns.OfType<IInitialize<IAnimationStateChecker>>().ToList();
            intiAnimationChecker.ForEach(x => x.Initialize(AnimatorHandler));

        }

        private void Start()
        {
            CreateHealthBar(ChampionModel, photonView.IsMine);
            if (!photonView.IsMine) return;
        }

        void CreateHealthBar(IChampionConfig championConfig, bool isMine)
        {
            var _barPlayer = Instantiate(barPlayer.transform, CanvasJoystickManager.Singleton.barPlayer, false);
            _barPlayer.GetComponent<HealthBarPlayer>().SetInit(championConfig, isMine);
        }
    }
}