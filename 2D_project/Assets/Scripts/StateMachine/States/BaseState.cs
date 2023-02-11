namespace StateMachine
{
    public abstract class BaseState
    {
        public abstract void InitState(); //start
        public abstract void UpdateState(); //update
        public abstract void DestroyState(); //on destroy
        public abstract void FixedState(); //fixed update
    }
}
