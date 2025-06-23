namespace DP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa karaktär med svärd
            var fighter = new Fighter(new MeleeAttack());
            fighter.PerformAttack();

            // Byt till pilbåge
            fighter.SetAttack(new RangedAttack());
            fighter.PerformAttack();

            // Byt till magi
            fighter.SetAttack(new MagicAttack());
            fighter.PerformAttack();
        }

        public interface IAttack
        {
            void Attack();
        }

        public class MeleeAttack : IAttack
        {
            public void Attack()
            {
                Console.WriteLine("Utför ett kraftfullt svärdslag!");
            }
        }

        public class RangedAttack : IAttack
        {
            public void Attack()
            {
                Console.WriteLine("Skjuter en pil från avstånd!");
            }
        }

        public class MagicAttack : IAttack
        {
            public void Attack()
            {
                Console.WriteLine("Kastar en eldboll!");
            }
        }

        public class Fighter
        {
            private IAttack _attack;

            public Fighter(IAttack attack)
            {
                _attack = attack;
            }

            public void PerformAttack()
            {
                _attack.Attack();
            }

            // Byt attack under spelets gång
            public void SetAttack(IAttack newAttack)
            {
                _attack = newAttack;
            }
        }
    }
}
