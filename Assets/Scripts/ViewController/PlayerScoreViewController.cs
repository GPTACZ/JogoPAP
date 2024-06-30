using Messaging;
using Messaging.Interfaces;

namespace Game
{
    
    public class PlayerScoreViewController : BaseViewController<PlayerScoreView>
        ,ISubscriber<ScoreUpdatedMessage>
    {
        protected int m_score;

      
        protected virtual void Start()
        {
            GameManager.Instance.onGameStateChanged += OnGameStateChanged;
            MessageBus.Get().Subscribe(this);
        }

        public void OnMessage(ScoreUpdatedMessage message)
        {
            m_score += message.score;
            m_view.DidLoadData(m_score);
        }

       
        /// <param name="gameState">game state</param>
        protected virtual void OnGameStateChanged(GameState gameState)
        {
            if (gameState == GameState.Main)
            {
                m_score = 0;
                m_view.Configure();
            }
        }
    }
}
