using Core.Commands;

namespace DamageSystem.Commands
{
    public struct DamageCommand : ICommand
    {
        public float Value { get; }

        public DamageCommand(float value)
        {
            Value = value;
        }
    }
}