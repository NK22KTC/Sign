
public enum PlayerMoveState
{
    /// <summary>ゲーム開始の瞬間だけ使う</summary>
    Disabled,
    /// <summary>動いていない</summary>
    Idle,
    /// <summary>歩く</summary>
    Walk,
    /// <summary>走る</summary>
    Run,
    /// <summary>跳ぶ</summary>
    Jump,
    /// <summary>星を移動中</summary>
    Warping,
    /// <summary>死</summary>
    Death,
    /// <summary>リスポーン中</summary>
    Respawning
}

public enum PlayerAttackState
{
    /// <summary>ゲーム開始の瞬間だけ使う</summary>
    Disabled,
    /// <summary>攻撃していない</summary>
    Idle,
    /// <summary>攻撃している</summary>
    Attack
}

public enum PlayerPickState
{
    /// <summary>ゲーム開始の瞬間だけ使う</summary>
    Disabled,
    /// <summary>アイテムを拾う</summary>
    Picking,
    /// <summary>アイテムを拾っていない</summary>
    UnPicking,
}

public enum PlayerGroundState
{
    /// <summary>ゲーム開始の瞬間だけ使う</summary>
    Disabled,
    /// <summary>接地している</summary>
    Grounded,
    /// <summary>接地していない</summary>
    UnGrounded,
}

public enum PlayerGameState
{
    /// <summary>ゲーム開始の瞬間だけ使う</summary>
    Disabled,
    /// <summary>キャラ操作中</summary>
    Operating,
    /// <summary>メニューを開いている</summary>
    OpeningMenu
}

public enum PlayerProgressState
{
    /// <summary>ゲーム開始の瞬間だけ使う</summary>
    Disabled,
    /// <summary>ゲームプレイ中</summary>
    PlayingGame,
    /// <summary>ゲームクリア</summary>
    GameClear,
    /// <summary>ゲームオーバー</summary>
    GameOver
}

public class PlayerStateManager
{
    private PlayerMoveState moveState = PlayerMoveState.Disabled;
    private PlayerAttackState attackState = PlayerAttackState.Disabled;
    private PlayerPickState pickState = PlayerPickState.Disabled;
    private PlayerGroundState groundState = PlayerGroundState.Disabled;
    private PlayerGameState gameState = PlayerGameState.Disabled;
    private PlayerProgressState progressState = PlayerProgressState.Disabled;

    public PlayerMoveState MoveState => moveState;
    public void ChangeMoveState(PlayerMoveState newstate) => moveState = newstate;
    public PlayerAttackState AttackState => attackState;
    public void ChangeAttackState(PlayerAttackState newState) => attackState = newState; 
    public PlayerPickState PickState => pickState;
    public void ChangePickState(PlayerPickState newState) => pickState = newState;
    public PlayerGroundState GroundState => groundState;
    public void ChangeGroundState(PlayerGroundState newstate) => groundState = newstate;
    public PlayerGameState GameState => gameState;
    public void ChangeGameState(PlayerGameState newstate) => gameState = newstate;
    public PlayerProgressState ProgressState => progressState;
    public void ChangeProgressState(PlayerProgressState newState) => progressState = newState;
}