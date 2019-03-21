using System;

namespace Com.Beetsoft.AFE
{
    public interface IReceiveDamageable
    {
        void TakeDamage(IDamageMessage message);
    }

    public interface IReceiveDamageObserver
    {
        IObservable<IDamageMessage> OnTakeDamageAsObservable();
    }

    public static class ReceiveDamageableExtension
    {
        public static float GetDamageReceive(this IReceiveDamageable receiveDamageable, float dam, float resist)
        {
            return dam - dam * receiveDamageable.GetRateResistDamage(resist);
        }

        public static float GetRateResistDamage(this IReceiveDamageable receiveDamageable, float resist)
        {
            return resist / (100 + resist);
        }
    }
}